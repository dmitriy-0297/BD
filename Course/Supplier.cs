using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Course
{
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
            strConn3 = "Provider=SQLNCLI11;Data Source=DESKTOP-8SPOQEU\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=course";
            cn3.ConnectionString = strConn3;
            dSet = new DataSet();
            String strSQLProcurements = "SELECT * FROM Procurements";
            dAdapter = new OleDbDataAdapter(strSQLProcurements, strConn3);
            dAdapter.Fill(dSet, "Procurements");
            dgProcurements.SetDataBinding(dSet, "Procurements");
            dSet1 = new DataSet();
            String strSQLSupplues = "SELECT * FROM Supplues";
            dAdapter = new OleDbDataAdapter(strSQLSupplues, strConn3);
            dAdapter.Fill(dSet1, "Supplues");
            dgSupl.SetDataBinding(dSet1, "Supplues");
            dSet4 = new DataSet();
            String strSQLGoods = "SELECT * FROM Goods";
            dAdapter = new OleDbDataAdapter(strSQLGoods, strConn3);
            dAdapter.Fill(dSet4, "Goods");
            dgGoods.SetDataBinding(dSet4, "Goods");
            cn3.Open();
        }

        private void Supplier_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(" Want to go out? ", " Caution!", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
            cn3.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dSet3 = new DataSet();
            String strSQLSupplues = "SELECT * FROM Supplues";
            dAdapter = new OleDbDataAdapter(strSQLSupplues, strConn3);
            dAdapter.Fill(dSet3, "Supplues");
            dgSupl.SetDataBinding(dSet3, "Supplues");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbCommand insertSellerCmd = new OleDbCommand("InsertSupplyes", cn3);
            insertSellerCmd.CommandType = CommandType.StoredProcedure;
            insertSellerCmd.Parameters.Add("@PhoneSupplier", OleDbType.VarChar, 12).Value = PhoneSupplier.Text.Trim();
            insertSellerCmd.Parameters.Add("@IDSeller", OleDbType.Integer).Value = IDSeller.Text.Trim();
            insertSellerCmd.Parameters.Add("@Date", OleDbType.Date).Value = Date.Text.Trim();
            insertSellerCmd.Parameters.Add("@Quantity", OleDbType.Integer).Value = Quantity.Text.Trim();
            insertSellerCmd.Parameters.Add("@Status", OleDbType.VarChar, 15).Value = Status.Text.Trim();
            insertSellerCmd.Parameters.Add("@Price", OleDbType.Double).Value = Price.Text.Trim();
            insertSellerCmd.Parameters.Add("@NameGoods", OleDbType.VarChar, 25).Value = NameGood.Text.Trim();
            try
            {
                insertSellerCmd.ExecuteNonQuery();
                MessageBox.Show("Record successfully inserted!");

                PhoneSupplier.Text = " ";
                IDSeller.Text = " ";
                Date.Text = " ";
                Quantity.Text = " ";
                Status.Text = " ";
                Price.Text = " ";
                NameGood.Text = " ";
            }
            catch (OleDbException exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbCommand insertSellerCmd = new OleDbCommand("RefreshStatusSupl", cn3);
            insertSellerCmd.CommandType = CommandType.StoredProcedure;
            insertSellerCmd.Parameters.Add("@Status", OleDbType.VarChar, 20).Value = StatusInsert.Text.Trim();
            insertSellerCmd.Parameters.Add("@IDSupl", OleDbType.Integer).Value = IdSupply.Text.Trim();
            insertSellerCmd.Parameters.Add("@NameGoods", OleDbType.VarChar, 25).Value = NameGd.Text.Trim();
            try
            {
                insertSellerCmd.ExecuteNonQuery();
                MessageBox.Show("Record successfully inserted!");
                Status.Text = " ";
                IdSupply.Text = " ";
                NameGd.Text = " ";
            }
            catch (OleDbException exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StatusInsert_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgGoods_Navigate(object sender, NavigateEventArgs ne)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dSet5 = new DataSet();
            String strSQLGoods = "SELECT * FROM Goods";
            dAdapter = new OleDbDataAdapter(strSQLGoods, strConn3);
            dAdapter.Fill(dSet5, "Goods");
            dgGoods.SetDataBinding(dSet5, "Goods");
        }
    }
}
