namespace Singleton
{
    public class Instance
    {
        private static Instance _instance = new();

        private Instance()
        {
        }

        public static Instance GetInstance()
        {
            if (_instance != null)
            {
                return _instance;
            }

            _instance = new Instance();
            return _instance;
        }
    }
}