namespace Command;

internal class Invoker
{
    private readonly ICommand _lightOnCommand;
    private readonly ICommand _lightOffCommand;

    internal Invoker( ICommand lightOnCommand, ICommand lightOffCommand )
    {
        _lightOnCommand = lightOnCommand;
        _lightOffCommand = lightOffCommand;
    }

    internal void TurnOnTheLight( )
    {
        _lightOnCommand.Execute( );
    }

    internal void TurnOffTheLight( )
    {
        _lightOffCommand.Execute( );
    }
}