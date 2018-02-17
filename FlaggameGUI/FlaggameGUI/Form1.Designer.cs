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
            this.scoreBoard1 = new FlaggameGUI.ScoreBoard();
            this.SuspendLayout();
            // 
            // scoreBoard1
            // 
            this.scoreBoard1.AutoSize = true;
            this.scoreBoard1.Location = new System.Drawing.Point(404, 12);
            this.scoreBoard1.Name = "scoreBoard1";
            this.scoreBoard1.Size = new System.Drawing.Size(348, 179);
            this.scoreBoard1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 353);
            this.Controls.Add(this.scoreBoard1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScoreBoard scoreBoard1;
    }
}

