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
    // https://mysql8.db4free.net/
    public static class DbController
    {
        /// <summary>
        /// Selects and validates passcode form an online database.
        /// </summary>
        /// <param name="username">Username the query has to check.</param>
        /// <param name="passcode">Passcode the query has to check.</param>
        /// <returns>Returns a bool for valid or invalid.</returns>
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
                                if (reader.GetString(0) == Cryptography.sha256_hash(passcode))
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

        /// <summary>
        /// Inserts an new user into an online database.
        /// </summary>
        /// <param name="username">The username the query has to insert.</param>
        /// <param name="name">The name the query has to insert.</param>
        /// <param name="dateofbirth">The date of birth the query has to insert.</param>
        /// <param name="passcode">The passcode the query has to insert hashed.</param>
        /// <param name="email">The email the query has to insert.</param>
        /// <param name="currentForm">The current Form to to open show an error code, if one occures.</param>
        public static void InsertAccount(string username, string name, DateTime dateofbirth, string passcode, string email, CreateAccountForm currentForm)
        {
            using (MySqlConnection con = new MySqlConnection(@"host=mysql8.db4free.net;user=schoolproject;password=carsharing;database=carsharing4;port=3307"))
            {
                try
                {
                    // open connection to database 

                    con.Open();
                    // INTERACTION WITH DATABASE
                    using (MySqlCommand cmd = new MySqlCommand("INSERT INTO `Person` (`Username`, `Name`, `DateOfBirth`, `Passcode`, `email`, `is_Admin`) VALUES (@username, @name, @date, @passcode, @email, '1')", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@date", dateofbirth);
                        cmd.Parameters.AddWithValue("@passcode", Cryptography.sha256_hash(passcode));
                        cmd.Parameters.AddWithValue("@email", email);

                        cmd.ExecuteNonQuery();
                    }

                }
                catch (Exception)
                {
                    MetroMessageBox.Show(currentForm, "An error occured.");
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