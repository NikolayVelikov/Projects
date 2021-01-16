namespace AccountsStorage_Console_App.File.Contracts
{
    public interface IPathManager
    {
        string CurrentFilePath { get; }
        string CurrentDirectoryPath { get; }
        string GetCurrentDirectory();        
        void CreatingFile();
        void CreatingFolder();
        void EnsureFolderExist();
        void EnsureFileExist();
    }
}
