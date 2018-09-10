using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterEditor.ViewModel
{
    public interface ISubtractable
    {
        ISubtractable Subtract(uint x);
    }
}