using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql;
using MetroFramework.Forms;
using System.Data;
using System.Security.Cryptography;

namespace CarSharer
{
    public static class DbController
    {
        // set connection string to my local sql server database
        // can be retrieved from the database connection properties in the Server-Explorer
        public static void Connecttodsa()
        {
            string connectionString = @"host=localhost;user=root;database=test";
            // create SqlConnection object
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    // open connection to database
                    con.Open();
                    // INTERACTION WITH DATABASE COMES HERE
                }
                catch(Exception e)
                {
                    throw e;
                }
                finally
                {
                    // close connection to database
                    con.Close();
                }
            }
        }
        public static bool ValidatePasscode(string username, string passcode)
        {
            string constr = @"Server=http://carsharingschool.bplaced.net/localhost;Database=carsharing;User Id=carsharingschool;Password=carsharing;";

            using (MySqlConnection con = new MySqlConnection(constr))
            {
                try
                {
                    // open connection to database
                    con.Open();
                    // INTERACTION WITH DATABASE COMES HERE
                    string SqlString = "Select * From Contacts Where FirstName = @FirstName";

                    using (MySqlCommand cmd = new MySqlCommand(SqlString, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("FirstName", username);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.ToString() == /*sha256_hash(passcode)*/ "1234")
                            {
                                con.Close();
                                return true;
                            }
                        }
                    }

                }
                catch(Exception e)
                {
                    throw e;
                }
                finally
                {
                    // close connection to database
                    con.Close();
                }
            }
            return false;
        }
        /// <summary>
        /// Method that hashes a string with sha256.
        /// </summary>
        /// <param name="value">String to hash.</param>
        /// <returns>Returns a hashed string.</returns>
        public static String sha256_hash(string value)
        {
            StringBuilder Sb = new StringBuilder();

            using (var hash = SHA256.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }
    }
}
