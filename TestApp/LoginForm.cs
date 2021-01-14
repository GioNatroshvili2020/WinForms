using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            SignIn();
        }

        
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SignIn();

            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                Reset();
            }
        }

        public void Reset()
        {
            userName.Text = "";
            password.Text = "";
        }
        public void SignIn()
        {
            string name = userName.Text;
            string pass = password.Text;

            if (name == "bob" && pass == "vagene")
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Password or Email Incorrecto");
            }
        }

    }
}
