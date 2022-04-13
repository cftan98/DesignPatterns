namespace Strategy
{
    internal class HandleCSV : IFileHandler
    {
        void IFileHandler.HandleFile()
        {
            Console.WriteLine("Start reading from CSV file...");
        }
    }
}
