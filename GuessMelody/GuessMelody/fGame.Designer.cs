namespace GuessMelody
{
    partial class fGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGame));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.button_nextMelody = new System.Windows.Forms.Button();
            this.button_pause = new System.Windows.Forms.Button();
            this.button_continue = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_firstPlayer = new System.Windows.Forms.Label();
            this.label_melodyCounter = new System.Windows.Forms.Label();
            this.label_secondPlayer = new System.Windows.Forms.Label();
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.button1 = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_durationMelody = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // button_nextMelody
            // 
            this.button_nextMelody.Enabled = false;
            this.button_nextMelody.Location = new System.Drawing.Point(229, 214);
            this.button_nextMelody.Name = "button_nextMelody";
            this.button_nextMelody.Size = new System.Drawing.Size(137, 48);
            this.button_nextMelody.TabIndex = 0;
            this.button_nextMelody.Text = "Next";
            this.button_nextMelody.UseVisualStyleBackColor = true;
            this.button_nextMelody.Click += new System.EventHandler(this.button_nextMelody_Click);
            // 
            // button_pause
            // 
            this.button_pause.Location = new System.Drawing.Point(21, 338);
            this.button_pause.Name = "button_pause";
            this.button_pause.Size = new System.Drawing.Size(167, 48);
            this.button_pause.TabIndex = 1;
            this.button_pause.Text = "Pause";
            this.button_pause.UseVisualStyleBackColor = true;
            this.button_pause.Click += new System.EventHandler(this.button_pause_Click);
            // 
            // button_continue
            // 
            this.button_continue.Location = new System.Drawing.Point(256, 338);
            this.button_continue.Name = "button_continue";
            this.button_continue.Size = new System.Drawing.Size(155, 48);
            this.button_continue.TabIndex = 2;
            this.button_continue.Text = "Continue";
            this.button_continue.UseVisualStyleBackColor = true;
            this.button_continue.Click += new System.EventHandler(this.button_continue_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(21, 279);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(390, 44);
            this.progressBar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Player 2";
            // 
            // label_firstPlayer
            // 
            this.label_firstPlayer.AutoSize = true;
            this.label_firstPlayer.Location = new System.Drawing.Point(87, 108);
            this.label_firstPlayer.Name = "label_firstPlayer";
            this.label_firstPlayer.Size = new System.Drawing.Size(16, 17);
            this.label_firstPlayer.TabIndex = 6;
            this.label_firstPlayer.Text = "0";
            // 
            // label_melodyCounter
            // 
            this.label_melodyCounter.AutoSize = true;
            this.label_melodyCounter.Location = new System.Drawing.Point(204, 108);
            this.label_melodyCounter.Name = "label_melodyCounter";
            this.label_melodyCounter.Size = new System.Drawing.Size(16, 17);
            this.label_melodyCounter.TabIndex = 7;
            this.label_melodyCounter.Text = "0";
            // 
            // label_secondPlayer
            // 
            this.label_secondPlayer.AutoSize = true;
            this.label_secondPlayer.Location = new System.Drawing.Point(305, 108);
            this.label_secondPlayer.Name = "label_secondPlayer";
            this.label_secondPlayer.Size = new System.Drawing.Size(16, 17);
            this.label_secondPlayer.TabIndex = 8;
            this.label_secondPlayer.Text = "0";
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(21, 151);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(37, 47);
            this.WMP.TabIndex = 9;
            this.WMP.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(51, 214);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(137, 48);
            this.button_start.TabIndex = 11;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Duration Melody:";
            // 
            // label_durationMelody
            // 
            this.label_durationMelody.AutoSize = true;
            this.label_durationMelody.Location = new System.Drawing.Point(253, 151);
            this.label_durationMelody.Name = "label_durationMelody";
            this.label_durationMelody.Size = new System.Drawing.Size(16, 17);
            this.label_durationMelody.TabIndex = 13;
            this.label_durationMelody.Text = "0";
            // 
            // fGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 423);
            this.Controls.Add(this.label_durationMelody);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WMP);
            this.Controls.Add(this.label_secondPlayer);
            this.Controls.Add(this.label_melodyCounter);
            this.Controls.Add(this.label_firstPlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.button_continue);
            this.Controls.Add(this.button_pause);
            this.Controls.Add(this.button_nextMelody);
            this.KeyPreview = true;
            this.Name = "fGame";
            this.Text = "fGame";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fGame_FormClosed);
            this.Load += new System.EventHandler(this.fGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button button_nextMelody;
        private System.Windows.Forms.Button button_pause;
        private System.Windows.Forms.Button button_continue;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_firstPlayer;
        private System.Windows.Forms.Label label_melodyCounter;
        private System.Windows.Forms.Label label_secondPlayer;
        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_durationMelody;
    }
}