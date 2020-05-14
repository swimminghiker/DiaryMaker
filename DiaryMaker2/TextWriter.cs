using System;
using System.Globalization;
using System.Text;

namespace DiaryMaker2
{
    class TextWriter : IWriteAble
    {
        public void WriteLegend(string targetFileNameAndPath)
        {
            try
            {
                
                //Writing Legend
                System.IO.File.AppendAllText(targetFileNameAndPath, "- Events" + Environment.NewLine, Encoding.Unicode);
                System.IO.File.AppendAllText(targetFileNameAndPath, "# Thoughts" + Environment.NewLine, Encoding.Unicode);
                System.IO.File.AppendAllText(targetFileNameAndPath, "+ Action Items" + Environment.NewLine, Encoding.Unicode);
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

                    System.IO.File.AppendAllText(targetFileNameAndPath, monthDailyHeader[i] + Environment.NewLine, Encoding.Unicode);
                    System.IO.File.AppendAllText(targetFileNameAndPath, "===========================" + Environment.NewLine, Encoding.Unicode);
                    System.IO.File.AppendAllText(targetFileNameAndPath, "" + Environment.NewLine, Encoding.Unicode);
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
