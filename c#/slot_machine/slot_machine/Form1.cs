using slot_machine.Properties;
using System.Diagnostics;
using Timer = System.Windows.Forms.Timer;

namespace slot_machine
{
    public partial class mainForm : Form
    {
        SlotMachine slotMachine;
        Stopwatch stopwatch = new Stopwatch();
        public mainForm(SlotMachine slotMachine)
        {
            InitializeComponent();
            this.slotMachine = slotMachine;
            //slot3.Image = Resources.cherry;
            //slot2.Image = Resources.q;
           // slot1.Image = Resources.plum;
        }

        private void spinButton_Click(object sender, EventArgs e)
        {
            int betAmmount;
            if (int.TryParse(bet.Text, out betAmmount))
            {
                timerText1.Visible = true;
                timer.Start();
                stopwatch.Start();
            }
            else
            {
                MessageBox.Show("Please enter a valid ammount to bet");
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (stopwatch.ElapsedMilliseconds > 3000)
            {
                timer.Stop();
                stopwatch.Stop();
                stopwatch.Reset();
                timerText1.Visible = false;
                timerText1.Text = "3";
                spinButton.Enabled = true;
                slotMachine.Spin();
            }
            else
            {
                spinButton.Enabled = false;
                timerText1.Text = Convert.ToString((3000 - stopwatch.ElapsedMilliseconds)/1000);
            }
        }

        private void mainForm_Activated(object sender, EventArgs e)
        {
            slotMachine.CreateSlots();
            slotMachine.AssignSlots();
        }
    }
}