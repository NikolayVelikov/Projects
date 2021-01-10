using AccountsStorage_Console_App.IO.Contracts;

namespace AccountsStorage_Console_App.IO.Entities
{
    public class ConsoleReade : IRead
    {
        public string ReadLine()
        {
            return System.Console.ReadLine();
        }
    }
}
