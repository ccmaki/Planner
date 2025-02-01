using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner
{
    internal class taskrepo
    {
        private string connString = "server=localhost; uid=root; pwd=admin; database=planner";

        public List<Class1> GetTasks()
        {
            List<Class1> tasks = new List<Class1>();
            using (MySqlConnection con = new MySqlConnection(connString))
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM task_table;", con);
                DataTable dtbl = new DataTable();
                da.Fill(dtbl);

                foreach (DataRow row in dtbl.Rows)
                {
                    tasks.Add(new Class1
                    {
                        task = row["task"].ToString(),
                        status = row["status"].ToString(),
                        deadline = row["deadline"].ToString(),
                        description = row["description"].ToString()
                    });
                }
                con.Close();
            }

            return tasks;
        }

        public void DeleteTask(Class1 class1)
        {
            using (MySqlConnection con = new MySqlConnection(connString))
            {
                con.Open();
                string sql = "DELETE FROM task_table WHERE task = @task AND status = @status AND deadline = @deadline AND description = @description";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@task", class1.task);
                cmd.Parameters.AddWithValue("@status", class1.status);
                cmd.Parameters.AddWithValue("@deadline", class1.deadline);
                cmd.Parameters.AddWithValue("@description", class1.description);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
