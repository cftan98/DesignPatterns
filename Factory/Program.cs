using Factory.Classes;

var carFactory = new CarFactory();

var honda = carFactory.GetHonda();
var toyota = carFactory.GetToyota();

honda.Start();
honda.Stop();

toyota.Start();
toyota.Stop();