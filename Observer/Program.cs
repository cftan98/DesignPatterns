using Observer;

var myAccount = new MyFacebookChannel();

myAccount.Attach( new User("Joe"));
myAccount.Attach(new User("Mike"));
myAccount.Attach(new User("John"));

myAccount.Notify();