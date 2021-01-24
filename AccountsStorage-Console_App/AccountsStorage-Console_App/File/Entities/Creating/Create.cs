using AccountsStorage_Console_App.File.Contracts;

namespace AccountsStorage_Console_App.File.Entities.Creating
{
    public abstract class Create : ICreate
    {
        protected IPathManager _pathManager;

        protected Create(string folderName, string fileName)
        {
            this._pathManager = new Txt_PathManager(folderName, fileName);
        }

        protected Create(string folderName)
        {
            this._pathManager = new Txt_PathManager(folderName);
        }

        public abstract void Creat();
    }
}
