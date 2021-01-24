using AccountsStorage_Console_App.Constants;
using AccountsStorage_Console_App.Functionality.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountsStorage_Console_App.Functionality.Entities
{
    public class ReportFromFile : IReport
    {
        private const string showing = Templates.TemplateForShowing;
        private IReader _reader;

        public ReportFromFile(IReader reader)
        {
            this._reader = reader;
        }

        public string AllFile() // Read All in the file
        {
            string output = string.Join(Environment.NewLine, this._reader.Read());
            return output;
        }

        public string Activities() // return only section for activities with index row
        {
            List<string> output = this._reader.Read();
            StringBuilder sb = new StringBuilder();

            foreach (string row in output)
            {
                string[] arrayRow = row.Split('|');
                sb.AppendLine(arrayRow[0] + "=> " + arrayRow[3]);
            }

            return sb.ToString().TrimEnd();
        }

        public string InformationForDay(string dayNumber)
        {
            throw new System.NotImplementedException();
        }

        public string InformationForOneRow(int row)
        {
            throw new System.NotImplementedException();
        }

        public string InformationForSomeRows(int[] rows)
        {
            throw new System.NotImplementedException();
        }

        public string Sum()
        {
            throw new System.NotImplementedException();
        }
    }
}
