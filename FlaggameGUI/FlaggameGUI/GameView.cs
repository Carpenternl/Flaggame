﻿using System;
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
    public partial class GameView : UserControl
    {
        public GameView()
        {
            InitializeComponent();
        }

        private void gameViewControl1_OnAnswer(object sender, CustomEventArg e)
        {
            this.scoreBoardControl1.updateScoreBoard(e.result);
        }
    }
}
