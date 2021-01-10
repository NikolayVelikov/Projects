using AccountsStorage_Console_App.File.Contracts;
using AccountsStorage_Console_App.Functionality.Contracts;

namespace AccountsStorage_Console_App.Functionality.Entities
{
    public class ReaderFile : IReader
    {
        private IFile _file;

        public ReaderFile(IFile file)
        {
            this._file = file;
        }

        public string Read()
        {
            return System.IO.File.ReadLines(this._file.FilePath).ToString();
        }
    }
}
