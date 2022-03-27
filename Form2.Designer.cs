namespace TS_Announce
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.volumeModifier = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.audioFormat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loadButton = new System.Windows.Forms.Button();
            this.entryTable = new System.Windows.Forms.DataGridView();
            this.fileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lattitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atStation = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dontSkip = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.deleteRows = new System.Windows.Forms.Button();
            this.clearAll = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.newEntry = new System.Windows.Forms.Button();
            this.playAtStation = new System.Windows.Forms.CheckBox();
            this.audioNameBox = new System.Windows.Forms.TextBox();
            this.audioName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeModifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryTable)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(363, 48);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(82, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.volumeModifier);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.audioFormat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 67);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // volumeModifier
            // 
            this.volumeModifier.Location = new System.Drawing.Point(226, 42);
            this.volumeModifier.Name = "volumeModifier";
            this.volumeModifier.Size = new System.Drawing.Size(107, 20);
            this.volumeModifier.TabIndex = 3;
            this.volumeModifier.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Volume Modifier:";
            // 
            // audioFormat
            // 
            this.audioFormat.FormattingEnabled = true;
            this.audioFormat.Items.AddRange(new object[] {
            "mp3",
            "wav"});
            this.audioFormat.Location = new System.Drawing.Point(226, 17);
            this.audioFormat.Name = "audioFormat";
            this.audioFormat.Size = new System.Drawing.Size(107, 21);
            this.audioFormat.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Audio Format:";
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(363, 24);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(82, 23);
            this.loadButton.TabIndex = 5;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // entryTable
            // 
            this.entryTable.AllowUserToDeleteRows = false;
            this.entryTable.AllowUserToResizeColumns = false;
            this.entryTable.AllowUserToResizeRows = false;
            this.entryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.entryTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileName,
            this.longitude,
            this.lattitude,
            this.atStation,
            this.dontSkip});
            this.entryTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.entryTable.Location = new System.Drawing.Point(12, 82);
            this.entryTable.Name = "entryTable";
            this.entryTable.Size = new System.Drawing.Size(433, 189);
            this.entryTable.TabIndex = 6;
            this.entryTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // fileName
            // 
            this.fileName.HeaderText = "Audio File";
            this.fileName.Name = "fileName";
            this.fileName.Width = 130;
            // 
            // longitude
            // 
            this.longitude.HeaderText = "Longitude";
            this.longitude.Name = "longitude";
            this.longitude.Width = 70;
            // 
            // lattitude
            // 
            this.lattitude.HeaderText = "Lattitude";
            this.lattitude.Name = "lattitude";
            this.lattitude.Width = 70;
            // 
            // atStation
            // 
            this.atStation.HeaderText = "At Station?";
            this.atStation.Name = "atStation";
            this.atStation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.atStation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.atStation.Width = 60;
            // 
            // dontSkip
            // 
            this.dontSkip.HeaderText = "Disable Skipping?";
            this.dontSkip.Name = "dontSkip";
            this.dontSkip.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dontSkip.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dontSkip.Width = 60;
            // 
            // deleteRows
            // 
            this.deleteRows.Location = new System.Drawing.Point(306, 290);
            this.deleteRows.Name = "deleteRows";
            this.deleteRows.Size = new System.Drawing.Size(139, 23);
            this.deleteRows.TabIndex = 7;
            this.deleteRows.Text = "Delete Selected Row(s)";
            this.deleteRows.UseVisualStyleBackColor = true;
            this.deleteRows.Click += new System.EventHandler(this.deleteRows_Click);
            // 
            // clearAll
            // 
            this.clearAll.Location = new System.Drawing.Point(306, 352);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(139, 23);
            this.clearAll.TabIndex = 8;
            this.clearAll.Text = "Clear all Rows";
            this.clearAll.UseVisualStyleBackColor = true;
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.audioName);
            this.groupBox2.Controls.Add(this.audioNameBox);
            this.groupBox2.Controls.Add(this.playAtStation);
            this.groupBox2.Controls.Add(this.newEntry);
            this.groupBox2.Location = new System.Drawing.Point(12, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 104);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input Wizard";
            // 
            // newEntry
            // 
            this.newEntry.Location = new System.Drawing.Point(10, 75);
            this.newEntry.Name = "newEntry";
            this.newEntry.Size = new System.Drawing.Size(272, 23);
            this.newEntry.TabIndex = 10;
            this.newEntry.Text = "Add new entry";
            this.newEntry.UseVisualStyleBackColor = true;
            this.newEntry.Click += new System.EventHandler(this.newEntry_Click);
            // 
            // playAtStation
            // 
            this.playAtStation.AutoSize = true;
            this.playAtStation.Location = new System.Drawing.Point(13, 52);
            this.playAtStation.Name = "playAtStation";
            this.playAtStation.Size = new System.Drawing.Size(166, 17);
            this.playAtStation.TabIndex = 11;
            this.playAtStation.Text = "Play audio when doors open?";
            this.playAtStation.UseVisualStyleBackColor = true;
            // 
            // audioNameBox
            // 
            this.audioNameBox.Location = new System.Drawing.Point(129, 22);
            this.audioNameBox.Name = "audioNameBox";
            this.audioNameBox.Size = new System.Drawing.Size(153, 20);
            this.audioNameBox.TabIndex = 12;
            // 
            // audioName
            // 
            this.audioName.AutoSize = true;
            this.audioName.Location = new System.Drawing.Point(10, 25);
            this.audioName.Name = "audioName";
            this.audioName.Size = new System.Drawing.Size(82, 13);
            this.audioName.TabIndex = 4;
            this.audioName.Text = "Audio Filename:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 392);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.deleteRows);
            this.Controls.Add(this.entryTable);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeModifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryTable)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox audioFormat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.DataGridView entryTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn lattitude;
        private System.Windows.Forms.DataGridViewCheckBoxColumn atStation;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dontSkip;
        private System.Windows.Forms.NumericUpDown volumeModifier;
        private System.Windows.Forms.Button deleteRows;
        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button newEntry;
        private System.Windows.Forms.Label audioName;
        private System.Windows.Forms.TextBox audioNameBox;
        private System.Windows.Forms.CheckBox playAtStation;
    }
}