using System;
using System.Globalization;
using System.Text;

namespace DiaryMaker2
{
    class ConsoleWriter : IWriteAble
    {
        public void WriteLegend(string targetFileNameAndPath)
        {
            try
            {
                //Writing Legend
                Console.WriteLine("- Events");
                Console.WriteLine("# Thoughts");
                Console.WriteLine("+ Action Items");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void WriteContents(DateTime specifiedMonth, string targetFileNameAndPath, string[] monthDailyHeader)
        {
            try
            {
                //Creating Date headers
                int daysInGivenMonth = DateTime.DaysInMonth(specifiedMonth.Year, specifiedMonth.Month);
                Calendar myCal = CultureInfo.InvariantCulture.Calendar;
                for (int i = 0; i < daysInGivenMonth; i++)
                {
                    monthDailyHeader[i] = specifiedMonth.DayOfWeek + ", " + specifiedMonth.ToString("MMMM") + " " + specifiedMonth.Day + " " + specifiedMonth.Year;
                    specifiedMonth = myCal.AddDays(specifiedMonth, 1);

                    Console.WriteLine(monthDailyHeader[i]);
                    Console.WriteLine("===========================");
                    Console.WriteLine("");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return;
        }
    }



}

