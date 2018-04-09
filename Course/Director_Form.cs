using System;
using System.Data.Sql;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;

namespace Course
{
    public partial class Director : Form
    {
        public Director()
        {
            InitializeComponent();
            strConn = "Provider=SQLNCLI11;Data Source=DESKTOP-8SPOQEU\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=course";
            cn.ConnectionString = strConn;
            dSet = new DataSet();
            String strSQLSellers = "SELECT * FROM Sellers";
            dAdapter = new OleDbDataAdapter(strSQLSellers, strConn);
            dAdapter.Fill(dSet, "Sellers");
            dgSellers.SetDataBinding(dSet, "Sellers");
            dSet3 = new DataSet();
            String strSQLSupplier = "SELECT * FROM Suppliers";
            dAdapter = new OleDbDataAdapter(strSQLSupplier, strConn);
            dAdapter.Fill(dSet3, "Suppliers");
            dgSuppliers.SetDataBinding(dSet3, "Suppliers");
            dSet4 = new DataSet();
            String strSQLCustomers = "SELECT * FROM Customers";
            dAdapter = new OleDbDataAdapter(strSQLCustomers, strConn);
            dAdapter.Fill(dSet4, "Customers");
            dgCustomers.SetDataBinding(dSet4, "Customers");
            cn.Open();
        }

        private void Director_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(" Want to go out? ", " Caution!", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
            cn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand insertSellerCmd = new OleDbCommand("InsertSeller", cn);
            insertSellerCmd.CommandType = CommandType.StoredProcedure;
            insertSellerCmd.Parameters.Add("@FIO", OleDbType.VarChar, 30).Value = FIO.Text.Trim();
            insertSellerCmd.Parameters.Add("@Salary", OleDbType.Double).Value = Salary.Text.Trim();
            insertSellerCmd.Parameters.Add("@Status", OleDbType.VarChar, 10).Value = Status.Text.Trim();
            insertSellerCmd.Parameters.Add("@Phone", OleDbType.VarChar, 12).Value = Phone.Text.Trim();

            try
            {
                insertSellerCmd.ExecuteNonQuery();
                MessageBox.Show("Record successfully inserted!");

                FIO.Text = " ";
                Salary.Text = " ";
                Status.Text = " ";
                Phone.Text = " ";
            }
            catch (OleDbException exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void Director_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dSet1 = new DataSet();
            String strSQLSellers = "SELECT * FROM Sellers";
            dAdapter = new OleDbDataAdapter(strSQLSellers, strConn);
            dAdapter.Fill(dSet1, "Sellers");
            dgSellers.SetDataBinding(dSet1, "Sellers");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbCommand insertSellerCmd = new OleDbCommand("ChangeStatusSeller", cn);
            insertSellerCmd.CommandType = CommandType.StoredProcedure;
            insertSellerCmd.Parameters.Add("@Phone", OleDbType.VarChar, 12).Value = IDSellerOrPhone.Text.Trim();
            insertSellerCmd.Parameters.Add("@Status", OleDbType.VarChar, 10).Value = StatusSeller.Text.Trim();
            try
            {
                insertSellerCmd.ExecuteNonQuery();
                MessageBox.Show("Record successfully inserted!");

                IDSellerOrPhone.Text = " ";
                StatusSeller.Text = " ";
            }
            catch (OleDbException exc)
            {
                MessageBox.Show(exc.ToString());
            }
            IDSellerOrPhone.Text = " ";
            StatusSeller.Text = " ";
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OleDbCommand insertSellerCmd = new OleDbCommand("ChangeSalarySeller", cn);
            insertSellerCmd.CommandType = CommandType.StoredProcedure;
            insertSellerCmd.Parameters.Add("@Phone", OleDbType.VarChar, 12).Value = IDSellerOrPhone.Text.Trim();
            insertSellerCmd.Parameters.Add("@Salary", OleDbType.Double).Value = SalarySeller.Text.Trim();
            try
            {
                insertSellerCmd.ExecuteNonQuery();
                MessageBox.Show("Record successfully inserted!");

                IDSellerOrPhone.Text = " ";
                SalarySeller.Text = " ";
            }
            catch (OleDbException exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OleDbCommand insertSupplierCmd = new OleDbCommand("InsertSupplier", cn);
            insertSupplierCmd.CommandType = CommandType.StoredProcedure;
            insertSupplierCmd.Parameters.Add("@FIO", OleDbType.VarChar, 30).Value = SuplierFIO.Text.Trim();
            insertSupplierCmd.Parameters.Add("@Phone", OleDbType.VarChar, 12).Value = SupplierPhone.Text.Trim();
            insertSupplierCmd.Parameters.Add("@Status", OleDbType.VarChar, 10).Value = SuplierStatus.Text.Trim();
            try
            {
                insertSupplierCmd.ExecuteNonQuery();
                MessageBox.Show("Record successfully inserted!");

                SuplierFIO.Text = " ";
                SupplierPhone.Text = " ";
                SuplierStatus.Text = " ";
            }
            catch (OleDbException exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dSet2 = new DataSet();
            String strSQLSupplier = "SELECT * FROM Suppliers";
            dAdapter = new OleDbDataAdapter(strSQLSupplier, strConn);
            dAdapter.Fill(dSet2, "Suppliers");
            dgSuppliers.SetDataBinding(dSet2, "Suppliers");
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            OleDbCommand insertSupplierCmd = new OleDbCommand("ChangeStatusSupplier", cn);
            insertSupplierCmd.CommandType = CommandType.StoredProcedure;
            insertSupplierCmd.Parameters.Add("@Phone", OleDbType.VarChar, 12).Value = EnterPhoneSuppliers.Text.Trim();
            insertSupplierCmd.Parameters.Add("@Status", OleDbType.VarChar, 10).Value = EnterSupplierStatus.Text.Trim();
            try
            {
                insertSupplierCmd.ExecuteNonQuery();
                MessageBox.Show("Record successfully inserted!");

                EnterPhoneSuppliers.Text = " ";
                EnterSupplierStatus.Text = " ";
            }
            catch (OleDbException exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            OleDbCommand insertSupplierActiveCmd = new OleDbCommand("SearchActiveSeller", cn);
            insertSupplierActiveCmd.CommandType = CommandType.StoredProcedure;
            OleDbParameter Phone = new OleDbParameter()
            {
                ParameterName = "@Phone",
                OleDbType = OleDbType.VarChar,
                Direction = ParameterDirection.Output,
                Size = 12
            };
            insertSupplierActiveCmd.Parameters.Add(Phone);
            insertSupplierActiveCmd.ExecuteNonQuery();
            ActiveSeller.Text = insertSupplierActiveCmd.Parameters["@Phone"].Value.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OleDbCommand insertSupplierActiveCmd = new OleDbCommand("SearchPassiveSeller", cn);
            insertSupplierActiveCmd.CommandType = CommandType.StoredProcedure;
            OleDbParameter Phone = new OleDbParameter()
            {
                ParameterName = "@Phone",
                OleDbType = OleDbType.VarChar,
                Direction = ParameterDirection.Output,
                Size = 12
            };
            insertSupplierActiveCmd.Parameters.Add(Phone);
            insertSupplierActiveCmd.ExecuteNonQuery();
            PassiveSeller.Text = insertSupplierActiveCmd.Parameters["@Phone"].Value.ToString();
        }
    }
}