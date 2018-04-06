using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab1Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan timeDiff;
            double days, hours, minutes;

            //user enters first date string
            Start:
            Console.WriteLine("We are going to determine the difference in two dates. ");
            Console.Write("Please enter a date in dd/mm/yyyy format. ");
            var strDate1 = Console.ReadLine();


            {
                //user enters second date string
                Console.Write("Please enter another date in dd/mm/yyyy format. ");
                var strDate2 = Console.ReadLine();

                //will display error message and start over if user inputs incorrectly
                if ( strDate1=="" || strDate1.Length > 10 || strDate1.Length < 10)
                {
                    Console.Write("Please enter in dd/mm/yyyy format. Press 'Enter' to start over");
                    Console.ReadLine();
                    goto Start;
                   

                }


                {

                    //string converted to DateTime
                    var day1 = DateTime.Parse(strDate1);
                    var day2 = DateTime.Parse(strDate2);

                    //difference between dates are determined in Days, Hours, and Minutes
                    timeDiff = (day1 - day2);
                    days = timeDiff.TotalDays;
                    hours = timeDiff.TotalHours;
                    minutes = timeDiff.TotalMinutes;

                    //difference between dates are displayed on console
                    Console.WriteLine("The time between " + strDate1 + " and " + strDate2 + "is: ");
                    Console.WriteLine("Days: " + Math.Abs(days));
                    Console.WriteLine("Hours: " + Math.Abs(hours));
                    Console.WriteLine("Minutes: " + Math.Abs(minutes));
                    Console.Read();

                }

                {

                }
            }

        }
    }
}




