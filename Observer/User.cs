namespace Observer
{
    internal class User
    {
        internal string Name { get; set; }

        internal User(string Name)
        {
            this.Name = Name;
        }

        internal void Update()
        {
            Console.WriteLine($"{Name} starts following my facebook account...");
        }

    }
}