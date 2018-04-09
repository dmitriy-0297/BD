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
    public partial class Seller : Form
    {
        public Seller()
        {
            InitializeComponent();
            strConn = "Provider=SQLNCLI11;Data Source=DESKTOP-8SPOQEU\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=course";
            cn1.ConnectionString = strConn;
            dSet = new DataSet();
            String strSQLGoods = "SELECT * FROM Goods";
            dAdapter = new OleDbDataAdapter(strSQLGoods, strConn);
            dAdapter.Fill(dSet, "Goods");
            dgGoods.SetDataBinding(dSet, "Goods");
            dSet5 = new DataSet();
            String strSQLPurchase = "SELECT * FROM Purchases";
            dAdapter = new OleDbDataAdapter(strSQLPurchase, strConn);
            dAdapter.Fill(dSet5, "Purchases");
            dgPurchase.SetDataBinding(dSet5, "Purchases");
            dSet6 = new DataSet();
            String strSQLPurchaseDetails = "SELECT * FROM PurchaseDetails";
            dAdapter = new OleDbDataAdapter(strSQLPurchaseDetails, strConn);
            dAdapter.Fill(dSet6, "PurchaseDetails");
            dgPurchaseDetails.SetDataBinding(dSet6, "PurchaseDetails");
            dSet9 = new DataSet();
            String strSQLSupplyer = "SELECT * FROM Supplues";
            dAdapter = new OleDbDataAdapter(strSQLSupplyer, strConn);
            dAdapter.Fill(dSet9, "Supplues");
            dgSupplyes.SetDataBinding(dSet9, "Supplues");
            dSet10 = new DataSet();
            String strSQLOrders = "SELECT * FROM OrdersCustomers";
            dAdapter = new OleDbDataAdapter(strSQLOrders, strConn);
            dAdapter.Fill(dSet10, "OrdersCustomers");
            dgOrders.SetDataBinding(dSet10, "OrdersCustomers");
            dSet11 = new DataSet();
            String strSQLCust = "SELECT * FROM Customers";
            dAdapter = new OleDbDataAdapter(strSQLCust, strConn);
            dAdapter.Fill(dSet11, "Customers");
            dgCust.SetDataBinding(dSet11, "Customers");
            cn1.Open();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Seller_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(" Want to go out? ", " Caution!", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
            cn1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dSet2 = new DataSet();
            string strSQL = "SELECT Name FROM Goods";
            dAdapter = new OleDbDataAdapter(strSQL, strConn);
            dAdapter.Fill(dSet2, "Goods");
            dTable = dSet.Tables["Goods"];
            bool flag = false;
            for (int i = 0; i <= dTable.Rows.Count - 1; i++)
            {
                if (NameGoods.Text.ToString() == dTable.Rows[i][2].ToString().Trim())
                {
                    FormErrorGoods secondform = new FormErrorGoods();
                    secondform.Show();
                    flag = true;
                    break;
                }
                else if (i == dTable.Rows.Count - 1)
                {
                    if (flag == false)
                    {
                        OleDbCommand insertProcurementCmd = new OleDbCommand("insertProcurement", cn1);
                        insertProcurementCmd.CommandType = CommandType.StoredProcedure;
                        insertProcurementCmd.Parameters.Add("@Data", OleDbType.Date).Value = Data.Text.Trim();
                        insertProcurementCmd.Parameters.Add("@SellerPhone", OleDbType.VarChar, 12).Value = SellerPhone.Text.Trim();
                        insertProcurementCmd.Parameters.Add("@NameGoods", OleDbType.VarChar, 15).Value = NameGoods.Text.Trim();
                        insertProcurementCmd.Parameters.Add("@Quantity", OleDbType.Integer).Value = Quantity.Text.Trim();
                        try
                        {
                            insertProcurementCmd.ExecuteNonQuery();
                            MessageBox.Show("Record successfully inserted!");
                            Data.Text = " ";
                            SellerPhone.Text = " ";
                            NameGoods.Text = " ";
                            Quantity.Text = " ";   
                        }
                        catch (OleDbException exc)
                        {
                            MessageBox.Show(exc.ToString());
                        }
                        break;
                    }
                }
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dSet1 = new DataSet();
            String strSQLGoods = "SELECT * FROM Goods";
            dAdapter = new OleDbDataAdapter(strSQLGoods, strConn);
            dAdapter.Fill(dSet1, "Goods");
            dgGoods.SetDataBinding(dSet1, "Goods");
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            //----------------------------------------------------------------------------
            dSet8 = new DataSet();
            string strSQL = "SELECT Name FROM Goods";
            dAdapter = new OleDbDataAdapter(strSQL, strConn);
            dAdapter.Fill(dSet8, "Goods");
            dTable = dSet.Tables["Goods"];
            bool flag = false;
            for (int i = 0; i <= dTable.Rows.Count - 1; i++)
            {
                if (NameGood.Text.ToString() == dTable.Rows[i][2].ToString().Trim())
                {

                    OleDbCommand insertSupplierCmd = new OleDbCommand("InsertPurchase", cn1);
                    insertSupplierCmd.CommandType = CommandType.StoredProcedure;
                    insertSupplierCmd.Parameters.Add("@Date", OleDbType.Date).Value = PurchaseDate.Text.Trim();
                    insertSupplierCmd.Parameters.Add("@NameGoods", OleDbType.VarChar, 25).Value = NameGood.Text.Trim();
                    insertSupplierCmd.Parameters.Add("@Quantity", OleDbType.Integer).Value = QuantityGoods.Text.Trim();
                    insertSupplierCmd.Parameters.Add("@Price", OleDbType.Double).Value = PriceGoods.Text.Trim();
                    insertSupplierCmd.Parameters.Add("@FIO", OleDbType.VarChar, 30).Value = FIO.Text.Trim();
                    insertSupplierCmd.Parameters.Add("@Phone", OleDbType.VarChar, 12).Value = Phone.Text.Trim();
                    insertSupplierCmd.Parameters.Add("@PhoneCust", OleDbType.VarChar, 12).Value = PhoneCust.Text.Trim();
                    try
                    {
                        insertSupplierCmd.ExecuteNonQuery();
                        MessageBox.Show("Record successfully inserted!");
                        PhoneCust.Text = " ";
                        PurchaseDate.Text = " ";
                        NameGood.Text = " ";
                        QuantityGoods.Text = " ";
                        PriceGoods.Text = " ";
                        FIO.Text = " ";
                        Phone.Text = " ";
                    }
                    catch (OleDbException exc)
                    {
                        MessageBox.Show(exc.ToString());
                    }
                    flag = true;
                    break;
                }
                else if (i == dTable.Rows.Count - 1)
                {
                    if (flag == false) { 
                      FormErrorGoods secondform = new FormErrorGoods();
                    secondform.Show();
                    break;
                }
            }
        }

        //------------------------------------------------------------------------------

    }

    private void button3_Click(object sender, EventArgs e)
    {
        dSet4 = new DataSet();
        String strSQLPurchases = "SELECT * FROM Purchases";
        dAdapter = new OleDbDataAdapter(strSQLPurchases, strConn);
        dAdapter.Fill(dSet4, "Purchases");
        dgPurchase.SetDataBinding(dSet4, "Purchases");
    }

    private void button4_Click(object sender, EventArgs e)
    {
        dSet7 = new DataSet();
        String strSQLPurchaseDetails = "SELECT * FROM PurchaseDetails";
        dAdapter = new OleDbDataAdapter(strSQLPurchaseDetails, strConn);
        dAdapter.Fill(dSet7, "PurchaseDetails");
        dgPurchaseDetails.SetDataBinding(dSet7, "PurchaseDetails");
    }

        private void dgSupplyes_Navigate(object sender, NavigateEventArgs ne)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OleDbCommand insertPriceCmd = new OleDbCommand("ChangePrice", cn1);
            insertPriceCmd.CommandType = CommandType.StoredProcedure;
            insertPriceCmd.Parameters.Add("@ID", OleDbType.Integer).Value = IDGood.Text.Trim();
            insertPriceCmd.Parameters.Add("@Price", OleDbType.Double).Value = PrGood.Text.Trim();
            try
            {
                insertPriceCmd.ExecuteNonQuery();
                MessageBox.Show("Record successfully inserted!");
                IDGood.Text = " ";
                PrGood.Text = " ";
            }
            catch (OleDbException exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void Seller_Load(object sender, EventArgs e)
        {

        }

        private void dataGrid1_Navigate(object sender, NavigateEventArgs ne)
        {

        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void Quantity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
