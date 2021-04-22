using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaktárMenedzsment.State
{
    class OrderTransportState : PlushStatusState
    {
        public override void NextStatus(PlushStatus plushStatus)
        {
            plushStatus.UpdateStatus("Rendelés kiszállítva");
            plushStatus.setState(new OrderReadyState());
        }

        public OrderTransportState()
        {
            
        }
    }
}
