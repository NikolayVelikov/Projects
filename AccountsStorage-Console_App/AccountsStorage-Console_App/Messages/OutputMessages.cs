using System;

namespace AccountsStorage_Console_App.Messages
{
    public static class OutputMessages
    {
        public static string possibleOptions = "Please select a command number:" + Environment.NewLine + "1. Creating folder" + Environment.NewLine + "2. Creating file" + Environment.NewLine + "3. Adding information in the file" + Environment.NewLine + "4. Printing information from the file";
        public const string fillingFolderName = "Write the Folder Name: ";
        public const string fillingFileName = "Write the File Name: ";
        public const string finishedOperations = "Done";
    }
}
