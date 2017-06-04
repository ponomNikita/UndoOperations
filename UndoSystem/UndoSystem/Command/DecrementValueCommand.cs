using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndoSystem.Command
{
    public class DecrementValueCommand : Command
    {
        public DecrementValueCommand(Entity entity) : base(entity)
        {
        }

        protected override void ExecuteCommand()
        {
            _entity.Value = _entity.Value - 1;
        }

        public override Command Clone()
        {
            return new DecrementValueCommand(_entity);
        }
    }
}
