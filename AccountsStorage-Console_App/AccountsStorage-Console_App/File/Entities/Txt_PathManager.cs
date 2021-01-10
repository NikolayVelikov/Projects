using System;
using System.IO;

using AccountsStorage_Console_App.Constants;
using AccountsStorage_Console_App.File.Contracts;
using AccountsStorage_Console_App.Messages;

namespace AccountsStorage_Console_App.File.Entities
{
    public class Txt_PathManager : IPathManager
    {
        private const string txt = FileExstentions.txtExtention;
        private readonly string _filePath;
        private readonly string _folderPath;
        
        public Txt_PathManager(string folderPath, string filePath)
        {
            this._folderPath = folderPath;
            this._filePath = filePath+txt;
        }

        public string CurrentFilePath => Path.Combine(this.CurrentDirectoryPath,this._filePath);

        public string CurrentDirectoryPath =>Path.Combine(DirectoryContainer.DirectoryPath, this._folderPath);

        public void EnsureCurrentFileAndFolderExist()
        {
            if (Directory.Exists(this.CurrentDirectoryPath)) // Checking if folder exist
            {
                throw new ArgumentException(ExceptionMessages.InvalidFolderNameOrDirectory);
            }
            if (Directory.Exists(this.CurrentFilePath)) // Checking if file exist
            {
                throw new ArgumentException(ExceptionMessages.InvalidFileName);
            }
        }

    }
}
