using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCC
{
    public partial class CodingChallenge : Form
    {
        public string imagePath = "../../../Resources/Images/", filePath = "../../../Resources/Files/", videoPath = "../../../Resources/Videos/", iconPath = "../../../Resources/Icons/";
        String[] codingQuestions;
        String[]QandA;
        int questionNumber = 0;

        public CodingChallenge()
        {
            InitializeComponent();
            BackgroundImage = Image.FromFile(imagePath + "mainBG.png");
            Next.Enabled = false;
            Back.Enabled= false;
            codingQuestions = File.ReadAllLines(filePath + "CodingChallengeData.txt");
            QandA = codingQuestions[questionNumber].Split(",");
            QandA[1].Trim();
            Question.Text = QandA[0];//Fatma
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (questionNumber < 23)
            {
                QandA = codingQuestions[++questionNumber].Split(",");
                QandA[1].Trim();
                Question.Text = QandA[0];//Shahd
                Question.Location = new Point((Width / 2) - (Question.Width / 2), Question.Height);
                Next.Enabled = false;
                Back.Enabled = true;
            }
            else
            {
                MessageBox.Show("This is the last question");
            }
        }
        private void MathsChallenge_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (questionNumber > 0)
            {
                QandA = codingQuestions[--questionNumber].Split(",");
                QandA[1].Trim();
                Question.Text = QandA[0];//Shahd
                Question.Location = new Point((Width / 2) - (Question.Width / 2), Question.Height);
                Next.Enabled = true;
            }
            else
            {
                MessageBox.Show("This is the first question");
                Back.Enabled = false;
            }

        }
        private void Submit_Click(object sender, EventArgs e)
        {
            if (Answer.Text.Equals(QandA[1]))
            {
                MessageBox.Show("Correct");
                Next.Enabled = true;
            }
            else
            {
                MessageBox.Show("Wrong");
            }
        }
    }
}
