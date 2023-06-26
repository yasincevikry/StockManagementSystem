using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace StockManagementSystem
{
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StockManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtProductName.Text == "" || txtPurchasePrice.Text == "" || txtQuantity.Text == "" 
                || txtSalePrice.Text == "" || cbCategory.SelectedIndex == -1 || cbSupplier.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                int gain = Convert.ToInt32(txtSalePrice.Text) - Convert.ToInt32(txtPurchasePrice.Text);
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO Product VALUES (@pname,@pcategory," +
                        "@pquantity,@ppurchase,@psale,@pdate,@psup,@pgain)",connection);
                    command.Parameters.AddWithValue("@pname",txtProductName.Text);
                    command.Parameters.AddWithValue("@pcategory", cbCategory.SelectedIndex.ToString());
                    command.Parameters.AddWithValue("@pquantity", txtQuantity.Text);
                    command.Parameters.AddWithValue("@ppurchase", txtPurchasePrice);
                    command.Parameters.AddWithValue("@psale", txtSalePrice.Text);
                    command.Parameters.AddWithValue("@pdate", dateTime.Value.Date);
                    command.Parameters.AddWithValue("@psup", cbSupplier.SelectedIndex);
                    command.Parameters.AddWithValue("@pgain", gain);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Product Saved!");






                    connection.Close();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
