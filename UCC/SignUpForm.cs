﻿using System;
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
    public partial class SignUpForm : Form
    {
        public string imagePath = "../../../Resources/Images/", filePath = "../../../Resources/Files/", videoPath = "../../../Resources/Videos/", iconPath = "../../../Resources/Icons/";
        FileStream criminalDataStream, criminalIndexStream, indexFile;
        StreamWriter criminalStreamWriter, criminalIndexWriter, indexFileWriter;
        StreamReader criminalIndexStreamReader, criminalStreamReader, indexFileReader;
        string filename = "Criminal_Data_File.txt", indexfilename = "Criminal_Index_File.txt", path;
        int IDCounter = 0;
        public SignUpForm()
        {
            InitializeComponent();
            BackgroundImage = Image.FromFile(imagePath + "signBG.png");

        }
        private void register_Click(object sender, EventArgs e)
        {
            criminalDataStream = new FileStream(filename, FileMode.Append, FileAccess.Write);
            criminalStreamWriter = new StreamWriter(criminalDataStream);
            criminalStreamWriter.WriteLine(criminalIDBox.Text + "," + passwordBox.Text + "," + nickNameBox.Text + "," + crimeBox.Text + "," + yearsBox.Text + "," + ageBox.Text + "," + gender(femaleBox.Checked, maleBox.Checked) + "," + path);
            criminalIndexStream = new FileStream(indexfilename, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            criminalIndexWriter = new StreamWriter(criminalIndexStream);
            criminalIndexWriter.WriteLine(criminalIDBox.Text + "," + passwordBox.Text);
            criminalIndexWriter.Close();
            criminalIndexStream.Close();
            criminalStreamWriter.Close();
            criminalDataStream.Close();
            indexing();
        }
        void indexing()
        {
            indexFile = new FileStream("IndexFile.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            indexFileWriter = new StreamWriter(indexFile);
            criminalDataStream = new FileStream(filename, FileMode.Open, FileAccess.Read);
            criminalStreamReader = new StreamReader(criminalDataStream);
            string[] lines = File.ReadAllLines(filename);
            int index = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                string[] fields = lines[i].Split(",");
                indexFileWriter.WriteLine(fields[0] + "," + (index).ToString());
                index += lines[i].Length + 2;
            }
            indexFileWriter.Close();
            indexFile.Close();
            criminalDataStream.Close();
            criminalStreamReader.Close();
        }
        private void criminalPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            path = openFileDialog.FileName;
            criminalPhoto.Image=Image.FromFile(path);
        }
        string gender(bool xy,bool xx)
        {
            if (xx)
            {
                return "Female";
            }
            else if(xy)
            {
                return "Male";
            }
            return "Not specified";
        }
    }
}
