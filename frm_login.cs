using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POS
{
    public partial class frm_login : Form
    {
        private mydatabase myDatabase = new mydatabase();
        public frm_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable loginTable = new DataTable();
            loginTable = this.myDatabase.execyteSqlCommand("SELECT * FROM tbl_userAccount WHERE USERNAME = '" + txt_username.Text + "' AND password ='" + txt_password.Text + "' ");
            if(loginTable.Rows.Count > 0)
            {
                MessageBox.Show("You are logged in");
                //call frm_main
                frm_main frm_Main = new frm_main();
                frm_Main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username and Password are incorrect!");
            }
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
