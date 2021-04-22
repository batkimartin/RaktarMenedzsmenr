using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaktárMenedzsment.State
{
    class OrderPackingState : PlushStatusState
    {

        public override void NextStatus(PlushStatus plushStatus)
        {
            plushStatus.UpdateStatus("Rendelés kiszállítás alatt");
            plushStatus.setState(new OrderTransportState());
        }

        public OrderPackingState()
        {
            
        }
    }
}
