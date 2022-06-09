using slot_machine.Properties;
using System.Diagnostics;
using Timer = System.Windows.Forms.Timer;

namespace slot_machine
{
    public partial class mainForm : Form
    {
        SlotMachine slotMachine;
        Stopwatch stopwatch = new();
        int betAmmount;
        public mainForm(SlotMachine slotMachine)
        {
            InitializeComponent();
            this.slotMachine = slotMachine;
        }

        private void SpinButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(bet.Text, out betAmmount))
            {
                bet.Enabled = false;
                spinButton.Enabled = false;
                timerText1.Visible = true;
                timer.Start();
                stopwatch.Start();
            }
            else
            {
                MessageBox.Show("Please enter a valid ammount to bet");
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (stopwatch.ElapsedMilliseconds > 3000)
            {
                timer.Stop();
                stopwatch.Stop();
                stopwatch.Reset();
                timerText1.Visible = false;
                timerText1.Text = "3";
                spinButton.Enabled = true;
                bet.Enabled = true;
                slotMachine.Spin(betAmmount);
            }
            else
            {
                timerText1.Text = Convert.ToString((3000 - stopwatch.ElapsedMilliseconds)/1000);
            }
        }

        private void mainForm_Shown(object sender, EventArgs e)
        {
            slotMachine.CreateSlots();
            slotMachine.AssignSlots();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            settingsForm settings = new settingsForm(slotMachine.User);
            settings.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            slotMachine.User.updateMoneyGiven();
            slotMachine.User.updateWinnings();
            Application.Exit();
        }

        private void scoreButton_Click(object sender, EventArgs e)
        {
            int moneyWon = slotMachine.User.GetMoneyWon();
            int moneyGiven = slotMachine.User.GetMoneyGiven();
            int currentWinnnings = slotMachine.User.CurrentWinnings();
            int currentMoneyGiven = slotMachine.User.CurrentMoneyGiven();
            MessageBox.Show(String.Format
                ("Money won in current session : {0}\r\n" +
                "Money given in current session : {1}\r\n" +
                "Money won (all time) : {2}\r\n" +
                "Money given (all time) : {3}",
                currentWinnnings, currentMoneyGiven, moneyWon, moneyGiven));
        }
    }
}