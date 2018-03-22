using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FlaggameGUI
{
    public partial class FlagOverview : UserControl
    {
        public FlagOverview()
        {
            InitializeComponent();
        }

        private void FlagOverview_Load(object sender, EventArgs e)
        {
            string ResourceFilePath = @"D:\HugoT\Documents\GitRepos\Flaggame\FlaggameGUI\FlaggameGUI\resources";
            string[] files = Directory.GetFiles(ResourceFilePath, "*.bmp");
            foreach (var item in files)
            {
                this.flowLayoutPanel1.Controls.Add(new FlagCel(item));
            }
        }
    }
}
