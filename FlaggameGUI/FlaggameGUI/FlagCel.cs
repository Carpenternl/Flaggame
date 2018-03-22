using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlaggameGUI
{
    public partial class FlagCel : UserControl
    {
        public FlagCel(string filepath)
        {
            InitializeComponent();
            this.pictureBox1.Image = Image.FromFile(filepath);
            string fileBase = @"D:\HugoT\Documents\GitRepos\Flaggame\FlaggameGUI\FlaggameGUI\resources";
            string trimstring = filepath.Substring(fileBase.Count()+1, filepath.Count() - fileBase.Count() - 5);
            this.label1.Text = trimstring;
        }
    }
}
