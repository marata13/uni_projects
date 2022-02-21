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
                 "Database=slot_machine;User Id=postgres;Password=;");

        public User(string username)
        {
            conn.Open();
            if (!checkUsername(username))
            {
                conn.Open();
                ExecuteQuery(String.Format("insert into users values('{0}',0,0)",username));
                conn.Close();
            }
                this.username = username;
        }

        private NpgsqlDataReader ExecuteQuery(string query)
        {
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = query;
            NpgsqlDataReader reader = cmd.ExecuteReader();
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
                query.Close();
                conn.Close();
                return true;
            }
            query.Close();
            conn.Close();
            return false;
        }

        public int CurrentWinnings()
        {
            return currentWinnings;
        }

        public int CurrentMoneyGiven()
        {
            return currentMoneyGiven;
        }

        public void updateMoneyGiven()
        {
            conn.Open();
            ExecuteQuery(String.Format
                ("update users set money_given = money_given + {0} where username='{1}'",
                currentMoneyGiven,username));
            currentMoneyGiven = 0;
            conn.Close();
        }

        public void updateWinnings()
        {
            conn.Open();
            ExecuteQuery(String.Format
                ("update users set money_won = money_won + {0} where username='{1}'",
                currentWinnings, username));
            currentWinnings= 0;
            conn.Close();
        }

        public void updateCurrentMoneyGiven(int currentMoneyGiven)
        {
            this.currentMoneyGiven += currentMoneyGiven;
        }

        public void updateCurrentWinnings(int currentWinnings)
        {
            this.currentWinnings += currentWinnings;
        }

        public int GetMoneyGiven()
        {
            conn.Open();
            int moneyGiven = 0;
            NpgsqlDataReader query = ExecuteQuery(String.Format
                            ("select money_given from users where username='{0}'",username));
            while (query.Read())
            {
                moneyGiven = (int)query.GetInt64(0);
            }
            conn.Close();
            return moneyGiven+currentMoneyGiven;
        }

        public int GetMoneyWon()
        {
            conn.Open();
            int moneyWon = 0;
            NpgsqlDataReader query = ExecuteQuery(String.Format
                            ("select money_won from users where username='{0}'", username));
            while (query.Read())
            {
                moneyWon = (int)query.GetInt64(0);
            }
            conn.Close();
            return moneyWon + currentWinnings;
        }
    }
}
