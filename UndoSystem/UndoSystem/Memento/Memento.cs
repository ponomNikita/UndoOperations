using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndoSystem.Memento
{
    public abstract class Memento
    {
        protected readonly IMementable _memento;
        protected IMementable _owner;

        public Memento(IMementable owner)
        {
            _memento = owner.Clone();
            _owner = owner;
        }

        public abstract void Restore();
    }
}
