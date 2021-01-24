using System;

namespace AccountsStorage_Console_App.Messages
{
    public static class OutputMessages
    {
        public static string possibleOptions = "Please select a command number:" + Environment.NewLine + "1. Creating folder" + Environment.NewLine + "2. Creating file" + Environment.NewLine + "3. Adding information in the file" + Environment.NewLine + "4. Printing information from the file";
        public static string ContinueOrNot = "If you want to continue write \"yes\"" + Environment.NewLine + "If you do not want to continue write \"no\"";

        public static string possibleForReading = "Please select a command number:" + Environment.NewLine + "1. Reading all informaton from the file" + Environment.NewLine + "2. Printing all activities" + Environment.NewLine + "3. All information for some day" + Environment.NewLine + "4. All information from chosen row" + Environment.NewLine + "5. All information for some rows" + Environment.NewLine + "6. Sum for the month";

        public const string fillingFolderName = "Write the Folder Name: ";
        public const string fillingFileName = "Write the File Name: ";
        public const string finishedOperations = "Done";       
    }
}
