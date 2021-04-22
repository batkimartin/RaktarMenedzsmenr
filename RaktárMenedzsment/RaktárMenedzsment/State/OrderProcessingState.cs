using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaktárMenedzsment.State
{
    class OrderProcessingState : PlushStatusState
    {
        public override void NextStatus(PlushStatus plushStatus)
        {
            plushStatus.UpdateStatus("Rendelés elokészítés");
            plushStatus.setState(new OrderPreparationState());
        }

        public OrderProcessingState()
        {
           
        }
    }
}
