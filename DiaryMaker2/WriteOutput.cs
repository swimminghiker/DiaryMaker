using System;
using System.Globalization;
using System.Text;

namespace DiaryMaker2
{
    class WriteOutput  
    {
        private readonly IWriteAble _writeAble;

        public WriteOutput(IWriteAble writeAble)
        {
            this._writeAble = writeAble;
        }

        public void WriteFile(DateTime specifiedMonth, string targetFileNameAndPath, string[] monthDailyHeader)
        {
            _writeAble.WriteLegend(targetFileNameAndPath);
            _writeAble.WriteContents(specifiedMonth, targetFileNameAndPath, monthDailyHeader);
        }
    }
}
