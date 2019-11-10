using System;
using System.Collections;
using System.Data.SqlClient;
using COID_System.Entity;

namespace COID_System.dao
{
    class DaoFood
    {
        //public static ArrayList GetAllFood()
        //{
        //    var dbConnect = new DbConnect();
        //    var conn = dbConnect.CreateConnection();
        //    var temp = new ArrayList();
        //    using (conn)
        //    {


        //        string query = "SELECT * FROM Food";

        //        SqlCommand command = new SqlCommand(query, conn);

        //        conn.Open();
        //        using (SqlDataReader reader = command.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                string id = (string)reader["id"];
        //                string name = String.Format("{0}", reader["name"]);
        //                int categoryId = (int)reader["categoryId"];
        //                string description = String.Format("{0}", reader["description"]);
        //                double price = (double)reader["price"];


        //                temp.Add(new Food(id, name, description, price, categoryId));
        //            }
        //        }
        //        conn.Close();
        //    }

        //    return temp;
        //}

        //public static void InsertFood(string name, string description, double price, int categoryId)
        //{
        //    var dbConnect = new DbConnect();
        //    var conn = dbConnect.CreateConnection();
        //    using (conn)
        //    {


        //        string query = "INSERT INTO food (name,description,price,categoryId) VALUES (@name,@description,@price,@categoryId)";

        //        using (SqlCommand command = new SqlCommand(query, conn))
        //        {

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

        //public static void EditFood(int id, string name, string description, int categoryId, double price)
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

        //public static string GetIdFood(string name)
        //{
        //    string id = "";
        //    var dbConnect = new DbConnect();
        //    var conn = dbConnect.CreateConnection();
        //    using (conn)
        //    {


        //        string query = "SELECT id FROM food where name = @name";

        //        SqlCommand command = new SqlCommand(query, conn);
        //        command.Parameters.AddWithValue("@name", name);
        //        conn.Open();
        //        using (SqlDataReader reader = command.ExecuteReader())
        //        {
        //            if (reader.Read())
        //            {
        //                id = (string)reader["id"];


        //            }
        //        }
        //        conn.Close();
        //    }

        //    return id;

        //}

        //public static void DeleteFood(int id)
        //{
        //    var dbConnect = new DbConnect();
        //    var conn = dbConnect.CreateConnection();
        //    using (conn)
        //    {


        //        string query = "DELETE FROM food where id=@id";

        //        using (SqlCommand command = new SqlCommand(query, conn))
        //        {
        //            command.Parameters.AddWithValue("@id", id);



        //            conn.Open();
        //            var result = command.ExecuteNonQuery();

        //            // Check Error
        //            if (result < 0)
        //                Console.WriteLine("Error inserting data into Database!");
        //        }
        //    }
        //    conn.Close();
        //}
    }
}
