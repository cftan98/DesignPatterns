using System;

namespace Command
{
    internal static class Program
    {
        public static void Main( string [ ] args )
        {
            var light = new Light( );
            var lightController = new Invoker( new LightOnCommand( light ), new LightOffCommand( light ) );
            lightController.TurnOnTheLight( );
            lightController.TurnOffTheLight( );
        }
    }

    public class LightOffCommand : ICommand
    {
        private readonly Light _light;

        public LightOffCommand( Light light )
        {
            _light = light;
        }

        public void Execute( )
        {
            _light.Off( );
        }

        public void Undo( )
        {
            _light.On( );
        }
    }

    public class Invoker
    {
        private readonly LightOnCommand _lightOnCommand;
        private readonly LightOffCommand _lightOffCommand;

        public Invoker( LightOnCommand lightOnCommand, LightOffCommand lightOffCommand )
        {
            _lightOnCommand = lightOnCommand;
            _lightOffCommand = lightOffCommand;
        }

        public void TurnOnTheLight( )
        {
            _lightOnCommand.Execute( );
        }

        public void TurnOffTheLight( )
        {
            _lightOffCommand.Execute( );
        }
    }

    internal interface ICommand
    {
        void Execute( );
        void Undo( );
    }

    public class LightOnCommand : ICommand
    {
        private readonly Light _light;

        public LightOnCommand( Light light )
        {
            _light = light;
        }

        public void Execute( )
        {
            _light.On( );
        }

        public void Undo( )
        {
            _light.Off( );
        }
    }

    public class Light
    {
        public void On( )
        {
            Console.WriteLine( "The light is on..." );
        }

        public void Off( )
        {
            Console.WriteLine( "The light is off..." );
        }
    }
}