using Auth.GG_Winform_Example;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenshinImpactAccountManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RegisterButtonLoginPage_Click(object sender, EventArgs e)
        {
            Form2 NewWindow = new Form2();
            NewWindow.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (API.Login(LoginUsernameTextBox.Text, LoginPasswordTextBox.Text))
            {
                //Put code here of what you want to do after successful login
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainWindow main = new MainWindow();
                main.Show();
                this.Hide();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
