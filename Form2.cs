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
using System.Globalization; 
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using First_App;

namespace TS_Announce
{
    public partial class Form2 : Form
    {


        private Dictionary<string, dynamic> annData = new Dictionary<string, dynamic>() { };
        private Dictionary<string, dynamic> configData = new Dictionary<string, dynamic>() { };
        public Form2()
        {
            InitializeComponent();

            this.Text = "Create/Edit TSA Config";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                }
                catch (IOException)
                {
                }

                try
                {
                    clearAll_Click(null,null);
                    string configPath = System.IO.Directory.GetParent(file).FullName;
                    Console.WriteLine(configPath);
                    string jsonstring = System.IO.File.ReadAllText(file);
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
                    FillConfig();
                    FillTable();
                }
                catch
                {
                    MessageBox.Show("Error #03: Invalid config file. Please check validity of file.");
                }
            }
        }
        private void FillConfig()
        {
            audioFormat.Text = configData["audioFormat"];
            volumeModifier.Value = configData["volumeModifier"];
        }
        private void FillTable()
        {
            entryTable.SelectAll();
            entryTable.ClearSelection();

            foreach (KeyValuePair<string, dynamic> j in annData)
            {
                entryTable.Rows.Add(j.Value["file"], j.Value["latitude"], j.Value["longitude"], j.Value["atStation"], j.Value["dontSkip"]);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, dynamic> toSave = new Dictionary<string, dynamic>();
            toSave.Add("Configuration", new Dictionary<string, dynamic>());
            toSave.Add("Announcements", new Dictionary<string, dynamic>());

            configData["audioFormat"] = audioFormat.Text;
            configData["volumeModifier"] = (int)volumeModifier.Value;

            annData = new Dictionary<string, dynamic>() { };

            int rowN = 0;

            foreach (DataGridViewRow row in entryTable.Rows)
            {
                annData.Add(rowN.ToString(), new Dictionary<string, dynamic>());


                annData[rowN.ToString()].Add("file", row.Cells[0].Value);
                annData[rowN.ToString()].Add("latitude", row.Cells[1].Value);
                annData[rowN.ToString()].Add("longitude", row.Cells[2].Value);
                annData[rowN.ToString()].Add("atStation", row.Cells[3].Value);
                annData[rowN.ToString()].Add("dontSkip", row.Cells[4].Value);
                rowN++;
            }

            annData.Remove((rowN-1).ToString());

            foreach (KeyValuePair<string, dynamic> j in annData)
            {
                toSave["Announcements"].Add(j.Key,j.Value);
            }

            foreach (KeyValuePair<string, dynamic> j in configData)
            {
                Console.WriteLine(j.Key);
                Console.WriteLine(j.Value);
                toSave["Configuration"].Add(j.Key, j.Value);
            }
            

            string convertedToJson = JsonConvertEx.SerializeObject(toSave);
            string[] jsoned = { convertedToJson };
            Console.WriteLine(convertedToJson);

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "TSAnnounce Configuration | *.json";
            saveFileDialog1.Title = "Save a Configuration File";
            Console.WriteLine("Debugs");
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine("Debug");
                Console.WriteLine(saveFileDialog1.FileName);
                if (File.Exists(saveFileDialog1.FileName))
                {
                    File.WriteAllLines(saveFileDialog1.FileName, jsoned);
                    
                }
                else
                {
                    Console.WriteLine("Creating File");
                    File.WriteAllLines(saveFileDialog1.FileName, jsoned);
                }
            }
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            entryTable.Rows.Clear();
        }

        private void deleteRows_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
                entryTable.Rows.GetRowCount(DataGridViewElementStates.Selected);
            for (int i = 0; i < selectedRowCount; i++)
            {
                entryTable.Rows.RemoveAt(entryTable.SelectedRows[i].Index);
            }
        }

        private void newEntry_Click(object sender, EventArgs e)
        {
            if (First_App.Form1.tracking)
            {
                entryTable.Rows.Add(audioNameBox.Text, First_App.Form1.currentLAT, First_App.Form1.currentLON, playAtStation.Checked, false);
            }
            else
            {
                MessageBox.Show("Please start tracking on the main window before starting the wizard.");
            }
        }

    }

    public class annConfig
    {
        public Dictionary<string, dynamic> Configuration { get; set; }
        public Dictionary<string, Dictionary<string, dynamic>> Announcements { get; set; }
    }

    public static class JsonConvertEx
    {
        public static string SerializeObject<T>(T value)
        {
            StringBuilder sb = new StringBuilder(256);
            StringWriter sw = new StringWriter(sb, CultureInfo.InvariantCulture);

            var jsonSerializer = JsonSerializer.CreateDefault();
            using (JsonTextWriter jsonWriter = new JsonTextWriter(sw))
            {
                jsonWriter.Formatting = Formatting.Indented;
                jsonWriter.IndentChar = '\t';
                jsonWriter.Indentation = 1;

                jsonSerializer.Serialize(jsonWriter, value, typeof(T));
            }

            return sw.ToString();
        }
    }
}
