using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndoSystem.Memento
{
    public interface IMementable
    {
        Memento CreateMemento();
        IMementable Clone();
    }
}
