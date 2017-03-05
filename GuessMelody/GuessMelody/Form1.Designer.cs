namespace GuessMelody
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
            this.button_Game = new System.Windows.Forms.Button();
            this.button_Settings = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Game
            // 
            this.button_Game.Location = new System.Drawing.Point(77, 41);
            this.button_Game.Name = "button_Game";
            this.button_Game.Size = new System.Drawing.Size(198, 60);
            this.button_Game.TabIndex = 0;
            this.button_Game.Text = "Game";
            this.button_Game.UseVisualStyleBackColor = true;
            this.button_Game.Click += new System.EventHandler(this.button_Game_Click);
            // 
            // button_Settings
            // 
            this.button_Settings.Location = new System.Drawing.Point(79, 139);
            this.button_Settings.Name = "button_Settings";
            this.button_Settings.Size = new System.Drawing.Size(198, 60);
            this.button_Settings.TabIndex = 1;
            this.button_Settings.Text = "Settings";
            this.button_Settings.UseVisualStyleBackColor = true;
            this.button_Settings.Click += new System.EventHandler(this.button_Settings_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(77, 234);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(198, 60);
            this.button_Exit.TabIndex = 2;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 338);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Settings);
            this.Controls.Add(this.button_Game);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Game;
        private System.Windows.Forms.Button button_Settings;
        private System.Windows.Forms.Button button_Exit;
    }
}

