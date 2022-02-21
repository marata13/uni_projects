using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace slot_machine
{
    public class User
    {
        public string username { get; }
        private int currentWinnings = 0;
        private int currentMoneyGiven = 0;
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;" +
                 "Database=slot_machine;User Id=postgres;Password=manolhs13;");//TODO hide password

        public User(string username)
        {
            if (!checkUsername(username))
            {
                ExecuteQuery(String.Format("insert into users values('{0}',0,0)",username));
            }
                this.username = username;
        }

        private NpgsqlDataReader ExecuteQuery(string query)
        {
            conn.Open();
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = query;
            NpgsqlDataReader reader = cmd.ExecuteReader();
            reader.Close();
            conn.Close();
            return reader;
        }

        private bool checkUsername(string username)
        {
            int n=0;
            NpgsqlDataReader query = ExecuteQuery(String.Format
                ("select count(*) from users where username = '{0}'", username));
            while (query.Read())
            {
                n = (int)query.GetInt64(0);
            }
            if(n > 0)
            {
                return true;
            }
            return false;
        }

        public void updateLoses(int loses)
        {
            ExecuteQuery(String.Format
                ("update users set money_given = money_given + {0} where username='{1}'",
                currentMoneyGiven,username));
            currentMoneyGiven = 0;
        }

        public void updateWinnings(int winnings)
        {
            ExecuteQuery(String.Format
                ("update users set money_won = money_won + {0} where username='{1}'",
                currentWinnings, username));
            currentWinnings= 0;
        }

        public void updateCurrentMoneyGiven(int currentMoneyGiven)
        {
            this.currentMoneyGiven += currentMoneyGiven;
        }

        public void updateCurrentWinnings(int currentWinnings)
        {
            this.currentWinnings += currentWinnings;
        }
    }
}
