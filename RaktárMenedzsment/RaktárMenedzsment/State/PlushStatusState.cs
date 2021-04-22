using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaktárMenedzsment.State
{
    abstract class PlushStatusState
    {
        public abstract void NextStatus(PlushStatus plushStatus);        
    }
}
