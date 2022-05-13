namespace Strategy
{
    internal class HandleCsv : IFileHandler
    {
        void IFileHandler.HandleFile()
        {
            Console.WriteLine("Start reading from CSV file...");
        }
    }
}
