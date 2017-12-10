using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql;
using MetroFramework.Forms;
using System.Data;
using System.Windows.Forms;
using MetroFramework;

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
        public static void InsertAccount(string username, string name, DateTime dateofbirth, string passcode, string email, CreateAccountForm currentForm)
        {
            using (MySqlConnection con = new MySqlConnection(@"host=mysql8.db4free.net;user=schoolproject;password=carsharing;database=carsharing4;port=3307"))
            {
                try
                {
                    // open connection to database STR_TO_DATE('12/31/2011', '%m/%d/%Y')
                    string sadas = dateofbirth.ToString("yyyy-dd-MM HH:mm:ss");

                    con.Open();
                    // INTERACTION WITH DATABASE
                    using (MySqlCommand cmd = new MySqlCommand("INSERT INTO `Person` (`Username`, `Name`, `DateOfBirth`, `Passcode`, `email`, `is_Admin`) VALUES ('@username', '@name', '@date', '@passcode', '@email', '0')", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.Add("@date", dateofbirth.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@passcode", passcode);
                        cmd.Parameters.AddWithValue("@email", email);

                        cmd.ExecuteNonQuery();
                    }

                }
                catch (Exception e)
                {
                    MetroMessageBox.Show(currentForm, "An error occured.");
                    throw e;
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