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
        SqlConnection conn;
        SqlCommand cmd; 
        SqlDataReader reader;
        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Server=DARKBOOK\SQLEXPRESS;database=ProrigoAssi;Integrated Security=True");     
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "insert into Product values(@id,@name,@price)";

                cmd = new SqlCommand(qry, conn);    

                cmd.Parameters.AddWithValue("@id",Convert.ToInt32(txtId.Text));
                cmd.Parameters.AddWithValue("@name",txtName.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToInt32(txtPrice.Text));

                conn.Open();

                int res = cmd.ExecuteNonQuery();
                if(res == 1)
                {
                    MessageBox.Show("Data Inserted");
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from Product where Id=@id";
                cmd = new SqlCommand(qry, conn);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                conn.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtName.Text = reader["Name"].ToString();
                        txtPrice.Text = reader["Price"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "update Product set Name=@name,Price=@price where Id=@id";

                cmd = new SqlCommand(qry, conn);

                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToInt32(txtPrice.Text));

                conn.Open();

                int res = cmd.ExecuteNonQuery();
                if (res == 1)
                {
                    MessageBox.Show("Data Updated");
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "delete from Product where Id=@id";

                cmd = new SqlCommand(qry, conn);

                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
               

                conn.Open();

                int res = cmd.ExecuteNonQuery();
                if (res == 1)
                {
                    MessageBox.Show("Data Deleted");
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
    }
}
