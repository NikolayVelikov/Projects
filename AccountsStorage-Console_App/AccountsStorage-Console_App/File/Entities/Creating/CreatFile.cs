namespace AccountsStorage_Console_App.File.Entities.Creating
{
    public class CreatFile : Create
    {
        public CreatFile(string folderName, string fileName)
            :base(folderName,fileName)
        {}

        public override void Creat()
        {
            base._pathManager.CreatingFile();
        }
    }
}
