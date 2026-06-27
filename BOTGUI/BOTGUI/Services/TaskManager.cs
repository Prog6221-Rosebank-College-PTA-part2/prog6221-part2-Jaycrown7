using BOTGUI.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace BOTGUI.Services
{
    public class TaskManager
    {
        Database db = new Database();

        public void AddTask(TaskItem task)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"INSERT INTO Tasks
                                (Title, Description, ReminderDate, Status)
                                VALUES
                                (@title,@description,@date,@status)";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@title", task.Title);
                cmd.Parameters.AddWithValue("@description", task.Description);
                cmd.Parameters.AddWithValue("@date", task.ReminderDate);
                cmd.Parameters.AddWithValue("@status", task.Status);

                cmd.ExecuteNonQuery();
            }
        }

        public List<TaskItem> GetTasks()
        {
            List<TaskItem> tasks = new List<TaskItem>();

            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM Tasks";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    TaskItem task = new TaskItem();

                    task.TaskID = reader.GetInt32("TaskID");
                    task.Title = reader.GetString("Title");
                    task.Description = reader.GetString("Description");

                    if (!reader.IsDBNull(reader.GetOrdinal("ReminderDate")))
                        task.ReminderDate = reader.GetDateTime("ReminderDate");

                    task.Status = reader.GetString("Status");

                    tasks.Add(task);
                }
            }

            return tasks;
        }
    }
}