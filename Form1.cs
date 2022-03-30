using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using TS_Announce;




namespace First_App
{


    public partial class Form1 : System.Windows.Forms.Form
    {

        public static bool tracking;
        public static float currentLAT;
        public static float currentLON;

        private Dictionary<int, bool> doorID;
        private Dictionary<string, bool> doorIDNames;
        private bool doorsOpen;


        private bool filesChecked = false;
        private int annPos = 0;

        private string configPath;
        private string dllLoc;

        // UPDATING VARS
       

        private WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        private Thread t;
        private static EventWaitHandle waitHandle = new ManualResetEvent(initialState: true);
        private Dictionary<string, dynamic> annData = new Dictionary<string, dynamic>() { };
        private Dictionary<string, dynamic> configData = new Dictionary<string, dynamic>() { };

        private Dictionary<string, dynamic> appSettings = new Dictionary<string, dynamic>() {};

        public Form1()
        {
            InitializeComponent();
            this.Text = "TSAnnounce v0.05a";
            waitHandle.Reset();
            wplayer.settings.volume = (int)(100 * (float)100 / 150);

            appSettings.Add("dllPath", "");
            appSettings.Add("volume", "");

            if (File.Exists("TSAnnounceSettings.json"))
            {
                string settingsjson = System.IO.File.ReadAllText("TSAnnounceSettings.json");
                Dictionary<string,dynamic> deserialised = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(settingsjson);
                Console.WriteLine("Checking JSON");
                int newvol = 100;

                foreach (KeyValuePair<string, dynamic> i in deserialised)
                {
                    if (i.Key == "dllPath")
                    {
                        appSettings["dllPath"] = i.Value;
                        dllLoc = i.Value;

                        rd64Loc.Text = i.Value + "\\RailDriver64.dll";
                    }
                    if (i.Key == "volume")
                    {
                        appSettings["volume"] = i.Value;
                        newvol = (int)i.Value;
                    }
                }
                Console.WriteLine("Setting Slider Value");
                volSlider.Value = newvol;
            }
            t = new Thread(ExtractDataThread);
            t.Start();
            t.IsBackground = true;
        }

        private void setDllPath()
        {
            if (dllLoc != "")
            {
                [DllImport("kernel32.dll", SetLastError = true)]
                static extern bool SetDllDirectory(string lpPathName);

                SetDllDirectory(dllLoc); // set to search in Plugins Folder
            }
            
        }

        private void playAudio(string audio)
        {
            volumeAdjust();
            wplayer.controls.stop();
            wplayer.URL = audio;
            wplayer.controls.play();
        }

        private void updateInfo()
        {

            naText.Text = annData[annPos.ToString()]["file"];
            if (File.Exists(configPath + "/audio/" + annData[annPos.ToString()]["file"]))
            {
                naText.ForeColor = Color.FromKnownColor(KnownColor.WindowText);
            }
            else
            {
                naText.ForeColor = Color.Red;
            }
            atLat.Text = annData[annPos.ToString()]["latitude"].ToString();
            atLong.Text = annData[annPos.ToString()]["longitude"].ToString();
            playAtStation.Text = annData[annPos.ToString()]["atStation"].ToString();
        }

        private void ExtractDataThread()
        {
            setDllPath();

            while (true)
            {
                waitHandle.WaitOne();
                [DllImport("RailDriver64.dll")]

                static extern void SetRailDriverConnected(bool Value);
                SetRailDriverConnected(true); // Connect RD

                


                // get values
                [DllImport("RailDriver64.dll")]
                static extern Single GetCurrentControllerValue(int Control);
                // DO DOOR STUFF
                Console.WriteLine("DEBUG LINE");

                foreach (KeyValuePair<int, bool> ID in doorID)
                {
                    float ControlVal = GetCurrentControllerValue(ID.Key);

                    Console.WriteLine(ControlVal);

                    if (ID.Value)
                    {
                        doorsOpen = !(Convert.ToBoolean(ControlVal));
                    }
                    else
                    {
                        doorsOpen = (Convert.ToBoolean(ControlVal));
                    }    

                }


                // DO DOOR STUFF

                currentLAT = GetCurrentControllerValue(400);
                currentLON = GetCurrentControllerValue(401);
                Action action = () => updateCurrentInfo();
                Invoke(action);

                checkDistance();

                Thread.Sleep(500);
            }
        }

        private void checkDistance()
        {
            float diffLat = (float)currentLAT - (float)annData[annPos.ToString()]["latitude"];
            float diffLon = (float)currentLON - (float)annData[annPos.ToString()]["longitude"];

            float totalDiff = (float)Math.Pow((float)Math.Pow(diffLat, 2) + Math.Pow(diffLon, 2), (float)1 / 2);
            //Console.WriteLine(totalDiff + " Away");
            float diffLat2;
            float diffLon2;
            float totalDiff2;
            if (annPos + 1 < annData.Count)
            {
                diffLat2 = (float)currentLAT - (float)annData[(annPos + 1).ToString()]["latitude"];
                diffLon2 = (float)currentLON - (float)annData[(annPos + 1).ToString()]["longitude"];

                totalDiff2 = (float)Math.Pow((float)Math.Pow(diffLat2, 2) + Math.Pow(diffLon2, 2), (float)1 / 2);
                Console.WriteLine("Next: " + totalDiff + " After: " + totalDiff2);
                if (totalDiff2 < totalDiff)
                {
                    Action action = () => advancePos();
                    Invoke(action);
                }
            }
            
            if (totalDiff <= 0.00025)
            {
                if (annData[annPos.ToString()]["atStation"] != true)
                {
                    Console.WriteLine("I'm nearby!");
                    if (wplayer.playState != WMPLib.WMPPlayState.wmppsPlaying)
                    {
                        string audio2Play = configPath + "/audio/" + annData[annPos.ToString()]["file"];
                        Action action2 = () => playAudio(audio2Play);
                        Invoke(action2);
                        Action action = () => advancePos();
                        Invoke(action);
                    }
                }
                if (false)
                {
                    Console.WriteLine("At Station!");
                    if (wplayer.playState != WMPLib.WMPPlayState.wmppsPlaying)
                    {
                        string audio2Play = configPath + "/audio/" + annData[annPos.ToString()]["file"];
                        Action action2 = () => playAudio(audio2Play);
                        Invoke(action2);
                        Action action = () => advancePos();
                        Invoke(action);
                    }
                }
                
            }
        }

        private void updateCurrentInfo()
        {
            latLoc.Text = currentLAT.ToString();
            longLoc.Text = currentLON.ToString();
            // UPDATE DOOR LABEL
            doors.Text = doorsOpen.ToString();
        }
        private void rdBrowseFunction(object sender, EventArgs e)
        {
            int size = -1;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                    rd64Loc.Text = file;
                }
                catch (IOException)
                {
                }
            }
            Console.WriteLine(size); // <-- Shows file size in debugging mode.
            Console.WriteLine(result); // <-- For debugging use.

        }


        private void configLocTextFunction(object sender, EventArgs e)
        {
            filesChecked = false;
            if (configLoc.ForeColor != Color.FromKnownColor(KnownColor.WindowText))
            {
                configLoc.ForeColor = Color.FromKnownColor(KnownColor.WindowText);
            }
        }
        private void rd64Loc_TextChanged(object sender, EventArgs e)
        {
            filesChecked = false;
            if (rd64Loc.ForeColor != Color.FromKnownColor(KnownColor.WindowText))
            {
                rd64Loc.ForeColor = Color.FromKnownColor(KnownColor.WindowText);
            }
        }
        private void configBrowseFunction(object sender, EventArgs e)
        {
            int size = -1;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                    configLoc.Text = file;
                }
                catch (IOException)
                {
                }
            }
            Console.WriteLine(size); // <-- Shows file size in debugging mode.
            Console.WriteLine(result); // <-- For debugging use.
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saveSettings()
        {
            appSettings["dllPath"] = dllLoc;
            appSettings["volume"] = volSlider.Value;

            string convertedToJson = JsonConvert.SerializeObject(appSettings, Newtonsoft.Json.Formatting.Indented);
            string[] toSave = { convertedToJson };
            File.WriteAllLines("TSAnnounceSettings.json", toSave);
            
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            // Check RailDriver64.dll Location
            annPos = 0;
            bool rdSuccess = false;
            bool configSuccess = false;

            string rdBoxText = rd64Loc.Text;
            string configBoxText = configLoc.Text;
            if (File.Exists(rdBoxText))
            {
                if (Path.GetFileName(rdBoxText) == "RailDriver64.dll")
                {
                    Console.WriteLine("RD Path Correct!");
                    rdSuccess = true;
                    dllLoc = System.IO.Directory.GetParent(rdBoxText).FullName;
                    Console.WriteLine(dllLoc);
                    rd64Loc.ForeColor = Color.Green;
                    saveSettings();
                }
                else
                {
                    Console.WriteLine("RD Path Incorrect!");
                    rd64Loc.Text = "Error #01: Please check you have selected RailDriver64.dll";
                    rd64Loc.ForeColor = Color.Red;
                    rdSuccess = false;
                }

            }
            else
            { }

            if (File.Exists(configBoxText))
            {
                try
                {

                    configPath = System.IO.Directory.GetParent(configBoxText).FullName;
                    Console.WriteLine(configPath);
                    string jsonstring = System.IO.File.ReadAllText(configBoxText);
                    Console.WriteLine(jsonstring);
                    annConfig deserialised = JsonConvert.DeserializeObject<annConfig>(jsonstring);
                    Console.WriteLine("Checking JSON");
                    foreach (KeyValuePair<string, dynamic> i in deserialised.Configuration)
                    {
                        configData[i.Key] = i.Value;
                    }
                    //foreach (KeyValuePair<string, Dictionary<string, dynamic>> i in deserialised.Announcements)
                    //{
                    //    annData = new Dictionary<string, dynamic>();
                    //    KeyValuePair<string, dynamic> annInfo;


                    //    foreach (KeyValuePair<string, dynamic> j in i.Value)
                    //    {
                    //        Console.WriteLine(i.Key + " > " + j.Key + " = " + j.Value);
                    //        annInfo = new KeyValuePair<string, dynamic>(j.Key, j.Value);
                    //    }
                    //
                    //    annData.Add(new KeyValuePair<string, dynamic>(i.Key, annInfo));
                    //}
                    //foreach (KeyValuePair<string,dynamic> p in annData)
                    //{
                    //    Console.WriteLine(p.Key + " | " + p.Value);
                    //}
                    annData = new Dictionary<string, dynamic>();
                    foreach (KeyValuePair<string, Dictionary<string, dynamic>> i in deserialised.Announcements)
                    {

                        annData.Add(i.Key, i.Value);
                    }
                    foreach (KeyValuePair<string, dynamic> j in annData)
                    {
                        Console.WriteLine(j.Key + " | " + j.Value);
                    }

                    updateInfo();
                    configLoc.ForeColor = Color.Green;
                    configSuccess = true;
                }
                catch
                {
                    configLoc.Text = "Error #03: Invalid config file. Please check validity of file.";
                    configLoc.ForeColor = Color.Red;
                }
            }
            else
            {
                Console.WriteLine("Config Path Incorrect!");
                configLoc.Text = "Error #02: Please check you have selected a valid file.";
                configLoc.ForeColor = Color.Red;
                configSuccess = false;
            }

            if (rdSuccess && configSuccess)
            {
                filesChecked = true;
            }
            else
            {
                filesChecked = false;
            }
        }

        private void trackButton_Click(object sender, EventArgs e)
        {

            if (tracking)
            {
                tracking = false;
                waitHandle.Reset();
                trackButton.Text = "Start Tracking";
            }
            else
            {
                if (filesChecked)
                {
                    trackButton.Text = "Stop Tracking";
                    string dllLoc = rd64Loc.Text;

                    setDllPath();

                    [DllImport("RailDriver64.dll")]
                    static extern IntPtr GetLocoName();
                    string currentLoco = System.Runtime.InteropServices.Marshal.PtrToStringAnsi(GetLocoName());
                    string[] splitter = currentLoco.Split(new string[] { ".:." }, StringSplitOptions.RemoveEmptyEntries);
                    if (splitter.Length > 0)
                    {
                        trainName.Text = splitter?[2];
                    }
                    

                    [DllImport("RailDriver64.dll", CallingConvention = CallingConvention.Cdecl)]
                    static extern IntPtr GetControllerList();
                    String tmp = System.Runtime.InteropServices.Marshal.PtrToStringAnsi(GetControllerList());
                    String[] ControllerList = tmp.Split(new string[] { "::" }, StringSplitOptions.RemoveEmptyEntries);

                    Console.WriteLine("Check Door IDs");
                    // CHECK DOOR ID LIST
                    doorID = new Dictionary<int, bool> { };

                    foreach (KeyValuePair<string,bool> l in doorIDNames)
                    {
                        Console.WriteLine("Check Door IDNames1");
                        for (int i = 0; i < ControllerList.Length; i++)
                        {
                            if (ControllerList[i] == l.Key)
                            {
                                Console.WriteLine("Check Door IDNames2");
                                Console.WriteLine(l.Value);
                                Console.WriteLine(i);
                                doorID.Add(i, l.Value);
                            }
                            
                        }    
                            
                    }
                    tracking = true;
                    waitHandle.Set();

                }
                else
                {
                    trackButton.Text = "Press Read ^^";
                }
            }
        }

        private void advancePos()
        {
            if (annPos + 1 < annData.Count)
            {
                annPos += 1;
            }
            else
            {
                annPos = 1;
            }
            updateInfo();
        }

        private void previousPos()
        {
            if (annPos > 0)
            {
                annPos = annPos - 1;
            }
            else
            {
                annPos = annData.Count - 1;
            }
            updateInfo();
        }

        private void playSoundNext_Click(object sender, EventArgs e)
        {
            string audio2Play = configPath + "/audio/" + annData[annPos.ToString()]["file"];
            advancePos();
            playAudio(audio2Play);
        }

        private void nextSound_Click(object sender, EventArgs e)
        {
            advancePos();
        }

        private void playSound_Click(object sender, EventArgs e)
        {
            string audio2Play = configPath + "/audio/" + annData[annPos.ToString()]["file"];
            playAudio(audio2Play);
        }

        private void volSlider_Scroll(object sender, EventArgs e)
        {
            volumeAdjust();
        }
        private void volumeAdjust()
        {
            int realMax = 100;
            int sliderMax = 150;
            float inputVal = (float)volSlider.Value;

            try
            {
                inputVal = (float)volSlider.Value * (float)configData["volumeModifier"] / 100;
            }
            catch(Exception)
            {
                Console.WriteLine("Config Data not found");
            }

            float volLevel = inputVal * (float)realMax / sliderMax;
            Console.WriteLine(volLevel);
            wplayer.settings.volume = (int)volLevel;

            saveSettings(); 
        }

        private void previousPos_Click(object sender, EventArgs e)
        {
            previousPos();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string url = "https://www.paypal.com/donate/?hosted_button_id=6JE9UWGP5MVM4";

            
            System.Diagnostics.Process.Start(url);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/YukiSuter/TSAnnounce");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void createEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new TS_Announce.Form2();
            f2.Show();
        }

        private void documentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Documentation.pdf");
        }

        private void selectTrainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog trainDialog = new OpenFileDialog();

            Console.WriteLine(System.Environment.CurrentDirectory + "\\Trains");

            trainDialog.InitialDirectory = System.Environment.CurrentDirectory + "\\Trains";
            DialogResult result = trainDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = trainDialog.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    try
                    {
                        configPath = System.IO.Directory.GetParent(file).FullName;
                        Console.WriteLine(configPath);
                        string jsonstring = System.IO.File.ReadAllText(file);
                        Console.WriteLine(jsonstring);
                        trainConfig deserialised = JsonConvert.DeserializeObject<trainConfig>(jsonstring);
                        Console.WriteLine("Checking JSON");
                        doorIDNames = new Dictionary<string, bool> { };
                        foreach (KeyValuePair<string, dynamic> i in deserialised.InterlockNames)
                        {
                            Console.WriteLine("Checking Interlock Names");
                            if (i.Key == "Interlock")
                            {
                                Console.WriteLine("Found the interlock ID list: " + i.Value.Count);
                                for (int number = 0; number <= i.Value.Count-1; number++)
                                {
                                    string controlID = i.Value[number]; 
                                    Console.WriteLine(controlID);
                                    Console.WriteLine("Found an interlock name");
                                    Console.WriteLine("Adding to acceptable IDs: " + controlID);
                                    doorIDNames.Add(controlID, false);
                                    
                                }
                                
                            }
                            Console.WriteLine("Moving on to inverse IDs");
                            if (i.Key == "InverseInterlock")
                            {
                                Console.WriteLine("Found the inverse interlock ID list: " + i.Value.Count);
                                for (int number = 0; number <= i.Value.Count - 1; number++)
                                {
                                    string controlID = i.Value[number];
                                    Console.WriteLine(controlID);
                                    Console.WriteLine("Found an inverse interlock name");
                                    Console.WriteLine("Adding to acceptable IDs: " + controlID);
                                    doorIDNames.Add(controlID, true);

                                }
                            }
                        }
                    }
                    catch
                    {
                    }
                }
                catch (IOException)
                {
                }
            }
        }
    }
    public class annConfig
    {
        public Dictionary<string, dynamic> Configuration { get; set; }
        public Dictionary<string, Dictionary<string, dynamic>> Announcements { get; set; }
    }

    public class trainConfig
    {
        public Dictionary<string, dynamic> InterlockNames { get; set; }
    }
}