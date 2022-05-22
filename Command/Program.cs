using Command;

var light = new Light( );
var invoker = new Invoker( new LightOnCommand( light ), new LightOffCommand( light ) );
invoker.TurnOnTheLight( );
invoker.TurnOffTheLight( );