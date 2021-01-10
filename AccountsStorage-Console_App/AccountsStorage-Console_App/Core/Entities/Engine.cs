using System;
using AccountsStorage_Console_App.Core.Contracts;
using AccountsStorage_Console_App.IO.Contracts;

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

        public void Run(string comand)
        {
            if (comand == "newFile")
            {

            }
            else if (comand == "adding")
            {

            }
            else if (comand == "reading")
            {

            }
        }
    }
}
