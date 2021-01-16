using System.Collections.Generic;

namespace AccountsStorage_Console_App.Functionality.Contracts
{
    public interface IReader
    {
        List<string> Read();
    }
}
