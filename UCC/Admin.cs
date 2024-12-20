using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectX
{
    public partial class Admin : Form
    {
        FileStream indexFile;
        StreamReader indexFileReader;
        public string imagePath = "../../../Resources/Images/",filePath= "../../../Resources/Files/",videoPath= "../../../Resources/Videos/",iconPath= "../../../Resources/Icons/";
        public Admin()
        {
            InitializeComponent();
            BackgroundImage = Image.FromFile(imagePath+"mainBG.png");
            profilePicture.Image = Image.FromFile(imagePath + "profilePicture.png");
        }

        private void insert_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Location= Location;
            signUpForm.Show();
            Hide();
            Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            indexFile = new FileStream("IndexFile.txt", FileMode.Open, FileAccess.Read);
            indexFileReader = new StreamReader(indexFile);
        }

        private void squeeze_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            input.Text = string.Empty;
        }
    }
}
