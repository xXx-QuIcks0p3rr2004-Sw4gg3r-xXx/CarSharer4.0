using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql;

namespace Reserve_Cars
{
    class Database
    {
        public static void GetData(string SqlCommand)
        {
            using (MySqlConnection con = new MySqlConnection(@"host=mysql8.db4free.net;user=schoolproject;password=carsharing;database=carsharing4;port=3307"))
            {
                try
                {
                    // open connection to database
                    con.Open();
                    // INTERACTION WITH DATABASE
                    using (MySqlCommand cmd = new MySqlCommand(SqlCommand, con))
                    {

                    }

                }
                catch (Exception)
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
