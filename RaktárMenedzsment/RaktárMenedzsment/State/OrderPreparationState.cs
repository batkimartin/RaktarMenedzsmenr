using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaktárMenedzsment.State
{
    class OrderPreparationState:PlushStatusState
    {
        public override void NextStatus(PlushStatus plushStatus)
        {
            plushStatus.UpdateStatus("Rendelés csomagolása");
            plushStatus.setState(new OrderPackingState());
        }

        public OrderPreparationState()
        {
           
        }
    }
}
