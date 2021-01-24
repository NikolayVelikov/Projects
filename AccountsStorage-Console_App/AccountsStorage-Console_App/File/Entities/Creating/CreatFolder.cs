namespace AccountsStorage_Console_App.File.Entities.Creating
{
    public class CreatFolder : Create
    {
        public CreatFolder(string folderName) 
            : base(folderName)
        {}

        public override void Creat()
        {
            base._pathManager.CreatingFolder();
        }
    }
}
