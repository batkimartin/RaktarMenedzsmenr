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
    public partial class frmOrderCenter : Form
    {
        PlushWarehouse plushWarehouse;
        public frmOrderCenter()
        {
            InitializeComponent();
            plushWarehouse = new PlushWarehouse();
            fill_dataGridViewAvailableOrderPlush();
        }

        private void fill_dataGridViewAvailableOrderPlush()
        {
            dataGridViewAvailableOrderPlush.DataSource = plushWarehouse.GeTWareHouseItemsDataSet().Tables[0];
            dataGridViewAvailableOrderPlush.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnDecoratePlush_Click(object sender, EventArgs e)
        {
            if (dataGridViewAvailableOrderPlush.SelectedRows.Count > 0)
            {
                var x = dataGridViewAvailableOrderPlush.SelectedRows[0].Index;
                if (Convert.ToInt32(dataGridViewAvailableOrderPlush.SelectedRows[0].Cells["PlushQuantityInStock"].Value) >= numericUpDownOrderQuantity.Value)
                {
                    int plushWarehouseId = Convert.ToInt32(dataGridViewAvailableOrderPlush.SelectedRows[0].Cells["PlushId"].Value);
                    frmPlushDecorateAndOrder frmPlushDecorate = new frmPlushDecorateAndOrder(plushWarehouseId, (int)numericUpDownOrderQuantity.Value);
                    frmPlushDecorate.ShowDialog();
                }
                else
                {
                    MessageBox.Show(String.Format("Nincs elegendő darab raktáron. Maximum {0} rendelhető", numericUpDownOrderQuantity.Value));
                }
            }
            else
            {
                MessageBox.Show("Nincs kiválasztva plüss figura!!");
            }
        }
    }
}
