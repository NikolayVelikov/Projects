using AccountsStorage_Console_App.Constants;
using AccountsStorage_Console_App.IO.Contracts;
using AccountsStorage_Console_App.File.Contracts;
using AccountsStorage_Console_App.Functionality.Contracts;

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

            string input = _reader.Read();
            if (input.Length == 0)
            {
                input = string.Format(Templates.TemplateForFillingInputsInFile, 1, date, price, description);
            }
            else
            {
                input += string.Format(Templates.TemplateForFillingInputsInFile, 1, date, price, description);
            }

            System.IO.File.WriteAllText(_file.FilePath, input);
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
    }
}
