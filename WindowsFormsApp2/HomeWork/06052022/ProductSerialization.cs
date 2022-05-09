using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using WindowsFormsApp2.day05052022;

namespace WindowsFormsApp2.HomeWork._06052022
{
    public partial class ProductSerialization : Form
    {
        FileStream fs;
        public ProductSerialization()
        {
            InitializeComponent();
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {

                // dept details accepting from the textboxes & storing in the object
                Product prod = new Product();
                prod.Id = Convert.ToInt32(txtId.Text);
                prod.Name = txtName.Text;
                prod.Price = Convert.ToDouble(prod.Price);
                prod.CategoryName = txtCategoryName.Text;   
                // default file extension is .dat file (data file) / binary file
                fs = new FileStream(@"D:\TestFolder\ProductBinaryFile", FileMode.Create, FileAccess.Write);
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs, prod);
                MessageBox.Show("Done");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {

                // dept details accepting from the textboxes & storing in the object
                Product prod = new Product();
                // default file extension is .dat file (data file) / binary file
                fs = new FileStream(@"D:\TestFolder\ProductBinaryFile", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                prod = (Product)binary.Deserialize(fs);
                txtId.Text = prod.Id.ToString();
                txtName.Text = prod.Name;
                txtPrice.Text = prod.Price.ToString();
                txtCategoryName.Text = prod.CategoryName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btnXMLWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                prod.Id = Convert.ToInt32(txtId.Text);
                prod.Name = txtName.Text;
                prod.Price = Convert.ToDouble(prod.Price);
                prod.CategoryName = txtCategoryName.Text;
                // default file extension is .dat file (data file) / binary file
                fs = new FileStream(@"D:\TestFolder\ProductXmlFile", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(Product));
                xml.Serialize(fs, prod);
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btnXMLRead_Click(object sender, EventArgs e)
        {
            try
            {

                // dept details accepting from the textboxes & storing in the object
                Product prod = new Product();
                // default file extension is .dat file (data file) / binary file
                fs = new FileStream(@"D:\TestFolder\ProductXmlFile", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Product));
                prod = (Product)xml.Deserialize(fs);
                txtId.Text = prod.Id.ToString();
                txtName.Text = prod.Name;
                txtPrice.Text = prod.Price.ToString();
                txtCategoryName.Text = prod.CategoryName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btnSOAPWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                prod.Id = Convert.ToInt32(txtId.Text);
                prod.Name = txtName.Text;
                prod.Price = Convert.ToDouble(prod.Price);
                prod.CategoryName = txtCategoryName.Text;
                // default file extension is .dat file (data file) / binary file
                fs = new FileStream(@"D:\TestFolder\ProdSOAPFile", FileMode.Create, FileAccess.Write);
                SoapFormatter soap = new SoapFormatter();
                soap.Serialize(fs, prod);
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnSOAPRead_Click(object sender, EventArgs e)
        {
            try
            {

                // dept details accepting from the textboxes & storing in the object
                Product prod = new Product();
                // default file extension is .dat file (data file) / binary file
                fs = new FileStream(@"D:\TestFolder\ProdSOAPFile", FileMode.Open, FileAccess.Read);
                SoapFormatter soap = new SoapFormatter();
                prod = (Product)soap.Deserialize(fs);
                txtId.Text = prod.Id.ToString();
                txtName.Text = prod.Name;
                txtPrice.Text = prod.Price.ToString();
                txtCategoryName.Text = prod.CategoryName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnJSONWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                prod.Id = Convert.ToInt32(txtId.Text);
                prod.Name = txtName.Text;
                prod.Price = Convert.ToDouble(prod.Price);
                prod.CategoryName = txtCategoryName.Text;
                fs = new FileStream(@"D:\TestFolder\ProductJSONFile", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, prod);
                MessageBox.Show("Done");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btnJSONRead_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                fs = new FileStream(@"D:\TestFolder\ProductJSONFile", FileMode.Open, FileAccess.Read);
                prod = JsonSerializer.Deserialize<Product>(fs);               //change here. 
                txtId.Text = prod.Id.ToString();
                txtName.Text = prod.Name;
                txtPrice.Text = prod.Price.ToString();
                txtCategoryName.Text = prod.CategoryName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }
    }
}
