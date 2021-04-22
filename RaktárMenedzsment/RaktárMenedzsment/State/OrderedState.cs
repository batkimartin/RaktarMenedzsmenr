using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaktárMenedzsment.State
{
    class OrderedState : PlushStatusState
    {
        public override void NextStatus(PlushStatus plushStatus)
        {
            plushStatus.UpdateStatus("Rendelés feldolgozás alatt");
            plushStatus.setState(new OrderProcessingState());
        }

        public OrderedState()
        {
           
        }

    }
}
