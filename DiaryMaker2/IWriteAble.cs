using System;

namespace DiaryMaker2
{
        public interface IWriteAble
        {
            void WriteLegend(string targetFileNameAndPath);
            void WriteContents(DateTime specifiedMonth, string targetFileNameAndPath, string[] monthDailyHeader);
        }
}
