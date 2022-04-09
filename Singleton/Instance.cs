namespace Singleton
{
    public class Instance
    {
        private static Instance instance = new();
        private Instance()
        {
        }

        public static Instance GetInstance()
        {
            if (instance != null)
            {
                return instance;
            }

            instance = new Instance();
            return instance;
        }
    }
}
