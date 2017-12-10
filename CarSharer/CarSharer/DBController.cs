using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql;
using MetroFramework.Forms;
using System.Data;

namespace CarSharer
{
    public static class DbController
    {
        public static bool ValidatePasscode(string username, string passcode)
        {
            using (MySqlConnection con = new MySqlConnection(@"host=mysql8.db4free.net;user=schoolproject;password=carsharing;database=carsharing4;port=3307"))
            {
                try
                {
                    // open connection to database
                    con.Open();
                    // INTERACTION WITH DATABASE
                    using (MySqlCommand cmd = new MySqlCommand("Select Passcode From Person Where Username = @username;", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("username", username);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (reader.GetString(0) == /*sha256_hash(passcode)*/ "1")
                                {
                                    return true;
                                }
                                else throw new Exception();
                            }
                            else throw new Exception();
                        }
                    }

                }
                catch(Exception)
                {
                    return false;
                }
                finally
                {
                    // close connection to database
                    con.Close();
                }
            }
        }
    }
}
