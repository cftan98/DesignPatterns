namespace Strategy
{
    internal class FileReader
    {
        private readonly IFileHandler _fileHandler;

        internal FileReader(IFileHandler handleFile)
        {
            _fileHandler = handleFile;
        }

        internal void Read()
        {
            _fileHandler.HandleFile();
        }
    }
}
