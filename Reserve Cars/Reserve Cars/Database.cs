using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql;
using System.Data;

namespace Reserve_Cars
{
    class Database
    {
        

        internal static List<CarModel> GetCars()
        {
            List<CarModel> carModels = new List<CarModel>();
            using (MySqlConnection mySqlConnection = new MySqlConnection(@"host=db4free.net;user=schoolproject;password=carsharing;database=carsharing4;port=3307"))
            {
                try
                {
                    mySqlConnection.Open();
                    using (MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM Car", mySqlConnection))
                    {
                        DataTable dataTable = new DataTable();
                        mySqlDataAdapter.Fill(dataTable);
                        foreach (DataRow row in dataTable.Rows)
                        {
                            carModels.Add(new CarModel()
                            {
                                Id = Convert.ToInt32(row.ItemArray[0]),
                                Brand = row.ItemArray[1].ToString(),
                                Model = row.ItemArray[2].ToString(),
                                PS = Convert.ToInt32(row.ItemArray[3]),
                                Seats = Convert.ToInt32(row.ItemArray[4]),
                                Maxspeed = Convert.ToInt32(row.ItemArray[5]),
                                Price = Convert.ToInt32(row.ItemArray[6]),
                                Gearbox = row.ItemArray[7].ToString(),
                                Fuel = row.ItemArray[8].ToString(),
                                Colour = row.ItemArray[9].ToString(),
                                Date = Convert.ToDateTime(row.ItemArray[12]),
                                Status = row.ItemArray[11].ToString(),
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    return carModels;
                }
                finally
                {
                    mySqlConnection.Close();
                }
            }
            return carModels;

        }
        internal static void SetReserved(int ID)
        {
            using (MySqlConnection mySqlConnection = new MySqlConnection(@"host=db4free.net;user=schoolproject;password=carsharing;database=carsharing4;port=3307"))
            {
                try
                {
                    mySqlConnection.Open();

                    using (MySqlCommand mySqlCommand = new MySqlCommand("UPDATE Car SET Reserved = @reserved Where ID = @id", mySqlConnection))
                    {
                        mySqlCommand.Parameters.AddWithValue("reserved", DateTime.Now.AddMinutes(20).ToString("yyyy.MM.dd HH:mm:ss"));
                        mySqlCommand.Parameters.AddWithValue("id", ID);
                        mySqlCommand.Prepare();
                        mySqlCommand.ExecuteScalar();
                    }
                }
                catch (Exception)
                {
                    return;
                }
                finally
                {
                    mySqlConnection.Close();
                }
            }
            return;

        }
        internal static void SetStatus(int ID, string status)
        {
            using (MySqlConnection mySqlConnection = new MySqlConnection(@"host=db4free.net;user=schoolproject;password=carsharing;database=carsharing4;port=3307"))
            {
                try
                {
                    mySqlConnection.Open();

                    using (MySqlCommand mySqlCommand = new MySqlCommand("UPDATE Car SET Status = @status Where ID = @id", mySqlConnection))
                    {
                        mySqlCommand.Parameters.AddWithValue("status", status);
                        mySqlCommand.Parameters.AddWithValue("id", ID);
                        mySqlCommand.Prepare();
                        mySqlCommand.ExecuteScalar();
                    }
                }
                catch (Exception)
                {
                    return;
                }
                finally
                {
                    mySqlConnection.Close();
                }
            }
            return;

        }
    }
}
        
