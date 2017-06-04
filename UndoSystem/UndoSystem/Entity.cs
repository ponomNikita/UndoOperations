using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UndoSystem.Command;
using UndoSystem.Memento;

namespace UndoSystem
{
    public class Entity : IMementable
    {
        public int Value { get; set; }

        private Entity Clone()
        {
            return new Entity() {Value = Value};
        }

        public void Increment()
        {
            var incrementCommand = new IncrementValueCommand(this);
            incrementCommand.Execute();
        }

        public void Decrement()
        {
            var decrementCommand = new DecrementValueCommand(this);
            decrementCommand.Execute();
        }

        public Memento.Memento CreateMemento()
        {
            return new EntityMemento(this);
        }

        IMementable IMementable.Clone()
        {
            return Clone();
        }
    }
}
