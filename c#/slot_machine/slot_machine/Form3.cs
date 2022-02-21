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
    public partial class settingsForm : Form
    {
        User User;
        List<int> columnNumbers =new List<int>{ 3, 4, 5, 6, 7, 8 };
        List<int> fruitNumbers = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        public settingsForm(User user)
        {
            this.User = user;
            InitializeComponent();
            columnBox.DataSource = columnNumbers;
            fruitBox.DataSource = fruitNumbers;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm mainForm = new(new SlotMachine(User, (int)columnBox.SelectedItem,
                                        (int)fruitBox.SelectedItem));

            mainForm.Show();
            Close();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            User.updateWinnings();
            User.updateMoneyGiven();
            loginForm login = new loginForm();
            login.Show();
            Close();
        }
    }

}
