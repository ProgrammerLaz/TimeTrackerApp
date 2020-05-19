using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using System.Text;

namespace TimeTrackerApp
{
    class Calculations
    {
        public static void ListActivityCategories()
        {
            //Initiates a MySQL connection and executes a MySQL command to search for data for two columns in a table
            DataTable dt = new DataTable();
            _ = new Database(Program.cs);
            using (MySqlCommand cmd = new MySqlCommand("select activity_category_id,category_description from activity_categories", Database.con))
            {
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["activity_category_id"].ToString() + ". " + reader["category_description"].ToString());
                }
                Database.con.Close();
            }
        }
        public static void ListActivityDescriptions()
        {
            //Initiates a MySQL connection and executes a MySQL command to search for data for two columns in a table
            DataTable dt = new DataTable();
            _ = new Database(Program.cs);
            using (MySqlCommand cmd = new MySqlCommand("select activity_description_id,activity_description from activity_descriptions", Database.con))
            {
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["activity_description_id"].ToString() + ". " + reader["activity_description"].ToString());
                }
                Database.con.Close();
            }
        }
        public static void ListTrackedCalendarDates()
        {
            //Initiates a MySQL connection and executes a MySQL command to search for data for two columns in a table
            DataTable dt = new DataTable();
            _ = new Database(Program.cs);
            using (MySqlCommand cmd = new MySqlCommand("select calendar_date_id,calendar_date from tracked_calendar_dates", Database.con))
            {
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["calendar_date_id"].ToString() + ". " + reader["calendar_date"].ToString());
                }
                Database.con.Close();
            }
        }
        public static void ListActivityTimes()
        {
            //Initiates a MySQL connection and executes a MySQL command to search for data for two columns in a table
            DataTable dt = new DataTable();
            _ = new Database(Program.cs);
            using (MySqlCommand cmd = new MySqlCommand("select activity_time_id,time_spent_on_activity from activity_times", Database.con))
            {
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["activity_time_id"].ToString() + ". " + reader["time_spent_on_activity"].ToString());
                }
                Database.con.Close();
            }
        }
        public static int InsertIntoActivityLog(string activityCategory, string activityDescription, string calendarDate, string activityTime)
        {
            int results = 0;
            try
            {
                _ = new Database(Program.cs);
                MySqlCommand comm = Database.con.CreateCommand();
                comm.CommandText = "INSERT INTO activity_log(category_description,activity_description,calendar_date,time_spent_on_activity) VALUES(@activityCategory, @activityDescription, @calendarDare, @activityTime)";
                comm.Parameters.AddWithValue("@activityCategory", activityCategory);
                comm.Parameters.AddWithValue("@activityDescription", activityDescription);
                comm.Parameters.AddWithValue("@calendarDare", calendarDate);
                comm.Parameters.AddWithValue("@activityTime", activityTime);
                results = comm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Database.con.Close();
            }
            return results;
        }
    }
}
