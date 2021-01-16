using System.Linq;
using System.Collections.Generic;

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

        public List<string> Read()
        {
            List<string> information = System.IO.File.ReadLines(this._file.FilePath).ToString().Split(System.Environment.NewLine,System.StringSplitOptions.RemoveEmptyEntries).ToList();

            return information;
        }
    }
}
