using MySql.Data.MySqlClient;
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
    public partial class Main : Form
    {
       
        public Main()
        {
            InitializeComponent();
        }

       
        private void btnOrder_Click(object sender, EventArgs e)
        {
            frmOrderCenter frmOrderCenter = new frmOrderCenter();
            frmOrderCenter.ShowDialog();
        }

        private void btnAdministration_Click(object sender, EventArgs e)
        {
            frmStorageManagementMain frmStorageManagement = new frmStorageManagementMain();
            frmStorageManagement.ShowDialog();
        }
    }
}
