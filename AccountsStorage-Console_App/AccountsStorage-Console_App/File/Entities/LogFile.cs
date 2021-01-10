using AccountsStorage_Console_App.File.Contracts;

namespace AccountsStorage_Console_App.File.Entities
{
    class LogFile : IFile
    {
        private IPathManager _pathManager;

        public LogFile(IPathManager pathManager)
        {
            this._pathManager = pathManager;
            this._pathManager.EnsureCurrentFileAndFolderExist();
        }

        public string FilePath => this._pathManager.CurrentFilePath;
    }
}
