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
    public partial class SignUpForm : Form
    {
        FileStream criminalDataStream, criminalIndexStream;
        StreamWriter criminalStreamWriter, criminalIndexWriter;
        StreamReader criminalIndexStreamReader;
        int IDCounter = 0;
        string filename = "Criminal_Data_File.txt", indexfilename = "Criminal_Index_File.txt";
        public SignUpForm()
        {
            InitializeComponent();

        }

        private void signUpForm_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            criminalDataStream = new FileStream(filename, FileMode.Append, FileAccess.Write);
            criminalStreamWriter = new StreamWriter(criminalDataStream);
            criminalStreamWriter.Write(criminalIDBox.Text + "," + passwordBox.Text + "," + nickNameBox.Text + "," + crimeBox.Text + "," + yearsBox.Text + "," + ageBox.Text + "," + path);
            if (maleBox.Checked)
            {
                criminalStreamWriter.Write(",male");
            }
            if (femaleBox.Checked)
            {
                criminalStreamWriter.Write(",female");
            }
            criminalIndexStream = new FileStream(indexfilename, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            criminalIndexWriter = new StreamWriter(criminalIndexStream);
            criminalIndexWriter.WriteLine(criminalIDBox.Text + "," + passwordBox.Text);
            criminalIndexWriter.Close();
            criminalIndexStream.Close();
            criminalStreamWriter.Close();
            criminalDataStream.Close();
        }
        private void userNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        string path;
        private void criminalBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            path = openFileDialog.FileName; 
        }
        private void criminalBox_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
