using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }
        frm_inventory frmInventory;
        private void menuStrip1_ItemClicked(object sender, EventArgs e)
        {
            if(frmInventory == null)
            {
                frmInventory = new frm_inventory();
                frmInventory.MdiParent = this;
                frmInventory.FormClosed += FrmInventory_FormClosed;
                frmInventory.Show();
            }
            else
            {
                frmInventory.Activate();
            }
        }

        private void FrmInventory_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmInventory = null;
            //throw new NotImplementedException();
        }

    }
}
