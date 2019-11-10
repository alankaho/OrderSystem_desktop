using System;
using COID_System.Entity;
using System.Data.SqlClient;
using System.Collections;

namespace COID_System.dao
{
    class DaoCategory
    {
        //public static ArrayList GetCatagory() 
        //{
        //    var dbConnect = new DbConnect();
        //    var conn = dbConnect.CreateConnection();
        //    var temp = new ArrayList();
        //    using (conn)
        //    {


        //        string query = "SELECT * FROM category";

        //        SqlCommand command = new SqlCommand(query, conn);

        //        conn.Open();
        //        using (SqlDataReader reader = command.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                int id = (int)reader["id"];

        //                string name = String.Format("{0}", reader["name"]);

        //                string description = String.Format("{0}", reader["description"]);
        //                temp.Add(new Category(id, name, description));
        //            }
        //        }
        //        conn.Close();
        //    }

        //    return temp;
        //}

        //public static void InsertCategory(string name, string description)
        //{
        //    var dbConnect = new DbConnect();
        //    var conn = dbConnect.CreateConnection();
        //    using (conn)
        //    {


        //        string query = "INSERT INTO category (name,description) VALUES (@name,@description)";

        //        using (SqlCommand command = new SqlCommand(query, conn))
        //        {

        //            command.Parameters.AddWithValue("@name", name);
        //            command.Parameters.AddWithValue("@description", description);


        //            conn.Open();
        //            var result = command.ExecuteNonQuery();

        //            // Check Error
        //            if (result < 0)
        //                Console.WriteLine("Error inserting data into Database!");
        //        }
        //    }
        //    conn.Close();
        //}

        //public static void EditCategory(int id, string name, string description)
        //{
        //    var dbConnect = new DbConnect();
        //    var conn = dbConnect.CreateConnection();
        //    using (conn)
        //    {


        //        string query = "update category set name = @name ,description = @description where id = @id";

        //        using (SqlCommand command = new SqlCommand(query, conn))
        //        {
        //            command.Parameters.AddWithValue("@id", id);
        //            command.Parameters.AddWithValue("@name", name);
        //            command.Parameters.AddWithValue("@description", description);


        //            conn.Open();
        //            var result = command.ExecuteNonQuery();

        //            // Check Error
        //            if (result < 0)
        //                Console.WriteLine("Error inserting data into Database!");
        //        }
        //    }
        //    conn.Close();
        //}

        //public static int GetIdCategory(string name)
        //{
        //    int id = 999;
        //    var dbConnect = new DbConnect();
        //    var conn = dbConnect.CreateConnection();
        //    using (conn)
        //    {


        //        string query = "SELECT id FROM category where name = @name";

        //        SqlCommand command = new SqlCommand(query, conn);
        //        command.Parameters.AddWithValue("@name", name);
        //        conn.Open();
        //        using (SqlDataReader reader = command.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                id = (int)reader["id"];


        //            }
        //        }
        //        conn.Close();
        //    }

        //    return id;

        //}

        //public static void DeleteCategory(int id)
        //{
        //    var dbConnect = new DbConnect();
        //    var conn = dbConnect.CreateConnection();
        //    using (conn)
        //    {


        //        string query = "DELETE FROM category where id=@id";

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
