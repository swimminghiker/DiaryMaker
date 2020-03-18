using System;
using System.Globalization;
using System.IO;
using System.Text;

namespace DiaryMaker2
{
    public class OutputCreator
    {
        public static void DoesFileExits(string targetFileNameAndPath)
        {
            try
            {
                if (File.Exists(targetFileNameAndPath))
                {
                    Console.WriteLine("File already exist. Press lower case 'y' to delete and create new file. All other keys to keep & append.");
                    ConsoleKeyInfo cki = Console.ReadKey();
                    if (cki.KeyChar == 'y') { File.Delete(targetFileNameAndPath); }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void WriteLegend(string targetFileNameAndPath)
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
        public static void WriteDate(DateTime specifiedMonth, string targetFileNameAndPath, string[] smOutput)
        {
            try
            {
                
                //Creating Date headers
                int daysInGivenMonth = DateTime.DaysInMonth(specifiedMonth.Year, specifiedMonth.Month);
                Calendar myCal = CultureInfo.InvariantCulture.Calendar;
                for (int i = 0; i < daysInGivenMonth; i++)
                {
                    smOutput[i] = specifiedMonth.DayOfWeek + ", " + specifiedMonth.ToString("MMMM") + " " + specifiedMonth.Day + " " + specifiedMonth.Year;
                    specifiedMonth = myCal.AddDays(specifiedMonth, 1);

                    System.IO.File.AppendAllText(targetFileNameAndPath, smOutput[i] + Environment.NewLine, Encoding.Unicode);
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
