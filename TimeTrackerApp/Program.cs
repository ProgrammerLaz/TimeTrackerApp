using MySql.Data.MySqlClient;
using System;

namespace TimeTrackerApp
{
    class Program
    {
        //Database Location
        public static string cs = @"server= 127.0.0.1;userid=root;password=root;database=lazarorondon_mdv229_database_202005;port=3306";
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, what would you like to do today?");
            Console.WriteLine("1. Enter Activity");
            Console.WriteLine("2. View Tracked Data");
            Console.WriteLine("3. Run Calculations");
            Console.WriteLine("4. Exit");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Menu.EnterActivity();
                    break;
                case "2":
                    Menu.ViewTrackedData();
                    break;
                case "3":
                    Menu.RunCalculations();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }
}
