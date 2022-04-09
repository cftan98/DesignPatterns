using Singleton;

var instance = Instance.GetInstance();
Console.WriteLine(instance);
Console.WriteLine(instance.GetHashCode());

var instance2 = Instance.GetInstance();
Console.WriteLine(instance2);
Console.WriteLine(instance2.GetHashCode());

Console.WriteLine( instance == instance2 );
