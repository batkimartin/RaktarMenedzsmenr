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
    public partial class frmStorageManagementMain : Form
    {
        public frmStorageManagementMain()
        {
            InitializeComponent();
        }

        private void frmStorageManagementMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonWarehouseInventory_Click(object sender, EventArgs e)
        {

        }

        private void buttonAllOrders_Click(object sender, EventArgs e)
        {
            frmOrderManagement frmOrderManagement = new frmOrderManagement();
            frmOrderManagement.ShowDialog();
        }
    }
}
