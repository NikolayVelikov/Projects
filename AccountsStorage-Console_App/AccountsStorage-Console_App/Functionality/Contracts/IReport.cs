namespace AccountsStorage_Console_App.Functionality.Contracts
{
    public interface IReport
    {
        string AllFile();
        string Sum();
        string InformationForOneRow(int row);
        string InformationForSomeRows(int[] rows);
        string InformationForDay(string dayNumber);
        string Activities();
    }
}
