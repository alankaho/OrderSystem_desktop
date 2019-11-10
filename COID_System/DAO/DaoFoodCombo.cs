using System;
using System.Data.SqlClient;
using COID_System.Entity;

namespace COID_System.dao
{
    class DaoFoodCombo
    {
        public static void InsertFoodCombo(string idFood, string idCombo)
        {
            var dbConnect = new DbConnect();
            var conn = dbConnect.CreateConnection();
            using (conn)
            {


                string query = "INSERT INTO food_combo (foodID,comboID) VALUES (@foodID,@comboID)";

                using (SqlCommand command = new SqlCommand(query, conn))
                {


                    command.Parameters.AddWithValue("@foodID", idFood);
                    command.Parameters.AddWithValue("@comboID", idCombo);


                    conn.Open();
                    var result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                        Console.WriteLine("Error inserting data into Database!");
                }
            }
            conn.Close();
        }

        public static void deleteFoodCombo(string idFood, string idCombo)
        {
            var dbConnect = new DbConnect();
            var conn = dbConnect.CreateConnection();
            using (conn)
            {


                string query = "Delete food_combo where foodID = @foodID and comboID = @comboID";

                using (SqlCommand command = new SqlCommand(query, conn))
                {


                    command.Parameters.AddWithValue("@foodID", idFood);
                    command.Parameters.AddWithValue("@comboID", idCombo);


                    conn.Open();
                    command.ExecuteNonQuery();

                    // Check Error

                }
            }
            conn.Close();
        }
    }
}
