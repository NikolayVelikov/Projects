using System;
using AccountsStorage_Console_App.Constants;
using AccountsStorage_Console_App.IO.Contracts;
using AccountsStorage_Console_App.File.Contracts;
using AccountsStorage_Console_App.Functionality.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace AccountsStorage_Console_App.Functionality.Entities
{
    public class LogAppender : IAppender
    {
        private IRead _read;
        private IWrite _write;
        private IFile _file;
        private IReader _reader;

        public LogAppender(IRead read, IWrite write, IFile file, IReader reader)
        {
            _read = read;
            _write = write;
            _file = file;
            _reader = reader;
        }


        public void Write(string text)
        {
            string[] information = FillingInformatonFromTheConsole();
            string date = information[0];
            string price = information[1];
            string description = information[2];

            List<string> input = _reader.Read();
            string informationForRecording;
            if (input.Count == 0)
            {
                informationForRecording = string.Format(Templates.TemplateForFillingInputsInFile, 1, date, price, description) + Environment.NewLine;                
            }
            else
            {
                string[] lastRowInformation = input[input.Count - 1].Split("|").ToArray();
                string value = lastRowInformation[0].Substring(0, lastRowInformation[0].Length - 1);
                int currentRow = int.Parse(value);
                string newIformation = string.Format(Templates.TemplateForFillingInputsInFile, currentRow + 1, date, price, description);

                informationForRecording = PreparingInformationForRecording(input,newIformation);
            }

            System.IO.File.WriteAllText(_file.FilePath, informationForRecording);
        }

        private string[] FillingInformatonFromTheConsole()
        {
            _write.WriteLine("Please, fill the needed information");
            _write.WriteLine("Date (Example: dd.MM): ");
            string date = _read.ReadLine();
            _write.WriteLine("Price :");
            string price = _read.ReadLine();
            _write.WriteLine("Description: ");
            string description = _read.ReadLine();

            return new string[] { date, price, description };
        }
        private string PreparingInformationForRecording(List<string> input, string information)
        {
            string data = string.Empty;
            foreach (string item in input)
            {
                data += item+Environment.NewLine;
            }
            data += information + Environment.NewLine;

            return data;
        }
    }
}
