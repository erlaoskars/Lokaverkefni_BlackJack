using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Lokaverkefni_BlackJack
{
    class Gagnagrunnur
    {
        private string server;
        private string database;
        private string uid;
        private string password;
        string tengistrengur = null;
        string fyrirspurn = null;

        MySqlConnection sqltenging;
        MySqlCommand mySQLskipun;
        MySqlDataReader sqllesari;

        public void TengingVidGagnagrunn()
        {
            server = "10.200.10.24";
            database = "0901972079_lokaverkefni_blackjack";
            uid = "0901972079";
            password = "mypassword";
            tengistrengur = "server=" + server + ";userid=" + uid + ";password=" + password + ";database=" + database;
            sqltenging = new MySqlConnection(tengistrengur);
        }

        private bool OpenConnection()
        {
            try
            {
                sqltenging.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                sqltenging.Close();
                return true;
            }
            catch (MySqlException ex)
            {

                throw ex;
            }
        }

        public void SettInnSqlToflu(string nafn, string lykilord)
        {
            if (OpenConnection() == true)
            {
                fyrirspurn = "INSERT INTO notendur (username, password, money) VALUES ('" + nafn + "','" + lykilord + "','" + 0 + "')";
                mySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                mySQLskipun.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public string FinnaLykilord(string nafn)
        {
            string passw = null;
            if (OpenConnection() == true)
            {
                fyrirspurn = "SELECT password FROM notendur WHERE username = '" + nafn + "';";
                mySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqllesari = mySQLskipun.ExecuteReader();
                while (sqllesari.Read())
                {
                    for (int i = 0; i < sqllesari.FieldCount; i++)
                    {
                        passw += (sqllesari.GetValue(i).ToString());
                    }
                }

                CloseConnection();
                return passw;
            }
            return passw;
        }

        public void SettInnMoney(string nafn, int money)
        {
            if (OpenConnection() == true)
            {
                fyrirspurn = "UPDATE notendur SET money = '" + money + "' WHERE username = '" + nafn + "';";
                mySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                mySQLskipun.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public string FinnaMoney(string nafn)
        {
            string money = null;
            if (OpenConnection() == true)
            {
                fyrirspurn = "SELECT money FROM notendur WHERE username = '" + nafn + "';";
                mySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqllesari = mySQLskipun.ExecuteReader();
                while (sqllesari.Read())
                {
                    for (int i = 0; i < sqllesari.FieldCount; i++)
                    {
                        money += (sqllesari.GetValue(i).ToString());
                    }
                }

                CloseConnection();
                return money;
            }
            return money;
        }

        public void ByrjaAftur(string nafn)
        {
            if (OpenConnection() == true)
            {
                fyrirspurn = "UPDATE notendur SET money = '" + 500 + "' WHERE username = '" + nafn + "';";
                mySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                mySQLskipun.ExecuteNonQuery();
                CloseConnection();
            }
        }

    }
}
