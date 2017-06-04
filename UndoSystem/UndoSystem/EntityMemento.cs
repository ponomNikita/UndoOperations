using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UndoSystem.Memento;

namespace UndoSystem
{
    public class EntityMemento : Memento.Memento
    {
        public EntityMemento(IMementable owner) : base(owner)
        {
        }

        public override void Restore()
        {
            var owner = _owner as Entity;
            var memento = _memento as Entity;

            if (owner != null && memento != null)
            {
                owner.Value = memento.Value;
            }
        }
    }
}
