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
    public partial class GameViewControl : UserControl
    {
        List<string> ListOfImageFiles;
        string ResourceFilePath;
        Random randomizer;
        int[] RandomNamelocations;
        string CurrentAnswer;
        Button[] buttonlist = new Button[4];

        public GameViewControl()
        {
            InitializeComponent();

            randomizer = new Random();
            ResourceFilePath = @"..\..\resources";
            ResourceFilePath = @"D:\HugoT\Documents\GitRepos\Flaggame\FlaggameGUI\FlaggameGUI\resources";
            ListOfImageFiles = Directory.GetFiles(ResourceFilePath, "*.bmp").ToList();
            RandomNamelocations = new int[4];
            buttonlist[0] = button1;
            buttonlist[1] = button2;
            buttonlist[2] = button3;
            buttonlist[3] = button4;
        }

        private void updateQuestion()
        {
            pictureBox1.Image = Image.FromFile(ListOfImageFiles[0]);
            CurrentAnswer = quicktrim(ListOfImageFiles[0]);
            RandomNamelocations[0] = 0;
            for (int i = 1; i < 4; i++)
            {
                int a;
                do
                {
                     a = randomizer.Next(1, ListOfImageFiles.Count() - 1);
                    
                } while (RandomNamelocations.Contains(a));
                RandomNamelocations[i] = a;
            }
            RandomNamelocations = RandomNamelocations.OrderBy(x => randomizer.Next()).ToArray();
            for (int i = 0; i < 4; i++)
            {
                buttonlist[i].Text = quicktrim(ListOfImageFiles[RandomNamelocations[i]]);
            }
        }
        public string quicktrim(string filepath)
        {
            string result = filepath.Substring(ResourceFilePath.Count()+1, filepath.Count() - ResourceFilePath.Count() - 5);
            return result;
        }
        private void GameViewControl_Load(object sender, EventArgs e)
        {
            ListOfImageFiles = ListOfImageFiles.OrderBy(x => randomizer.Next()).ToList();
            updateQuestion();
        }

        public delegate void AnswerHandler(object sender, CustomEventArg e);
        public event AnswerHandler OnAnswer;

        public void SendAnswer(bool result)
        {
            if (OnAnswer == null) return;

            CustomEventArg args = new CustomEventArg(result);
            OnAnswer(this, args);
        }

        private void QuestionButtonClick(object sender, EventArgs e)
        {
            string fileZero = ListOfImageFiles[0];
            ListOfImageFiles.RemoveAt(0);
            Button ClickedButton = sender as Button;
            bool result = false;
            if(ClickedButton.Text == CurrentAnswer)
            {
                Console.WriteLine("Succes!");
                result = true;
                ListOfImageFiles.Add(fileZero);
            }
            else
            {
                Console.WriteLine("false");
                ListOfImageFiles.Insert(4, fileZero);
            }
            SendAnswer(result);
            updateQuestion();
        }

    }
}
