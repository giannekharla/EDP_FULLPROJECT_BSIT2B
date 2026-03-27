using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SARIA_EDP
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm frm = new RegisterForm();
            frm.ShowDialog();
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            StoreStatus frm = new StoreStatus();
            frm.ShowDialog();
        }

        private void btnPricebook_Click(object sender, EventArgs e)
        {
            Pricebook frm = new Pricebook();
            frm.ShowDialog();
        }

        private void btnVendors_Click(object sender, EventArgs e)
        {
            Vendors frm = new Vendors();
            frm.ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Users frm = new Users();
            frm.ShowDialog();
        }

        private void btnTimeClock_Click(object sender, EventArgs e)
        {
            TimeClock frm = new TimeClock();
            frm.ShowDialog();
        }
    }
}
