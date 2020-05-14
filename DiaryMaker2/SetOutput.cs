using System;
using System.Collections.Generic;
using System.IO;

namespace DiaryMaker2
{
    public class SetOutput
    {
        private readonly Dictionary<string, string> _filepahth;

        public SetOutput(DateTime specifiedMonth)
        {
            _filepahth = new Dictionary<string, string>();
            _filepahth.Add("CurrentDirecotry", @Directory.GetCurrentDirectory() + @"\" + specifiedMonth.ToString("MMMM") + specifiedMonth.Year + ".txt");
            _filepahth.Add("DeskTop", @Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + specifiedMonth.ToString("MMMM") + specifiedMonth.Year + ".txt");
            _filepahth.Add("MyDocuments", @Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + specifiedMonth.ToString("MMMM") + specifiedMonth.Year + ".txt");
            _filepahth.Add("Personal", @Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\" + specifiedMonth.ToString("MMMM") + specifiedMonth.Year + ".txt");
            _filepahth.Add("Recent", @Environment.GetFolderPath(Environment.SpecialFolder.Recent) + @"\" + specifiedMonth.ToString("MMMM") + specifiedMonth.Year + ".txt");
        }
        public string this[string key]
        {
            get { return _filepahth[key]; }
            set { _filepahth[key] = value; }
        }
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
    }
}
