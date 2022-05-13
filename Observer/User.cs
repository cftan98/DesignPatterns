namespace Observer
{
    internal class User
    {
        internal string Name { get; set; }

        internal User(string name)
        {
            this.Name = name;
        }

        internal void Update()
        {
            Console.WriteLine($"{Name} starts following my facebook account...");
        }
    }
}