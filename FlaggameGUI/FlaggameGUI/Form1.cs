using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlaggameGUI
{
    public partial class Form1 : Form
    {
        FlagOverview Checkview = new FlagOverview();
        GameView gameview = new GameView();
        
        public Form1()
        {
            InitializeComponent();
            Checkview.Dock = DockStyle.Fill;
            Checkview.VerticalScroll.Enabled = true;
            gameview.Dock = DockStyle.Fill;
            this.Controls.Add(Checkview);
        }

        private void Menu_item_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem clickedItem = e.ClickedItem;
            if (clickedItem.Text.ToLower() == "overview")
            {
                if (this.Controls.Contains(gameview))
                {
                    this.Controls.Remove(gameview);
                    
                }
                this.Controls.Add(Checkview);
            }
            if (clickedItem.Text.ToLower() == "practice")
            {
                if (this.Controls.Contains(Checkview))
                {
                    this.Controls.Remove(Checkview);
                    
                }
                this.Controls.Add(gameview);
            }

        }
    }
}
