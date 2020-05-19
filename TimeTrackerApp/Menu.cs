using System;
using System.Collections.Generic;
using System.Text;

namespace TimeTrackerApp
{
    class Menu
    {
        public static void EnterActivity()
        {
            Console.WriteLine("Pick a category of activity: ");
            Calculations.ListActivityCategories();
            string activityCategory = Console.ReadLine();
            int convertedActivityCategory;
            if (!string.IsNullOrWhiteSpace(activityCategory) && int.TryParse(activityCategory, out convertedActivityCategory))
            {
                if (convertedActivityCategory > 0 || convertedActivityCategory < 25)
                {
                    Console.WriteLine("Pick an activity description: ");
                    Calculations.ListActivityDescriptions();
                    string activityDescription = Console.ReadLine();
                    int convertedActivityDescription;
                    if (!string.IsNullOrWhiteSpace(activityDescription) && int.TryParse(activityDescription, out convertedActivityDescription))
                    {
                        if (convertedActivityDescription > 0 || convertedActivityDescription < 25)
                        {
                            Console.WriteLine("What date did you perform activity: ");
                            Calculations.ListTrackedCalendarDates();
                            string calendarDates = Console.ReadLine();
                            int convertedCalendarDates;
                            if (!string.IsNullOrWhiteSpace(calendarDates) && int.TryParse(calendarDates, out convertedCalendarDates))
                            {
                                if (convertedCalendarDates > 0 || convertedCalendarDates < 27)
                                {
                                    Console.WriteLine("How long did you perform that activity: ");
                                    Calculations.ListActivityTimes();
                                    string activityTimes = Console.ReadLine();
                                    int convertedActivityTimes;
                                    if (!string.IsNullOrWhiteSpace(activityTimes) && int.TryParse(activityTimes, out convertedActivityTimes))
                                    {
                                        if (convertedActivityTimes > 0 || convertedActivityTimes < 27)
                                        {
                                            if (Calculations.InsertIntoActivityLog(activityCategory, activityDescription, calendarDates, activityTimes) > 0)
                                            {
                                                Validation.ValidateInsertion();
                                                Console.WriteLine("Press any key to go to the main menu...");
                                                Console.ReadKey();
                                                Console.Clear();
                                                Program.Main(null);
                                            }
                                            else
                                            {
                                                Console.WriteLine("Database insert was not successful! Returning to main menu...");
                                                Program.Main(null);
                                            }
                                        }
                                        else
                                        {
                                            EnterActivity();
                                        }
                                    }
                                    else
                                    {
                                        EnterActivity();
                                    }
                                }
                                else
                                {
                                    EnterActivity();
                                }
                            }
                            else
                            {
                                EnterActivity();
                            }
                        }
                        else
                        {
                            EnterActivity();
                        }
                    }
                    else
                    {
                        EnterActivity();
                    }
                }
                else
                {
                    EnterActivity();
                }
            }
            else
            {
                EnterActivity();
            }
        }
        public static void ViewTrackedData()
        {
            Console.WriteLine("1. Select by date: ");
            Console.WriteLine("2. Select by category: ");
            Console.WriteLine("3. Select by description: ");
            string option = Console.ReadLine();
            switch (option)
            {

            }
        }
        public static void RunCalculations()
        {

        }
    }
}
