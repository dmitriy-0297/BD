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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            strConn = "Provider=SQLNCLI11;Data Source=DESKTOP-8SPOQEU\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=course";
            cn.ConnectionString = strConn;
            dSet = new DataSet();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(" Want to go out? ", " Caution!", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (comboBox.Text == "Seller")
            {
                string strSQL = "SELECT Phone FROM Sellers WHERE (Status = 'Working')";
                dAdapter = new OleDbDataAdapter(strSQL, strConn);
                dAdapter.Fill(dSet, "Sellers");
                dTable = dSet.Tables["Sellers"];
                bool flag = false;
                for (int i = 0; i <= dTable.Rows.Count - 1; i++)
                {
                    if (login.Text == dTable.Rows[i][0].ToString() && password.Text == "seller")
                    {
                        Seller secondform = new Seller();
                        secondform.Show();
                        flag = true;
                        break;
                    }
                    else if (i == dTable.Rows.Count - 1)
                    {
                        if (flag == false)
                        {
                            Error secondform = new Error();
                            secondform.Show();
                            break;
                        }
                    }
                }
                flag = false;
                dTable.Clear();
            }

            if (comboBox.Text == "Director")
            {
                if (login.Text == "+79118418258" || login.Text == "Director" && password.Text == "director")
                {
                    Director secondform = new Director();
                    secondform.Show();
                }
                else
                {
                    Error secondform = new Error();
                    secondform.Show();
                }
            }
            if (comboBox.Text == "Supplier")
            {
                string strSQL = "SELECT Phone FROM Suppliers WHERE (Status = 'Working')";
                dAdapter = new OleDbDataAdapter(strSQL, strConn);
                dAdapter.Fill(dSet, "Suppliers");
                dTable = dSet.Tables["Suppliers"];
                bool flag = false;
                for (int i = 0; i <= dTable.Rows.Count - 1; i++)
                {
                    if (login.Text == dTable.Rows[i][0].ToString() && password.Text == "supplier")
                    {
                        Supplier secondform = new Supplier();
                        secondform.Show();
                        flag = true;
                        break;
                    }
                    else if (i == dTable.Rows.Count - 1)
                    {
                        if (flag == false)
                        {
                            Error secondform = new Error();
                            secondform.Show();
                            break;
                        }
                    }
                }
                dTable.Clear();
            }
            if (comboBox.Text == "Customer")
            {
                string strSQL = "SELECT Phone FROM Customers";
                dAdapter = new OleDbDataAdapter(strSQL, strConn);
                dAdapter.Fill(dSet, "Customers");
                dTable = dSet.Tables["Customers"];
                bool flag = false;
                for (int i = 0; i <= dTable.Rows.Count - 1; i++)
                {
                    if (login.Text == dTable.Rows[i][0].ToString() && password.Text == "customer")
                    {
                        Customer secondform = new Customer();
                        secondform.Show();
                        flag = true;
                        break;
                    }
                    else if (i == dTable.Rows.Count - 1)
                    {
                        if (flag == false)
                        {
                            Error secondform = new Error();
                            secondform.Show();
                            break;
                        }
                    }
                }
                dTable.Clear();
            }
            if(comboBox.Text == "")
            {
                Error secondform = new Error();
                secondform.Show();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void login_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
