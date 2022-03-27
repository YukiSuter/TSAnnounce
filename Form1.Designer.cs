using System;
using System.Runtime.InteropServices;

namespace First_App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rdBrowse = new System.Windows.Forms.Button();
            this.rd64Loc = new System.Windows.Forms.TextBox();
            this.configLoc = new System.Windows.Forms.TextBox();
            this.configBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.readButton = new System.Windows.Forms.Button();
            this.trackButton = new System.Windows.Forms.Button();
            this.trainName = new System.Windows.Forms.Label();
            this.trainNameLabel = new System.Windows.Forms.Label();
            this.latLabel = new System.Windows.Forms.Label();
            this.latLoc = new System.Windows.Forms.Label();
            this.longLabel = new System.Windows.Forms.Label();
            this.longLoc = new System.Windows.Forms.Label();
            this.naLabel = new System.Windows.Forms.Label();
            this.playSound = new System.Windows.Forms.Button();
            this.naText = new System.Windows.Forms.Label();
            this.atLat = new System.Windows.Forms.Label();
            this.playSoundNext = new System.Windows.Forms.Button();
            this.atLatLabel = new System.Windows.Forms.Label();
            this.atLong = new System.Windows.Forms.Label();
            this.nextSound = new System.Windows.Forms.Button();
            this.atLongLabel = new System.Windows.Forms.Label();
            this.playAtStation = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.playAtStationLabel = new System.Windows.Forms.Label();
            this.doorsLabel = new System.Windows.Forms.Label();
            this.doors = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.volSlider = new System.Windows.Forms.TrackBar();
            this.volLabel = new System.Windows.Forms.Label();
            this.zero = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.volSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdBrowse
            // 
            this.rdBrowse.Location = new System.Drawing.Point(522, 65);
            this.rdBrowse.Name = "rdBrowse";
            this.rdBrowse.Size = new System.Drawing.Size(107, 20);
            this.rdBrowse.TabIndex = 0;
            this.rdBrowse.Text = "Browse";
            this.rdBrowse.UseVisualStyleBackColor = true;
            this.rdBrowse.Click += new System.EventHandler(this.rdBrowseFunction);
            // 
            // rd64Loc
            // 
            this.rd64Loc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rd64Loc.Location = new System.Drawing.Point(138, 65);
            this.rd64Loc.Name = "rd64Loc";
            this.rd64Loc.Size = new System.Drawing.Size(378, 20);
            this.rd64Loc.TabIndex = 1;
            this.rd64Loc.Text = "Click browse or paste location here";
            this.rd64Loc.TextChanged += new System.EventHandler(this.rd64Loc_TextChanged);
            // 
            // configLoc
            // 
            this.configLoc.Location = new System.Drawing.Point(138, 104);
            this.configLoc.Name = "configLoc";
            this.configLoc.Size = new System.Drawing.Size(378, 20);
            this.configLoc.TabIndex = 3;
            this.configLoc.Text = "Click browse or paste location here";
            this.configLoc.TextChanged += new System.EventHandler(this.configLocTextFunction);
            // 
            // configBrowse
            // 
            this.configBrowse.Location = new System.Drawing.Point(522, 104);
            this.configBrowse.Name = "configBrowse";
            this.configBrowse.Size = new System.Drawing.Size(107, 20);
            this.configBrowse.TabIndex = 2;
            this.configBrowse.Text = "Browse";
            this.configBrowse.UseVisualStyleBackColor = true;
            this.configBrowse.Click += new System.EventHandler(this.configBrowseFunction);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(742, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please use the following utilities to setup the GPS announcement system. Raildriv" +
    "er64.dll is found in the \"\\plugins\\\" folder in your Train Simulator installation" +
    ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Announcement file:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "RailDriver64.dll location:";
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(635, 65);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(107, 20);
            this.readButton.TabIndex = 7;
            this.readButton.Text = "Read Files";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // trackButton
            // 
            this.trackButton.Location = new System.Drawing.Point(635, 104);
            this.trackButton.Name = "trackButton";
            this.trackButton.Size = new System.Drawing.Size(107, 20);
            this.trackButton.TabIndex = 8;
            this.trackButton.Text = "Start Tracking";
            this.trackButton.UseVisualStyleBackColor = true;
            this.trackButton.Click += new System.EventHandler(this.trackButton_Click);
            // 
            // trainName
            // 
            this.trainName.Location = new System.Drawing.Point(642, 146);
            this.trainName.Name = "trainName";
            this.trainName.Size = new System.Drawing.Size(100, 37);
            this.trainName.TabIndex = 9;
            this.trainName.Text = "-";
            this.trainName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trainNameLabel
            // 
            this.trainNameLabel.Location = new System.Drawing.Point(502, 150);
            this.trainNameLabel.Name = "trainNameLabel";
            this.trainNameLabel.Size = new System.Drawing.Size(100, 29);
            this.trainNameLabel.TabIndex = 10;
            this.trainNameLabel.Text = "Train Name:";
            this.trainNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // latLabel
            // 
            this.latLabel.Location = new System.Drawing.Point(502, 179);
            this.latLabel.Name = "latLabel";
            this.latLabel.Size = new System.Drawing.Size(100, 27);
            this.latLabel.TabIndex = 12;
            this.latLabel.Text = "Latitude:";
            this.latLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // latLoc
            // 
            this.latLoc.Location = new System.Drawing.Point(642, 171);
            this.latLoc.Name = "latLoc";
            this.latLoc.Size = new System.Drawing.Size(100, 42);
            this.latLoc.TabIndex = 11;
            this.latLoc.Text = "-";
            this.latLoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // longLabel
            // 
            this.longLabel.Location = new System.Drawing.Point(502, 204);
            this.longLabel.Name = "longLabel";
            this.longLabel.Size = new System.Drawing.Size(100, 32);
            this.longLabel.TabIndex = 14;
            this.longLabel.Text = "Longitude:";
            this.longLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // longLoc
            // 
            this.longLoc.Location = new System.Drawing.Point(642, 199);
            this.longLoc.Name = "longLoc";
            this.longLoc.Size = new System.Drawing.Size(100, 42);
            this.longLoc.TabIndex = 13;
            this.longLoc.Text = "-";
            this.longLoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // naLabel
            // 
            this.naLabel.Location = new System.Drawing.Point(12, 146);
            this.naLabel.Name = "naLabel";
            this.naLabel.Size = new System.Drawing.Size(100, 32);
            this.naLabel.TabIndex = 15;
            this.naLabel.Text = "Next Audio:";
            this.naLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // playSound
            // 
            this.playSound.Location = new System.Drawing.Point(352, 146);
            this.playSound.Name = "playSound";
            this.playSound.Size = new System.Drawing.Size(119, 25);
            this.playSound.TabIndex = 16;
            this.playSound.Text = "Play";
            this.playSound.UseVisualStyleBackColor = true;
            this.playSound.Click += new System.EventHandler(this.playSound_Click);
            // 
            // naText
            // 
            this.naText.Location = new System.Drawing.Point(142, 146);
            this.naText.Name = "naText";
            this.naText.Size = new System.Drawing.Size(204, 32);
            this.naText.TabIndex = 17;
            this.naText.Text = "-";
            this.naText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // atLat
            // 
            this.atLat.Location = new System.Drawing.Point(142, 174);
            this.atLat.Name = "atLat";
            this.atLat.Size = new System.Drawing.Size(204, 32);
            this.atLat.TabIndex = 20;
            this.atLat.Text = "-";
            this.atLat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // playSoundNext
            // 
            this.playSoundNext.Location = new System.Drawing.Point(352, 174);
            this.playSoundNext.Name = "playSoundNext";
            this.playSoundNext.Size = new System.Drawing.Size(119, 25);
            this.playSoundNext.TabIndex = 19;
            this.playSoundNext.Text = "Play/Next";
            this.playSoundNext.UseVisualStyleBackColor = true;
            this.playSoundNext.Click += new System.EventHandler(this.playSoundNext_Click);
            // 
            // atLatLabel
            // 
            this.atLatLabel.Location = new System.Drawing.Point(12, 174);
            this.atLatLabel.Name = "atLatLabel";
            this.atLatLabel.Size = new System.Drawing.Size(100, 32);
            this.atLatLabel.TabIndex = 18;
            this.atLatLabel.Text = "At Latitude:";
            this.atLatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // atLong
            // 
            this.atLong.Location = new System.Drawing.Point(142, 202);
            this.atLong.Name = "atLong";
            this.atLong.Size = new System.Drawing.Size(204, 32);
            this.atLong.TabIndex = 23;
            this.atLong.Text = "-";
            this.atLong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nextSound
            // 
            this.nextSound.Location = new System.Drawing.Point(352, 202);
            this.nextSound.Name = "nextSound";
            this.nextSound.Size = new System.Drawing.Size(119, 25);
            this.nextSound.TabIndex = 22;
            this.nextSound.Text = "Next";
            this.nextSound.UseVisualStyleBackColor = true;
            this.nextSound.Click += new System.EventHandler(this.nextSound_Click);
            // 
            // atLongLabel
            // 
            this.atLongLabel.Location = new System.Drawing.Point(12, 202);
            this.atLongLabel.Name = "atLongLabel";
            this.atLongLabel.Size = new System.Drawing.Size(100, 32);
            this.atLongLabel.TabIndex = 21;
            this.atLongLabel.Text = "At Longitude:";
            this.atLongLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // playAtStation
            // 
            this.playAtStation.Location = new System.Drawing.Point(142, 230);
            this.playAtStation.Name = "playAtStation";
            this.playAtStation.Size = new System.Drawing.Size(204, 32);
            this.playAtStation.TabIndex = 28;
            this.playAtStation.Text = "-";
            this.playAtStation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 25);
            this.button1.TabIndex = 27;
            this.button1.Text = "Previous";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.previousPos_Click);
            // 
            // playAtStationLabel
            // 
            this.playAtStationLabel.Location = new System.Drawing.Point(12, 230);
            this.playAtStationLabel.Name = "playAtStationLabel";
            this.playAtStationLabel.Size = new System.Drawing.Size(100, 32);
            this.playAtStationLabel.TabIndex = 26;
            this.playAtStationLabel.Text = "Play at Station:";
            this.playAtStationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // doorsLabel
            // 
            this.doorsLabel.Location = new System.Drawing.Point(502, 232);
            this.doorsLabel.Name = "doorsLabel";
            this.doorsLabel.Size = new System.Drawing.Size(100, 32);
            this.doorsLabel.TabIndex = 25;
            this.doorsLabel.Text = "Doors:";
            this.doorsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // doors
            // 
            this.doors.Location = new System.Drawing.Point(642, 227);
            this.doors.Name = "doors";
            this.doors.Size = new System.Drawing.Size(100, 42);
            this.doors.TabIndex = 24;
            this.doors.Text = "-";
            this.doors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Copyright © Yuki Suter 2022";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // volSlider
            // 
            this.volSlider.BackColor = System.Drawing.SystemColors.Control;
            this.volSlider.LargeChange = 20;
            this.volSlider.Location = new System.Drawing.Point(140, 253);
            this.volSlider.Maximum = 150;
            this.volSlider.Name = "volSlider";
            this.volSlider.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.volSlider.Size = new System.Drawing.Size(202, 45);
            this.volSlider.SmallChange = 5;
            this.volSlider.TabIndex = 20;
            this.volSlider.TickFrequency = 10;
            this.volSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volSlider.Value = 100;
            this.volSlider.Scroll += new System.EventHandler(this.volSlider_Scroll);
            // 
            // volLabel
            // 
            this.volLabel.Location = new System.Drawing.Point(12, 258);
            this.volLabel.Name = "volLabel";
            this.volLabel.Size = new System.Drawing.Size(100, 32);
            this.volLabel.TabIndex = 30;
            this.volLabel.Text = "Volume:";
            this.volLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // zero
            // 
            this.zero.AutoSize = true;
            this.zero.Location = new System.Drawing.Point(147, 282);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(13, 13);
            this.zero.TabIndex = 31;
            this.zero.Text = "0";
            this.zero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(258, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "100";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(317, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "150";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Black;
            this.imageList1.Images.SetKeyName(0, "paypal donate.png");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Like this software? A cup of coffee would be greatly appreciated!";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::TS_Announce.Properties.Resources.GitHub_Emblem;
            this.pictureBox2.Location = new System.Drawing.Point(505, 263);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::TS_Announce.Properties.Resources.paypal_donate;
            this.pictureBox1.Location = new System.Drawing.Point(628, 262);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(752, 24);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentationToolStripMenuItem,
            this.createEditToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fileToolStripMenuItem.Text = "Tools";
            // 
            // documentationToolStripMenuItem
            // 
            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            this.documentationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.documentationToolStripMenuItem.Text = "Documentation";
            // 
            // createEditToolStripMenuItem
            // 
            this.createEditToolStripMenuItem.Name = "createEditToolStripMenuItem";
            this.createEditToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createEditToolStripMenuItem.Text = "Create/Edit";
            this.createEditToolStripMenuItem.Click += new System.EventHandler(this.createEditToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(752, 331);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.volLabel);
            this.Controls.Add(this.volSlider);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.playAtStation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.playAtStationLabel);
            this.Controls.Add(this.doorsLabel);
            this.Controls.Add(this.doors);
            this.Controls.Add(this.atLong);
            this.Controls.Add(this.nextSound);
            this.Controls.Add(this.atLongLabel);
            this.Controls.Add(this.atLat);
            this.Controls.Add(this.playSoundNext);
            this.Controls.Add(this.atLatLabel);
            this.Controls.Add(this.naText);
            this.Controls.Add(this.playSound);
            this.Controls.Add(this.naLabel);
            this.Controls.Add(this.longLabel);
            this.Controls.Add(this.longLoc);
            this.Controls.Add(this.latLabel);
            this.Controls.Add(this.latLoc);
            this.Controls.Add(this.trainNameLabel);
            this.Controls.Add(this.trainName);
            this.Controls.Add(this.trackButton);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.configLoc);
            this.Controls.Add(this.configBrowse);
            this.Controls.Add(this.rd64Loc);
            this.Controls.Add(this.rdBrowse);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.volSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rdBrowse;
        private System.Windows.Forms.TextBox rd64Loc;
        private System.Windows.Forms.TextBox configLoc;
        private System.Windows.Forms.Button configBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Button trackButton;
        private System.Windows.Forms.Label trainName;
        private System.Windows.Forms.Label trainNameLabel;
        private System.Windows.Forms.Label latLabel;
        private System.Windows.Forms.Label latLoc;
        private System.Windows.Forms.Label longLabel;
        private System.Windows.Forms.Label longLoc;
        private System.Windows.Forms.Label naLabel;
        private System.Windows.Forms.Button playSound;
        private System.Windows.Forms.Label naText;
        private System.Windows.Forms.Label atLat;
        private System.Windows.Forms.Button playSoundNext;
        private System.Windows.Forms.Label atLatLabel;
        private System.Windows.Forms.Label atLong;
        private System.Windows.Forms.Button nextSound;
        private System.Windows.Forms.Label atLongLabel;
        private System.Windows.Forms.Label playAtStation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label playAtStationLabel;
        private System.Windows.Forms.Label doorsLabel;
        private System.Windows.Forms.Label doors;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar volSlider;
        private System.Windows.Forms.Label volLabel;
        private System.Windows.Forms.Label zero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

