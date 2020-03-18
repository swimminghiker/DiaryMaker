using System;
using System.Collections.Generic;
using System.IO;


namespace DiaryMaker2
{
    
    class Program
    {
        static void Main(string[] args)
        {

            
            try
            {
                DateTime specifiedMonth = UserInput.Get2DigitMonth();
                
                Dictionary<string, string> filePath = new Dictionary<string, string>();
                filePath.Add("CurrentDirecotry", @Directory.GetCurrentDirectory() + @"\" + specifiedMonth.ToString("MMMM") + specifiedMonth.Year + ".txt");
                filePath.Add("DeskTop", @Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + specifiedMonth.ToString("MMMM") + specifiedMonth.Year + ".txt");
                
                string targetFileNameAndPath = filePath["DeskTop"];
                string[] myString = new string[DateTime.DaysInMonth(specifiedMonth.Year, specifiedMonth.Month)];

                OutputCreator.DoesFileExits(targetFileNameAndPath);
                OutputCreator.WriteLegend(targetFileNameAndPath); 
                OutputCreator.WriteDate(specifiedMonth, targetFileNameAndPath, myString);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
