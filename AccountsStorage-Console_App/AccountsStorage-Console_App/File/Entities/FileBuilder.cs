using System.IO;

using AccountsStorage_Console_App.File.Contracts;

namespace AccountsStorage_Console_App.File.Entities
{
    public class FileBuilder : IFileBuilder
    {
        private IPathManager _pathManager;

        public FileBuilder(IPathManager pathManager)
        {
            this._pathManager = pathManager;

            CreatingFile();
        }

        public string FilePath => this._pathManager.CurrentFilePath;

        public void CreatingFile()
        {
            this._pathManager.EnsureCurrentFileAndFolderExist();

            Directory.CreateDirectory(this._pathManager.CurrentDirectoryPath);

            System.IO.File.AppendAllText(this.FilePath, string.Empty);
        }
    }
}
