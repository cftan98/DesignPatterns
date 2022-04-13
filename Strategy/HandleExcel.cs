namespace Strategy
{
    internal class HandleExcel : IFileHandler
    {
        void IFileHandler.HandleFile()
        {
            Console.WriteLine("Start reading from Excel file...");
        }
    }
}
