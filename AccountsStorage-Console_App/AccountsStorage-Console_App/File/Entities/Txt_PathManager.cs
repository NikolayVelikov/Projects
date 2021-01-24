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

        private readonly string _fileName;
        private readonly string _folderName;
        private string _directoryPath;

        private Txt_PathManager()
        {
            _directoryPath = GetCurrentDirectory();
        }
        public Txt_PathManager(string folderName)
            : this()
        {
            this._folderName = folderName;
        }
        public Txt_PathManager(string folderName, string fileName)
            : this()
        {
            this._folderName = folderName;
            this._fileName = fileName + txt;
        }

        public string CurrentFilePath => Path.Combine(this.CurrentDirectoryPath, this._fileName);

        public string CurrentDirectoryPath => Path.Combine(this._directoryPath, this._folderName);

        public string GetCurrentDirectory() // Taking current directory
        {
            return Directory.GetCurrentDirectory();
        }

        public void CreatingFile()
        {
            CheckIfFileExist();

            System.IO.File.WriteAllText(this.CurrentFilePath, string.Empty); // Creating File with current extention
        }
        public void CreatingFolder()
        {
            CheckIfFolderExist();

            Directory.CreateDirectory(this.CurrentDirectoryPath); // Creting Folder
        }

        public void EnsureFolderExist()
        {
            if (!Directory.Exists(this.CurrentDirectoryPath)) // Checking if folder exist
            {
                throw new ArgumentException(ExceptionMessages.FolderNotExist);
            }
        }
        public void EnsureFileExist()
        {            
            if (!System.IO.File.Exists(this.CurrentFilePath)) // Checking if file exist
            {
                throw new ArgumentException(ExceptionMessages.FileNotExist);
            }
        }

        public void CheckIfFileExist()
        {

            if (Directory.Exists(this.CurrentFilePath)) // Checking if file exist
            {
                throw new ArgumentException(ExceptionMessages.FileNameAlreadyExist);
            }
        }
        private void CheckIfFolderExist()
        {
            if (Directory.Exists(this.CurrentDirectoryPath)) // Checking if folder exist
            {
                throw new ArgumentException(ExceptionMessages.FolderNameAlreadyExist);
            }
        }
    }
}
