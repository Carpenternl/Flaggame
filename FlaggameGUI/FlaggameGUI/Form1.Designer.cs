namespace FlaggameGUI
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
            this.gameViewControl1 = new FlaggameGUI.GameViewControl();
            this.scoreBoard1 = new FlaggameGUI.ScoreBoardControl();
            this.SuspendLayout();
            // 
            // gameViewControl1
            // 
            this.gameViewControl1.Location = new System.Drawing.Point(12, 12);
            this.gameViewControl1.Name = "gameViewControl1";
            this.gameViewControl1.Size = new System.Drawing.Size(412, 375);
            this.gameViewControl1.TabIndex = 1;
            // 
            // scoreBoard1
            // 
            this.scoreBoard1.AutoSize = true;
            this.scoreBoard1.Location = new System.Drawing.Point(430, 12);
            this.scoreBoard1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scoreBoard1.Name = "scoreBoard1";
            this.scoreBoard1.Size = new System.Drawing.Size(250, 88);
            this.scoreBoard1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 588);
            this.Controls.Add(this.gameViewControl1);
            this.Controls.Add(this.scoreBoard1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScoreBoardControl scoreBoard1;
        private GameViewControl gameViewControl1;
    }
}

