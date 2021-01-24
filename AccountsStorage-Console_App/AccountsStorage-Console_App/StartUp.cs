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

            IEngine engine = new Engine(read, write);
            engine.Run();

        }
    }
}
