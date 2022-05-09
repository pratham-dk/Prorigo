using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Text.Json;
using System.Runtime.Serialization.Formatters.Soap;

namespace WindowsFormsApp2.day05052022
{
    public partial class FormForFile : Form
    {
        FileStream fs;
        public FormForFile()
        {
            InitializeComponent();
        }

        private void FormForFile_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text);
                string name = txtName.Text;
                string location = txtLocation.Text;
                fs = new FileStream(@"D:\TestFolder\TestFile.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(id);
                bw.Write(name);
                bw.Write(location);
                bw.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                fs.Close(); // free the resouce 
            }

        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\TestFolder\TestFile.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtId.Text = br.ReadInt32().ToString();
                txtName.Text = br.ReadString();
                txtLocation.Text = br.ReadString();
                br.Close();  // close the opeation reader
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close(); // free the resouce 
            }

        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {

                // dept details accepting from the textboxes & storing in the object
                FormWithFileBinaryCode dept = new FormWithFileBinaryCode();
                dept.Id = Convert.ToInt32(txtId.Text);
                dept.Name = txtName.Text;
                dept.Location = txtLocation.Text;
                // default file extension is .dat file (data file) / binary file
                fs = new FileStream(@"D:\TestFolder\Dept", FileMode.Create, FileAccess.Write);
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs, dept);
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

        private void btnBinaryRead_Click_1(object sender, EventArgs e)
        {
            try
            {

                // dept details accepting from the textboxes & storing in the object
                FormWithFileBinaryCode dept = new FormWithFileBinaryCode();
                // default file extension is .dat file (data file) / binary file
                fs = new FileStream(@"D:\TestFolder\Dept", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                dept = (FormWithFileBinaryCode)binary.Deserialize(fs);
                txtId.Text = dept.Id.ToString();
                txtName.Text = dept.Name;
                txtLocation.Text = dept.Location;
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

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\TestFolder";
                if (Directory.Exists(path))
                {
                    MessageBox.Show("Folder Already Exists");
                }
                else
                {

                    Directory.CreateDirectory(path);
                    MessageBox.Show("Folder Created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\TestFolder\TestFile.txt";
                if (File.Exists(path))
                {
                    MessageBox.Show("File Already Exists");
                }
                else
                {
                    File.Create(path);
                    MessageBox.Show("File Created ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXMLRead_Click(object sender, EventArgs e)
        {
            try
            {

                // dept details accepting from the textboxes & storing in the object
                FormWithFileBinaryCode dept = new FormWithFileBinaryCode();
                // default file extension is .dat file (data file) / binary file
                fs = new FileStream(@"D:\TestFolder\DeptXml", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(FormWithFileBinaryCode));
                dept = (FormWithFileBinaryCode)xml.Deserialize(fs);
                txtId.Text = dept.Id.ToString();
                txtName.Text = dept.Name;
                txtLocation.Text = dept.Location;
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
                FormWithFileBinaryCode dept = new FormWithFileBinaryCode();
                dept.Id = Convert.ToInt32(txtId.Text);
                dept.Name = txtName.Text;
                dept.Location = txtLocation.Text;
                // default file extension is .dat file (data file) / binary file
                fs = new FileStream(@"D:\TestFolder\DeptXml", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(FormWithFileBinaryCode));
                xml.Serialize(fs, dept);
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
                FormWithFileBinaryCode dept = new FormWithFileBinaryCode();
                // default file extension is .dat file (data file) / binary file
                fs = new FileStream(@"D:\TestFolder\SoapXml", FileMode.Open, FileAccess.Read);
               SoapFormatter soap = new SoapFormatter();
                dept = (FormWithFileBinaryCode)soap.Deserialize(fs);
                txtId.Text = dept.Id.ToString();
                txtName.Text = dept.Name;
                txtLocation.Text = dept.Location;
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
                FormWithFileBinaryCode dept = new FormWithFileBinaryCode();
                dept.Id = Convert.ToInt32(txtId.Text);
                dept.Name = txtName.Text;
                dept.Location = txtLocation.Text;
                // default file extension is .dat file (data file) / binary file
                fs = new FileStream(@"D:\TestFolder\SoapXml", FileMode.Create, FileAccess.Write);
                SoapFormatter soap = new SoapFormatter();
                soap.Serialize(fs, dept);
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

        }
    }
    }

