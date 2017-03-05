namespace GuessMelody
{
    partial class fParams
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
            this.listBox_music = new System.Windows.Forms.ListBox();
            this.button_selectFolder = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_timeForAnswer = new System.Windows.Forms.ComboBox();
            this.comboBox_musicDuration = new System.Windows.Forms.ComboBox();
            this.comboBox_gameDuration = new System.Windows.Forms.ComboBox();
            this.checkBox_useSubdirs = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_music
            // 
            this.listBox_music.FormattingEnabled = true;
            this.listBox_music.ItemHeight = 16;
            this.listBox_music.Location = new System.Drawing.Point(0, 1);
            this.listBox_music.Name = "listBox_music";
            this.listBox_music.Size = new System.Drawing.Size(649, 212);
            this.listBox_music.TabIndex = 0;
            // 
            // button_selectFolder
            // 
            this.button_selectFolder.Location = new System.Drawing.Point(13, 220);
            this.button_selectFolder.Name = "button_selectFolder";
            this.button_selectFolder.Size = new System.Drawing.Size(155, 39);
            this.button_selectFolder.TabIndex = 1;
            this.button_selectFolder.Text = "Select folder";
            this.button_selectFolder.UseVisualStyleBackColor = true;
            this.button_selectFolder.Click += new System.EventHandler(this.button_selectFolder_Click_1);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(480, 468);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(108, 39);
            this.button_OK.TabIndex = 2;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click_1);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(603, 468);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(108, 39);
            this.button_Cancel.TabIndex = 3;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_timeForAnswer);
            this.groupBox1.Controls.Add(this.comboBox_musicDuration);
            this.groupBox1.Controls.Add(this.comboBox_gameDuration);
            this.groupBox1.Controls.Add(this.checkBox_useSubdirs);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 232);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game settings";
            // 
            // comboBox_timeForAnswer
            // 
            this.comboBox_timeForAnswer.FormattingEnabled = true;
            this.comboBox_timeForAnswer.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox_timeForAnswer.Location = new System.Drawing.Point(149, 146);
            this.comboBox_timeForAnswer.Name = "comboBox_timeForAnswer";
            this.comboBox_timeForAnswer.Size = new System.Drawing.Size(99, 24);
            this.comboBox_timeForAnswer.TabIndex = 6;
            // 
            // comboBox_musicDuration
            // 
            this.comboBox_musicDuration.FormattingEnabled = true;
            this.comboBox_musicDuration.Items.AddRange(new object[] {
            "5",
            "7",
            "9",
            "11",
            "13",
            "15"});
            this.comboBox_musicDuration.Location = new System.Drawing.Point(149, 102);
            this.comboBox_musicDuration.Name = "comboBox_musicDuration";
            this.comboBox_musicDuration.Size = new System.Drawing.Size(99, 24);
            this.comboBox_musicDuration.TabIndex = 5;
            // 
            // comboBox_gameDuration
            // 
            this.comboBox_gameDuration.FormattingEnabled = true;
            this.comboBox_gameDuration.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.comboBox_gameDuration.Location = new System.Drawing.Point(149, 57);
            this.comboBox_gameDuration.Name = "comboBox_gameDuration";
            this.comboBox_gameDuration.Size = new System.Drawing.Size(99, 24);
            this.comboBox_gameDuration.TabIndex = 4;
            // 
            // checkBox_useSubdirs
            // 
            this.checkBox_useSubdirs.AutoSize = true;
            this.checkBox_useSubdirs.Location = new System.Drawing.Point(47, 193);
            this.checkBox_useSubdirs.Name = "checkBox_useSubdirs";
            this.checkBox_useSubdirs.Size = new System.Drawing.Size(98, 21);
            this.checkBox_useSubdirs.TabIndex = 3;
            this.checkBox_useSubdirs.Text = "Use subdir";
            this.checkBox_useSubdirs.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time answer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Music time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game time";
            // 
            // fParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 519);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.button_selectFolder);
            this.Controls.Add(this.listBox_music);
            this.Name = "fParams";
            this.Text = "fParams";
            this.Load += new System.EventHandler(this.fParams_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_music;
        private System.Windows.Forms.Button button_selectFolder;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_timeForAnswer;
        private System.Windows.Forms.ComboBox comboBox_musicDuration;
        private System.Windows.Forms.ComboBox comboBox_gameDuration;
        private System.Windows.Forms.CheckBox checkBox_useSubdirs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}