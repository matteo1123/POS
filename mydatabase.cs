using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace POS
{
    class mydatabase
    {
        //Data source 
        private string strcon = @"Data Source=DESKTOP-31SFJVO;Initial Catalog=mypos;Integrated Security=True";
        //SQL connection object
        private SqlConnection Sqlcon;

        public mydatabase()
        {
            Sqlcon = new SqlConnection(this.strcon);
        }

        public DataTable execyteSqlCommand(string sqlCommand)
        {
            DataTable dtTable = new DataTable();
            try
            {
                //open sql connection
                this.Sqlcon.Open();
                // create sqlAdapter
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand, this.Sqlcon);
                dataAdapter.Fill(dtTable);
                this.Sqlcon.Close();
            }
            catch (Exception error)
            {
                Console.Write(error.ToString());
                dtTable = null;
            }
            return dtTable;
        }

    }
}
