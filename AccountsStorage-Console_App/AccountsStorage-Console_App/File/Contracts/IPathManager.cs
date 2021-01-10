namespace AccountsStorage_Console_App.File.Contracts
{
    public interface IPathManager
    {
        string CurrentFilePath { get; }
        string CurrentDirectoryPath { get; }
        void EnsureCurrentFileAndFolderExist();
    }
}
