namespace GuessMelody
{
    partial class fMessage
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
            this.label_player = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.label_showAnswer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label_player
            // 
            this.label_player.AutoSize = true;
            this.label_player.Location = new System.Drawing.Point(105, 37);
            this.label_player.Name = "label_player";
            this.label_player.Size = new System.Drawing.Size(65, 17);
            this.label_player.TabIndex = 0;
            this.label_player.Text = "labelText";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(105, 88);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(16, 17);
            this.label_time.TabIndex = 1;
            this.label_time.Text = "0";
            // 
            // label_showAnswer
            // 
            this.label_showAnswer.AutoSize = true;
            this.label_showAnswer.Location = new System.Drawing.Point(105, 139);
            this.label_showAnswer.Name = "label_showAnswer";
            this.label_showAnswer.Size = new System.Drawing.Size(53, 17);
            this.label_showAnswer.TabIndex = 2;
            this.label_showAnswer.Text = "Melody";
            this.label_showAnswer.Click += new System.EventHandler(this.label_showAnswer_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button1.Location = new System.Drawing.Point(23, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Yes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button2.Location = new System.Drawing.Point(154, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "No";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // fMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_showAnswer);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label_player);
            this.Name = "fMessage";
            this.Text = "fMessage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fMessage_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_showAnswer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label label_player;
        private System.Windows.Forms.Timer timer;
    }
}