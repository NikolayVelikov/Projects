using AccountsStorage_Console_App.Core.Contracts;
using AccountsStorage_Console_App.File.Contracts;
using AccountsStorage_Console_App.File.Entities;
using AccountsStorage_Console_App.File.Entities.Creating;
using AccountsStorage_Console_App.Functionality.Contracts;
using AccountsStorage_Console_App.Functionality.Entities;
using AccountsStorage_Console_App.IO.Contracts;
using AccountsStorage_Console_App.Messages;

namespace AccountsStorage_Console_App.Core.Entities
{
    public class Engine : IEngine
    {
        private IRead _read;
        private IWrite _write;

        public Engine(IRead read, IWrite write)
        {
            this._read = read;
            this._write = write;
        }

        public void Run()
        {
            bool stop = false;
            while (!stop)
            {
                this._write.WriteLine(OutputMessages.possibleOptions);
                char selectedValue = char.Parse(this._read.ReadLine());
                switch (selectedValue)
                {
                    case '1': this._write.WriteLine(CreatingFolder()); stop = true; break;
                    case '2': this._write.WriteLine(CreatingFile()); stop = true; break;
                    case '3': this._write.WriteLine(AddingInformation()); stop = true; break;
                    //case '4':
                }

                bool @continue = false;
                while (!@continue)
                {
                    this._write.WriteLine(OutputMessages.ContinueOrNot);
                    string answer = this._read.ReadLine();

                    if (answer.ToLower() == "yes")
                    {
                        @continue = true;
                        stop = false;
                    }
                    else if (answer.ToLower() == "no")
                    {
                        @continue = false;
                    }                    
                }
            }

        }
        private string CreatingFolder()
        {
            string folderName = FolderName();
            ICreate creatingFolder = new CreatFolder(folderName);
            creatingFolder.Creat();

            return OutputMessages.finishedOperations;
        }
        private string CreatingFile()
        {
            string folderName = FolderName();
            string fileName = FileName();
            ICreate creatingFile = new CreatFile(folderName, fileName);
            creatingFile.Creat();

            return OutputMessages.finishedOperations;
        }
        private string AddingInformation()
        {
            string folderName = FolderName();
            string fileName = FileName();

            IPathManager pathManager = new Txt_PathManager(folderName, fileName);
            IFile file = new LogFile(pathManager);
            IReader reader = new ReaderFile(file);
            IAppender loging = new LogAppender(this._read, this._write, file, reader);

            loging.Write();

            return OutputMessages.finishedOperations;
        }
        private string FolderName()
        {
            this._write.WriteLine(OutputMessages.fillingFolderName);
            return this._read.ReadLine().ToUpper();
        }
        private string FileName()
        {
            this._write.WriteLine(OutputMessages.fillingFolderName);
            return this._read.ReadLine().ToLower();
        }
    }
}
