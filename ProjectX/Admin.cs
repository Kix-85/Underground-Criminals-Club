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
        public Admin()
        {
            InitializeComponent();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {

        }

        private void squeeze_Click(object sender, EventArgs e)
        {

        }
    }
}
