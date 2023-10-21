
internal class Program
{
    static void Main(string[] args) 
    {
        DatabaseManager dbManager = new DatabaseManager();
        dbManager.ReadFromTable("select * from testtable;");
    }
}
