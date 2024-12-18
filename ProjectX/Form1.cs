using System.Windows.Forms.Design;
using System.IO;
namespace ProjectX
{
    public partial class SignPage : Form
    {
        string fileName = "SignInData.txt";
        FileStream signInFile;
        StreamReader signInReader;
        public SignPage()
        {
            InitializeComponent();
        }

        private void SignPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            signInFile = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read);
            signInReader = new StreamReader(signInFile);
            bool correct = true;
            string[] signInData =signInReader.ReadToEnd().Split("\n");
            for (int i = 0; i < signInData.Length; i++)
            {
                string[] record = signInData[i].Split(",");
                string criminalId = record[0];
                string passWord = record[1].Trim();
                if (criminalIDBox.Text == "admin")
                {
                    if (passWordBox.Text == "admin")
                    {

                    }
                }
                else
                {
                    if (criminalId == criminalIDBox.Text)
                    {
                        if (passWord == passWordBox.Text)
                        {
                            //Play the game

                            SignInPassed signInPassed = new SignInPassed();
                            signInPassed.Location = this.Location;
                            signInPassed.Show();
                            signInPassed.Activate();
                            this.Hide();
                            return;
                        }
                    }
                    if (i == signInData.Length - 1)
                    {
                        correct = false;
                    }
                }
                

            }
            if (!correct)
            {
                MessageBox.Show("Wrong");
            }



        }
    }
}
