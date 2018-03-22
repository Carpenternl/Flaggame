namespace FlaggameGUI
{
    partial class GameView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.gameViewControl1 = new FlaggameGUI.GameViewControl();
            this.scoreBoardControl1 = new FlaggameGUI.ScoreBoardControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gameViewControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.scoreBoardControl1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonReturn, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelInfo, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(829, 506);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonReturn.Location = new System.Drawing.Point(417, 468);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(409, 35);
            this.buttonReturn.TabIndex = 2;
            this.buttonReturn.Text = "go back";
            this.buttonReturn.UseVisualStyleBackColor = true;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelInfo.Location = new System.Drawing.Point(417, 433);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(409, 32);
            this.labelInfo.TabIndex = 3;
            this.labelInfo.Text = "select the name of the country that the flag belongs to. Scores are not kept afte" +
    "r you exit.";
            // 
            // gameViewControl1
            // 
            this.gameViewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameViewControl1.Location = new System.Drawing.Point(3, 3);
            this.gameViewControl1.Name = "gameViewControl1";
            this.tableLayoutPanel1.SetRowSpan(this.gameViewControl1, 3);
            this.gameViewControl1.Size = new System.Drawing.Size(408, 500);
            this.gameViewControl1.TabIndex = 0;
            this.gameViewControl1.OnAnswer += new FlaggameGUI.GameViewControl.AnswerHandler(this.gameViewControl1_OnAnswer);
            // 
            // scoreBoardControl1
            // 
            this.scoreBoardControl1.AutoSize = true;
            this.scoreBoardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreBoardControl1.Location = new System.Drawing.Point(417, 2);
            this.scoreBoardControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scoreBoardControl1.Name = "scoreBoardControl1";
            this.scoreBoardControl1.Size = new System.Drawing.Size(409, 228);
            this.scoreBoardControl1.TabIndex = 1;
            // 
            // GameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GameView";
            this.Size = new System.Drawing.Size(829, 506);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private GameViewControl gameViewControl1;
        private ScoreBoardControl scoreBoardControl1;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Label labelInfo;
    }
}
