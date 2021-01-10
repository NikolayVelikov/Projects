using AccountsStorage_Console_App.IO.Contracts;

namespace AccountsStorage_Console_App.IO.Entities
{
    public class ConsoleWrite : IWrite
    {
        public void Write(string text)
        {
            System.Console.Write(text);
        }

        public void WriteLine(string text)
        {
            System.Console.WriteLine(text);
        }
    }
}
