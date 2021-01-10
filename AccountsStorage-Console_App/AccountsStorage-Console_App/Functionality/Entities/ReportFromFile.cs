using AccountsStorage_Console_App.Functionality.Contracts;
using System.Linq;
using System.Text;

namespace AccountsStorage_Console_App.Functionality.Entities
{
    public class ReportFromFile : IReport
    {
        private IReader _reader;


        public ReportFromFile(IReader reader)
        {
            this._reader = reader;
        }
        public string AllFile() // Read All in the file
        {
            return this._reader.Read();
        }

        public string Activitis() // return only section for activities with index row
        {
            string[] file = AllFile().Split('|', System.StringSplitOptions.RemoveEmptyEntries).ToArray();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < file.Length; i++)
            {
                string output = file[i];
                i += 3;
                output += file[i];
                sb.AppendLine(output);
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
