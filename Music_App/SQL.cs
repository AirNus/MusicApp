using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Music_AppML
{
    class SQL
    {
        static private string connectionString = @"Data Source = (local)\SQLEXPRESS; Initial Catalog = Music_po; Integrated Security = True";

        static internal SqlCommand StoredProcedure(SqlCommand command)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                command.Connection = conn;
                try 
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    return null;
                }
                
                conn.Close();
            }
                return command;
        }
        static internal List<string> Query(SqlCommand command)
        {
            List<string> rezult = new List<string>();
            SqlDataReader reader;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {                
                conn.Open();
                command.Connection = conn;
                try
                {
                    reader = command.ExecuteReader();
                }
                catch (SqlException)
                {
                    return null;
                }
                if(reader.HasRows)
                { 
                while(reader.Read())
                {
                    rezult.Add(reader[0].ToString());
                }
                }
                conn.Close();
            }
           return rezult;
            
        }
    }
}
