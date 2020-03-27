using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Music_App
{
    class StoredProcedureEXEC
    {
        public static string MyConn = @"Data Source = (local)\SQLEXPRESS; Initial Catalog = Music_po; Integrated Security = True";

        static public void ExecuteProcedure(string MyQuery, string SuccesText, Form form)
        {
            using (SqlConnection conn = new SqlConnection(MyConn))
            {
                using (SqlCommand command = new SqlCommand(MyQuery, conn))
                {
                    try
                    {
                        conn.Open();
                    }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        MessageBox.Show("Проблемы с соединением с сервером БД\nПроверьте подключение", "Авторизация");
                        return;
                    }
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch(SqlException e)
                    {
                        MessageBox.Show(e.Message, "Ошибка добавления");
                        return;
                    }
                    if(SuccesText != "")
                        MessageBox.Show(SuccesText);
                    conn.Close();
                    if(form != null)
                        form.Hide();
                }
            }
        }
     
        static public string ExecuteProcedureWithoutput (string proc_name,string login, string song_name)
        {
            using (SqlConnection conn = new SqlConnection(MyConn))
            {
                try
                {
                    SqlCommand command = conn.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = $"[{proc_name}]";
                    command.Parameters.Add("@Username", SqlDbType.NVarChar, 100);
                    command.Parameters["@Username"].Value = login;

                    command.Parameters.Add("@Track_name", SqlDbType.NVarChar, 100);
                    command.Parameters["@Track_name"].Value = song_name;

                    command.Parameters.Add("@Answer", SqlDbType.NVarChar, 10);
                    command.Parameters["@Answer"].Direction = ParameterDirection.Output;
                    conn.Open();
                    command.ExecuteScalar();
                    string answer = (Convert.ToString(command.Parameters["@Answer"].Value));
                    return answer;
                }
                catch (Exception ex)
                { MessageBox.Show(ex.ToString()); return "Err"; }
                finally
                { conn.Close(); }
            }
        }

       
    }
}
