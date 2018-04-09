using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Course
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
            strConn = "Provider=SQLNCLI11;Data Source=DESKTOP-8SPOQEU\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=course";
            cn2.ConnectionString = strConn;
            dSet = new DataSet();
            String strSQLGoods = "SELECT * FROM Goods WHERE (Price > 0)";
            dAdapter = new OleDbDataAdapter(strSQLGoods, strConn);
            dAdapter.Fill(dSet, "Goods");
            dgGoogs.SetDataBinding(dSet, "Goods");
            dSet1 = new DataSet();
            String strSQLOrders = "SELECT * FROM OrdersCustomers";
            dAdapter = new OleDbDataAdapter(strSQLOrders, strConn);
            dAdapter.Fill(dSet1, "OrdersCustomers");
            dgOrders.SetDataBinding(dSet1, "OrdersCustomers");
            cn2.Open();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void Customer_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show(" Want to go out? ", " Caution!", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
            cn2.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand insertOrder = new OleDbCommand("AddOrder", cn2);
            insertOrder.CommandType = CommandType.StoredProcedure;
            insertOrder.Parameters.Add("@FIO", OleDbType.VarChar, 30).Value = FIO.Text.Trim();
            insertOrder.Parameters.Add("@NameGoods", OleDbType.VarChar, 25).Value = NameGoods.Text.Trim();
            insertOrder.Parameters.Add("@Quantity", OleDbType.Integer).Value = Quantuty.Text.Trim();
            try
            {
                insertOrder.ExecuteNonQuery();
                MessageBox.Show("Record successfully inserted!");
                FIO.Text = " ";
                NameGoods.Text = " ";
                Quantuty.Text = " ";
            }
            catch (OleDbException exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dSet2 = new DataSet();
            String strSQLOrders = "SELECT * FROM OrdersCustomers";
            dAdapter = new OleDbDataAdapter(strSQLOrders, strConn);
            dAdapter.Fill(dSet2, "OrdersCustomers");
            dgOrders.SetDataBinding(dSet2, "OrdersCustomers");
        }

        private void dgGoogs_Navigate(object sender, NavigateEventArgs ne)
        {

        }
    }
}
