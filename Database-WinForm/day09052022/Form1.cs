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

namespace Database_WinForm
{
    public partial class Form1 : Form
    {
        ProductDAL prodDAL = new ProductDAL();
        SqlConnection conn;
        SqlCommand cmd; 
        SqlDataReader reader;
        public Form1()
        {
            InitializeComponent();
            
        }

        public void ClearAll()
        {
            txtId.Clear();
            txtName.Clear();
            txtPrice.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                prod.Id = Convert.ToInt32(txtId.Text);
                prod.Name = txtName.Text;
                prod.Price = Convert.ToInt32(txtPrice.Text);
                int res = prodDAL.SaveProduct(prod);
                if (res == 1)
                {
                    MessageBox.Show("Data Inserted");
                    txtId.Enabled = true;
                    ClearAll();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
              Product prod = prodDAL.GetProductById(Convert.ToInt32(txtId.Text));
                txtName.Text = prod.Name;
                txtPrice.Text = prod.Price.ToString();
              
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                prod.Id = Convert.ToInt32(txtId.Text);
                prod.Name = txtName.Text;
                prod.Price = Convert.ToInt32(txtPrice.Text);
                int res = prodDAL.UpdateProduct(prod);
               if (res == 1)
                {
                    MessageBox.Show("Data Updated");
                    ClearAll();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                prod.Id = Convert.ToInt32(txtId.Text);
                int res = prodDAL.DeleteProduct(prod);
                if (res == 1)
                {
                    MessageBox.Show("Data Deleted");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select max(Id) from Product";
                cmd = new SqlCommand(qry, conn);
              
                conn.Open();
                object obj = cmd.ExecuteScalar();
                if (obj == DBNull.Value)
                {
                    txtId.Text = "1";
                }
                else
                {
                    int id = Convert.ToInt32(obj);
                    id++;
                    txtId.Text = id.ToString(); 
                }

                txtId.Enabled = false;
                txtName.Clear();
                txtPrice.Clear();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnShowAllProducts_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from Product";
                cmd = new SqlCommand(qry, conn);
              
                conn.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable table = new DataTable();
                    table.Load(reader);
                    dataGridView1.DataSource = table;
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }


        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
           txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPrice.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        } 
    }
}
