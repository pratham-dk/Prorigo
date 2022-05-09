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

namespace WindowsFormsApp2
{
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            string a = idtextBox.Text;
            string b = nametextBox.Text;
            string c = authortextBox.Text;
            string d = pricetextBox.Text;

            label1.Text = a + "   " + b + "    " + c + "   " + d;
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void binarywriterbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Book1 dept = new Book1();
                dept.Id =Convert.ToInt32(idtextBox.Text);
                dept.Name = nametextBox.Text;
                dept.Aname =authortextBox.Text;
                dept.Price =Convert.ToInt32(pricetextBox.Text);
                FileStream fs = new FileStream(@"D:\Employee Info\binarybookinformation", FileMode.Create, FileAccess.Write);
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs, dept);
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void binaryreaderbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Book1 dept = new Book1();

                FileStream fs = new FileStream(@"D:\Employee Info\binarybookinformation", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                idtextBox.Text = dept.Id.ToString();
                nametextBox.Text = dept.Name;
                authortextBox.Text = dept.Aname;
                pricetextBox.Text = dept.Price.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void xmlwriterbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Book1 dept = new Book1();
                dept.Id =Convert.ToInt32(idtextBox.Text);
                dept.Name =nametextBox.Text;
                dept.Aname =authortextBox.Text;
                dept.Price =Convert.ToInt32(pricetextBox.Text);
                FileStream fs = new FileStream(@"D:\Employee Info\xmlbookinformation", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(Book1));
                xml.Serialize(fs, dept);
                MessageBox.Show("Done");
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void xmlreaderbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Book1 dept = new Book1();

                FileStream fs = new FileStream(@"D:\Employee Info\xmlbookinformation", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Book1));
                dept = (Book1)xml.Deserialize(fs);
                idtextBox.Text = dept.Id.ToString();
                nametextBox.Text = dept.Name;
                authortextBox.Text = dept.Aname;
                pricetextBox.Text = dept.Price.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void soapwriterbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Book1 dept = new Book1();
                dept.Id =Convert.ToInt32(idtextBox.Text);
                dept.Name = nametextBox.Text;
                dept.Aname =authortextBox.Text;
                dept.Price = Convert.ToInt32(pricetextBox.Text);
                FileStream fs = new FileStream(@"D:\Employee Info\soapbookinformation", FileMode.Create, FileAccess.Write);
                SoapFormatter soap = new SoapFormatter();
                soap.Serialize(fs, dept);
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void soapreaderbutton_Click(object sender, EventArgs e)
        {
            try
            {
                 Book1 dept = new Book1();

                FileStream fs = new FileStream(@"D:\Employee Info\soapbookinformation", FileMode.Open, FileAccess.Read);
                SoapFormatter soap = new SoapFormatter();
                idtextBox.Text = dept.Id.ToString();
                nametextBox.Text = dept.Name;
                authortextBox.Text = dept.Aname;
                pricetextBox.Text = dept.Price.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void jsonwriterbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Book1 dept = new Book1();
                dept.Id = Convert.ToInt32(idtextBox.Text);
                dept.Name = nametextBox.Text;
                dept.Aname =authortextBox.Text;
                dept.Price =Convert.ToInt32(pricetextBox.Text);

                FileStream fs = new FileStream(@"D:\Employee Info\jsonbookInformation", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, dept);
                MessageBox.Show("Done");
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void jsonreaderbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Book1 dept = new Book1();
                FileStream fs = new FileStream(@"D:\Employee Info\jsonbookinformation", FileMode.Open, FileAccess.Read);
                dept = JsonSerializer.Deserialize<Book1>(fs);               //change here. 
                idtextBox.Text = dept.Id.ToString();
                nametextBox.Text = dept.Name;
                authortextBox.Text = dept.Aname;
                pricetextBox.Text = dept.Price.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
