using slot_machine.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slot_machine
{
    public class SlotMachine
    {

        private readonly int ENDOFSCREEN = 862;
        List<PictureBox> slotsList = new();
        List<Image> slotImages =new() { Resources.cherry,Resources.jay,Resources.plum,Resources.q,
                                        Resources.wild,Resources.watermellon,Resources.lemon,
                                        Resources.seven,Resources.strawberry,Resources.bell};

        public SlotMachine(User user,int slotsNumber, int fruits)
        {
            User = user;
            SlotsNumber = slotsNumber;
            Fruits = fruits;
        }

        internal void CreateSlots()
        {
            for (int i = 0; i < slotsList.Count; i++)
            {
                mainForm.ActiveForm.Controls.Remove(slotsList[i]);
            }
            slotsList.Clear();
            for (int i = 1; i <= SlotsNumber; i++)
            {
                PictureBox pictureBox = new();
                pictureBox.Name = "slot" + i;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Size = new Size(150 - (SlotsNumber-3) * 15, 207);
                pictureBox.Location = new Point(i*(ENDOFSCREEN/(SlotsNumber+1)),143);
                mainForm.ActiveForm.Controls.Add(pictureBox);
                slotsList.Add(pictureBox);
            }
        }

        public User User { get; }

        internal void Spin(int betAmmount)
        {
            User.updateCurrentMoneyGiven(betAmmount);
            AssignSlots();
            if (CheckWin()){
                int ammountWon = PayTable(betAmmount);
                User.updateCurrentWinnings(ammountWon);
                MessageBox.Show(String.Format("Congratulations {0} you won ${1}!!!! ",
                                                            User.username,ammountWon));
            }
        }

        private int PayTable(int betAmmount)
        {
            int currentFruit = (int)Convert.ToInt64(slotsList[0].Tag);
            switch (currentFruit)
            {
                case 0:
                    return betAmmount;
                case 1:
                    return 2*betAmmount;
                case 2:
                    return 4*betAmmount;
                case 3:
                    return 6*betAmmount;
                case 4:
                    return 8*betAmmount;
                case 5:
                    return 10*betAmmount;
                case 6:
                    return 12*betAmmount;
                case 7:
                    return 15*betAmmount;
                case 8:
                    return 18 * betAmmount;
                case 9:
                    return 25*betAmmount;
            }
            return 0;
        }

        private bool CheckWin()
        {
            for (int i = 0; i < slotsList.Count-1; i++)
            {
                if(Convert.ToInt64(slotsList[i].Tag) == Convert.ToInt64(slotsList[i+1].Tag))
                {
                    //do nothing
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public int SlotsNumber { get; }
        public int Fruits { get; }


        internal void AssignSlots()
        {
            Random rnd = new Random();
            List<Image> temp = new();
            for (int i = 0; i < Fruits; i++)
            {
                temp.Add(slotImages[i]);
            }
            for (int i = 0; i < slotsList.Count; i++)
            {
                int n = rnd.Next(temp.Count);
                slotsList[i].Image = temp[n];
                slotsList[i].Tag = n;
            }
        }
    }
}
