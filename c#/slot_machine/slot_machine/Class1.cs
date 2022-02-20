using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slot_machine
{
    public class User
    {
        private string username;
        private int currentWinnings = 0;
        private int currentLoses = 0;

        public User(string username)
        {
            //if (!checkUsername())
            //{
            //    this.username = username;
            //}
        }

        private bool checkUsername()
        {
            throw new NotImplementedException();
        }

        public void updateLoses(int loses)
        {
            throw new NotImplementedException();
        }

        public void updateWinnings(int winnings)
        {
            throw new NotImplementedException();
        }

        public void updateCurrentLoses(int currentLoses)
        {
            this.currentLoses += currentLoses;
        }

        public void updateCurrentWinnings(int currentWinnings)
        {
            this.currentWinnings += currentWinnings;
        }
    }
}
