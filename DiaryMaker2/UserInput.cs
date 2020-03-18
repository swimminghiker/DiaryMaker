﻿using System;
using System.Globalization;

namespace DiaryMaker2
{
    public class UserInput
    {
        public static DateTime Get2DigitMonth()
        {
            int imUserInput;
            string inputedMonth;
            try
            {
                while (true)
                {
                    Console.WriteLine("Please enter 2 digit for the month: 01 for January and 12 for December");
                    inputedMonth = Console.ReadLine();
                    if (inputedMonth == "") { return new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01, new GregorianCalendar()); }
                    if (inputedMonth.Length == 2 && Int32.TryParse(inputedMonth, out imUserInput) && imUserInput <= 12) { break; }
                }
                
                DateTime specifiedMonth = new DateTime(DateTime.Now.Year, int.Parse(imUserInput.ToString()), 01, new GregorianCalendar());
                return specifiedMonth;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //return new DateTime(0001,01,01);  //how do you return a null for DateTime?
                //return DateTime.MinValue;
                return default;
            }
        }
    }
}
