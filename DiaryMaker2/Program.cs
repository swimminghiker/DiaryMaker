using System;
using System.Collections.Generic;



namespace DiaryMaker2
{
    class Program
    {
        static void Main(string[] args)
        { 

            try
            {
                //Get Desired Month
                DateTime specifiedMonth = UserInput.Get2DigitMonth();

                //Set Output Path
                var filePath = new SetOutput(specifiedMonth); 
                string targetFileNameAndPath = filePath["DeskTop"];

                //Create Output.
                string[] daysOfMonthHeaders = new string[DateTime.DaysInMonth(specifiedMonth.Year, specifiedMonth.Month)];
                SetOutput.DoesFileExits(targetFileNameAndPath);

                var writetext = new WriteOutput(new TextWriter());
                writetext.WriteFile(specifiedMonth, targetFileNameAndPath, daysOfMonthHeaders);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
