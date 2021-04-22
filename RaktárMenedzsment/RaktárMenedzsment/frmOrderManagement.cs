using RaktárMenedzsment.State;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaktárMenedzsment
{
    public partial class frmOrderManagement : Form
    {
        PlushOrders plushOrders;
        public frmOrderManagement()
        {
            InitializeComponent();
            plushOrders = new PlushOrders();
            fill_dataGridViewAvailableOrderPlush();
        }

        private void fill_dataGridViewAvailableOrderPlush()
        {
            dataGridViewActiveOrders.DataSource = plushOrders.GetPlushOrdersDataSet().Tables[0];
            dataGridViewActiveOrders.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dataGridViewActiveOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                string actualStatusName = dataGridViewActiveOrders.Rows[e.RowIndex].Cells["OrderStatus"].Value.ToString();
                int plushOrderId = (int)dataGridViewActiveOrders.Rows[e.RowIndex].Cells["PlushOrderId"].Value;
                PlushStatus plushStatus = new PlushStatus(GetActualState(actualStatusName), plushOrderId);
                plushStatus.NextStatus();
                fill_dataGridViewAvailableOrderPlush();            
        }

        private PlushStatusState GetActualState(string statusName)
        {
            switch (statusName)
            {
                case "Rendelés rögzítve":
                    return new OrderedState();
                case "Rendelés feldolgozás alatt":
                    return new OrderProcessingState();
                case "Rendelés elokészítés":
                    return new OrderPreparationState();
                case "Rendelés csomagolása":
                    return new OrderPackingState();
                case "Rendelés kiszállítás alatt":
                    return new OrderTransportState();
                case "Rendelés kiszállítva":
                    return new OrderReadyState();
                default:
                    return new OrderedState();

            }
        }

    }
}
