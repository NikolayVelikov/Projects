using System;

using AccountsStorage_Console_App.IO.Entities;
using AccountsStorage_Console_App.IO.Contracts;
using AccountsStorage_Console_App.Core.Entities;
using AccountsStorage_Console_App.Core.Contracts;

namespace AccountsStorage_Console_App
{
    class StartUp
    {
        static void Main(string[] args)
        {
            IWrite write = new ConsoleWrite();
            IRead read = new ConsoleReade();

            write.WriteLine("Select possible options from 1-2");
            write.WriteLine("1 -> New File" + Environment.NewLine + "2 -> Adding Information" + Environment.NewLine + "3 -> Reading Information");
            string comand = string.Empty;
            bool pass = false;
            while (pass)
            {
                switch (read.ReadLine())
                {
                    case "1": comand = "newFile"; pass = true; break;
                    case "2": comand = "adding"; pass = true; break;
                    case "3": comand = "reading"; pass = true; break;
                    default: continue;
                }
            }

            if (comand == "newFile")
            {
                write.WriteLine("Please fill needed information:");
                write.WriteLine("Folder Name: ");
                string folderName = read.ReadLine();
                write.WriteLine("File Name: ");
                string fileName = read.ReadLine();
            }

            IEngine engine = new Engine(read, write);
            engine.Run(comand);

        }
    }
}
