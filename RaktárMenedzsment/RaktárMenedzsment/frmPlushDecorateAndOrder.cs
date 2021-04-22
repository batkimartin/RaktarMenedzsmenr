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
    public partial class frmPlushDecorateAndOrder : Form
    {
        Equipments equipment;
        PlushOrders plushOrders;
        PlushWarehouse plushWarehouse;
        private int orderQuantity;
        public frmPlushDecorateAndOrder(int plushWarehouseId,int orderQuantity)
        {
            InitializeComponent();
            plushWarehouse = new PlushWarehouse();
            plushOrders = new PlushOrders();
            plushWarehouse = plushWarehouse.GetPlushWareHousebyPlushId(plushWarehouseId);
            this.orderQuantity = orderQuantity;
            labelOrderPlushName.Text = "Plüss figura: " + plushWarehouse.plushName;
            labelOrderedQuantity.Text = "Rendelni kívánt mennyiség: " + orderQuantity;
        }
        private void frmPlushDecorateAndOrder_Load(object sender, EventArgs e)
        {
            equipment = new Equipments();
            FillCheckedListBoxEquipments();
        }
        private void FillCheckedListBoxEquipments()
        {
            List<Equipments> equipments= equipment.GetEquipments();
            foreach (Equipments eq in equipments)
            {
                checkedListBoxEquipments.Items.Add(eq.equipmentName);
            }
        }

        private void buttonOrderSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxCustomerName.Text))
            {
                MessageBox.Show("A név megadása kötelező!");
                return;
            }
            List<string> selectedequipments = new List<string>();
            foreach (var item in checkedListBoxEquipments.CheckedItems)
            {
                selectedequipments.Add(item.ToString());
            }
            PlushBase plush = new Plush();
            if (selectedequipments.Contains("Sál"))
                plush = new ScarfDecorator(plush);
            if (selectedequipments.Contains("Sapka"))
                plush = new CapDecorator(plush);
            if (selectedequipments.Contains("Nyakörv"))
                plush = new CollarDecorator(plush);
            if (selectedequipments.Contains("Pulcsi"))
                plush = new HoodieDecorator(plush);
            if (selectedequipments.Contains("Napszemüveg"))
                plush = new SunglassesDecorator(plush);

            plushOrders.InsertOrder(plushWarehouse.plushId, plush.GetEquipments(), textBoxCustomerName.Text, orderQuantity);
            this.Close();
        }
    }
}
