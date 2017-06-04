using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndoSystem.Command
{
    public class CommandDispatcher
    {
        private static CommandDispatcher _instance;

        private Stack<Command> _commands;

        private Memento.Memento _savedState;

        private CommandDispatcher()
        {
            _commands = new Stack<Command>();
        }

        public static CommandDispatcher GetCommandDispatcher()
        {
            if (_instance == null)
            {
                _instance = new CommandDispatcher();
            }
            return _instance;
        }

        public void Add(Command command)
        {
            _commands.Push(command);
        }

        public void Undo()
        {
            if (_commands.Any())
                _commands.Pop();

            if (_commands.Any())
            {
                var commands = _commands.ToArray().Reverse();
                _commands.Clear();

                if (_savedState != null)
                {
                    _savedState.Restore();
                }

                foreach (var command in commands)
                {
                    command.Execute();
                }
            }
        }

        public void SaveState(Memento.Memento state)
        {
            _savedState = state;
        }
    }
}
