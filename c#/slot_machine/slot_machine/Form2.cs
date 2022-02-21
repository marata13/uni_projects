using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slot_machine
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (loginInput.Text.Length > 0)
            {
                loginInput.Enabled = false;
                mainForm main = new mainForm(new SlotMachine(new User(loginInput.Text), 3, 4));
                this.Hide();
                main.Show();
            }
            else
            {
                MessageBox.Show("Please input a username");
            }
        }
    }
}
