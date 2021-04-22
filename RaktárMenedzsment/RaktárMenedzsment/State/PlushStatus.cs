using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaktárMenedzsment.State
{
    class PlushStatus
    {
        private PlushStatusState state;
        private int orderId;
        PlushOrders plushOrders = new PlushOrders();
        public void setState(PlushStatusState state)
        {
            this.state = state;
        }

        public void NextStatus()
        {
            state.NextStatus(this);
        }

        public void UpdateStatus(string newStatusName)
        {
            plushOrders.UpdateOrderStatus(orderId, newStatusName);
        }

        public PlushStatus(PlushStatusState state,int orderId)
        {
            this.state = state;
            this.orderId = orderId;
        }
    }
}
