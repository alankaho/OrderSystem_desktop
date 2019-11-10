using System;
using COID_System.Entity;
using System.Data.SqlClient;

namespace COID_System.dao
{
    class DaoCombo
    {
        //public static void Insert(string name, string description, double price, double discount)
        //{
        //    var dbConnect = new DbConnect();
        //    var conn = dbConnect.CreateConnection();
        //    using (conn)
        //    {


        //        string query = "INSERT INTO combo (name,description,price,discount_price) VALUES (@name,@description,@price,@discount_prize)";

        //        using (SqlCommand command = new SqlCommand(query, conn))
        //        {

        //            command.Parameters.AddWithValue("@name", name);
        //            command.Parameters.AddWithValue("@description", description);
        //            command.Parameters.AddWithValue("@price", price);
        //            command.Parameters.AddWithValue("@discount_prize", discount);

        //            conn.Open();
        //            var result = command.ExecuteNonQuery();

        //            // Check Error
        //            if (result < 0)
        //                Console.WriteLine("Error inserting data into Database!");
        //        }
        //    }
        //    conn.Close();
        //}

        //public static void Insert(string id, string name, string description, double price, double discount)
        //{
        //    var dbConnect = new DbConnect();
        //    var conn = dbConnect.CreateConnection();
        //    using (conn)
        //    {


        //        string query = "INSERT INTO combo (id,name,description,price,discount_price) VALUES (@id,@name,@description,@price,@discount_prize)";

        //        using (SqlCommand command = new SqlCommand(query, conn))
        //        {
        //            command.Parameters.AddWithValue("@id", id);
        //            command.Parameters.AddWithValue("@name", name);
        //            command.Parameters.AddWithValue("@description", description);
        //            command.Parameters.AddWithValue("@price", price);
        //            command.Parameters.AddWithValue("@discount_prize", discount);

        //            conn.Open();
        //            var result = command.ExecuteNonQuery();

        //            // Check Error
        //            if (result < 0)
        //                Console.WriteLine("Error inserting data into Database!");
        //        }
        //    }
        //    conn.Close();
        //}

        //public static void EditCombo(int id, string name, string description, int categoryId, double price, double discount)
        //{
        //    var dbConnect = new DbConnect();
        //    var conn = dbConnect.CreateConnection();
        //    using (conn)
        //    {


        //        string query = "update category set name = @name ,description = @description ,categoryId = @categoryId where id = @id";

        //        using (SqlCommand command = new SqlCommand(query, conn))
        //        {
        //            command.Parameters.AddWithValue("@id", id);
        //            command.Parameters.AddWithValue("@name", name);
        //            command.Parameters.AddWithValue("@description", description);
        //            command.Parameters.AddWithValue("@price", price);
        //            command.Parameters.AddWithValue("@categoryId", categoryId);

        //            conn.Open();
        //            var result = command.ExecuteNonQuery();

        //            // Check Error
        //            if (result < 0)
        //                Console.WriteLine("Error inserting data into Database!");
        //        }
        //    }
        //    conn.Close();
        //}

        //public static Combo GetCombo(string id)
        //{
        //    var dbConnect = new DbConnect();
        //    var conn = dbConnect.CreateConnection();
        //    Combo temp = null;
        //    using (conn)
        //    {


        //        string query = "SELECT * FROM Combo where id = @id";

        //        using (SqlCommand command = new SqlCommand(query, conn))
        //        {
        //            command.Parameters.AddWithValue("@id", id);


        //            conn.Open();
        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                if (reader.Read())
        //                {

        //                    string name = String.Format("{0}", reader["name"]);
        //                    double discountPrice = (double)reader["discount_price"];
        //                    string description = String.Format("{0}", reader["description"]);
        //                    double price = (double)reader["price"];


        //                    temp = new Combo(id, name, description, price, discountPrice);
        //                }
        //            }


        //        }



        //        conn.Close();
        //    }

        //    return temp;
        //}
    }
}
