namespace UCC
{
    public partial class DashBoard : Form
    {
        public string imagePath = "../../../Resources/Images/", filePath = "../../../Resources/Files/", videoPath = "../../../Resources/Videos/", iconPath = "../../../Resources/Icons/";

        public DashBoard()
        {
            InitializeComponent();
            BackgroundImage = Image.FromFile(imagePath + "mainBG.png");
        }

        private void mathsChallenge_Click(object sender, EventArgs e)
        {

        }
    }
}
