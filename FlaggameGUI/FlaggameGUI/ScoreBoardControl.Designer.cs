namespace FlaggameGUI
{
    partial class ScoreBoardControl
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
            this.labelCurrentScore = new System.Windows.Forms.Label();
            this.labelCurrentScoreResult = new System.Windows.Forms.Label();
            this.labelLastScore = new System.Windows.Forms.Label();
            this.labelLastScoreResult = new System.Windows.Forms.Label();
            this.LabelHighScore = new System.Windows.Forms.Label();
            this.labelHighScoreResult = new System.Windows.Forms.Label();
            this.LabelCurrentAverage = new System.Windows.Forms.Label();
            this.labelAverageAccuracyResult = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelAverageAccuracyResult, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.LabelCurrentAverage, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelHighScoreResult, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LabelHighScore, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelLastScoreResult, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelLastScore, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelCurrentScoreResult, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelCurrentScore, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(596, 381);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelCurrentScore
            // 
            this.labelCurrentScore.AutoSize = true;
            this.labelCurrentScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCurrentScore.Location = new System.Drawing.Point(3, 3);
            this.labelCurrentScore.Margin = new System.Windows.Forms.Padding(3);
            this.labelCurrentScore.Name = "labelCurrentScore";
            this.labelCurrentScore.Size = new System.Drawing.Size(292, 89);
            this.labelCurrentScore.TabIndex = 0;
            this.labelCurrentScore.Text = "Current Score";
            this.labelCurrentScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCurrentScoreResult
            // 
            this.labelCurrentScoreResult.AutoSize = true;
            this.labelCurrentScoreResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCurrentScoreResult.Location = new System.Drawing.Point(301, 3);
            this.labelCurrentScoreResult.Margin = new System.Windows.Forms.Padding(3);
            this.labelCurrentScoreResult.Name = "labelCurrentScoreResult";
            this.labelCurrentScoreResult.Size = new System.Drawing.Size(292, 89);
            this.labelCurrentScoreResult.TabIndex = 1;
            this.labelCurrentScoreResult.Text = "0";
            this.labelCurrentScoreResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLastScore
            // 
            this.labelLastScore.AutoSize = true;
            this.labelLastScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLastScore.Location = new System.Drawing.Point(3, 98);
            this.labelLastScore.Margin = new System.Windows.Forms.Padding(3);
            this.labelLastScore.Name = "labelLastScore";
            this.labelLastScore.Size = new System.Drawing.Size(292, 89);
            this.labelLastScore.TabIndex = 2;
            this.labelLastScore.Text = "Last Score";
            this.labelLastScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLastScoreResult
            // 
            this.labelLastScoreResult.AutoSize = true;
            this.labelLastScoreResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLastScoreResult.Location = new System.Drawing.Point(301, 98);
            this.labelLastScoreResult.Margin = new System.Windows.Forms.Padding(3);
            this.labelLastScoreResult.Name = "labelLastScoreResult";
            this.labelLastScoreResult.Size = new System.Drawing.Size(292, 89);
            this.labelLastScoreResult.TabIndex = 3;
            this.labelLastScoreResult.Text = "0";
            this.labelLastScoreResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelHighScore
            // 
            this.LabelHighScore.AutoSize = true;
            this.LabelHighScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelHighScore.Location = new System.Drawing.Point(3, 193);
            this.LabelHighScore.Margin = new System.Windows.Forms.Padding(3);
            this.LabelHighScore.Name = "LabelHighScore";
            this.LabelHighScore.Size = new System.Drawing.Size(292, 89);
            this.LabelHighScore.TabIndex = 4;
            this.LabelHighScore.Text = "HighScore";
            this.LabelHighScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelHighScoreResult
            // 
            this.labelHighScoreResult.AutoSize = true;
            this.labelHighScoreResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHighScoreResult.Location = new System.Drawing.Point(301, 193);
            this.labelHighScoreResult.Margin = new System.Windows.Forms.Padding(3);
            this.labelHighScoreResult.Name = "labelHighScoreResult";
            this.labelHighScoreResult.Size = new System.Drawing.Size(292, 89);
            this.labelHighScoreResult.TabIndex = 5;
            this.labelHighScoreResult.Text = "0";
            this.labelHighScoreResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelCurrentAverage
            // 
            this.LabelCurrentAverage.AutoSize = true;
            this.LabelCurrentAverage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelCurrentAverage.Location = new System.Drawing.Point(3, 288);
            this.LabelCurrentAverage.Margin = new System.Windows.Forms.Padding(3);
            this.LabelCurrentAverage.Name = "LabelCurrentAverage";
            this.LabelCurrentAverage.Size = new System.Drawing.Size(292, 90);
            this.LabelCurrentAverage.TabIndex = 6;
            this.LabelCurrentAverage.Text = "Average Accuracy";
            this.LabelCurrentAverage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAverageAccuracyResult
            // 
            this.labelAverageAccuracyResult.AutoSize = true;
            this.labelAverageAccuracyResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAverageAccuracyResult.Location = new System.Drawing.Point(301, 288);
            this.labelAverageAccuracyResult.Margin = new System.Windows.Forms.Padding(3);
            this.labelAverageAccuracyResult.Name = "labelAverageAccuracyResult";
            this.labelAverageAccuracyResult.Size = new System.Drawing.Size(292, 90);
            this.labelAverageAccuracyResult.TabIndex = 7;
            this.labelAverageAccuracyResult.Text = "0";
            this.labelAverageAccuracyResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ScoreBoard";
            this.Size = new System.Drawing.Size(596, 381);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelAverageAccuracyResult;
        private System.Windows.Forms.Label LabelCurrentAverage;
        private System.Windows.Forms.Label labelHighScoreResult;
        private System.Windows.Forms.Label LabelHighScore;
        private System.Windows.Forms.Label labelLastScoreResult;
        private System.Windows.Forms.Label labelLastScore;
        private System.Windows.Forms.Label labelCurrentScoreResult;
        private System.Windows.Forms.Label labelCurrentScore;
    }
}
