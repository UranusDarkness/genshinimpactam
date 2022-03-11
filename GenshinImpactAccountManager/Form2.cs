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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 loginRegister = new Form1();
            this.Hide();
            loginRegister.Show();
        }

        private void RegisterButtonLoginPage_Click(object sender, EventArgs e)
        {
            if (API.Register(RegisterUsernameTextBox.Text, RegisterPasswordTextBox.Text, RegisterEmailTextBox.Text, RegisterSerialKeyTextBox.Text))
            {
                //Put code here of what you want to do after successful login
                MessageBox.Show("Register has been successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
