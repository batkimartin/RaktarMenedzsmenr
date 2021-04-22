using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaktárMenedzsment.State
{
    class OrderReadyState : PlushStatusState
    {
        public override void NextStatus(PlushStatus plushStatus)
        {
            plushStatus.setState(new OrderReadyState());
        }

        public OrderReadyState()
        {
        }
    }
}
