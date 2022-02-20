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

        internal void Spin()
        {
            AssignSlots();
            if (CheckWin()){
                MessageBox.Show("Win");
            }
        }

        private bool CheckWin()
        {
            for (int i = 0; i < slotsList.Count-1; i++)
            {
                if(slotsList[i].Tag == slotsList[i+1].Tag)
                {
                    continue;
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
