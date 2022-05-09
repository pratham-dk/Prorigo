using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.HomeWork._06052022
{
    public partial class BatchInfo : Form
    {
        FileStream fs;
        public BatchInfo()
        {
            InitializeComponent();
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                int batchid = Convert.ToInt32(txtBatchId.Text);
                string batchname = txtBatchName.Text;
                string startdate = txtStartDate.Text;
                string enddate = txtEndDate.Text;
                string trainername = txtTrainerName.Text;
                string Location = txtLocation.Text;
                fs = new FileStream(@"D:\TestFolder\BatchBinary.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(batchid);
                bw.Write(batchname);
                bw.Write(trainername);
                bw.Write(startdate);
                bw.Write(enddate);
                bw.Write(Location);
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

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\TestFolder\BatchBinary.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtBatchId.Text = br.ReadInt32().ToString();
                txtBatchName.Text = br.ReadString();
                txtStartDate.Text = br.ReadString();
                txtEndDate.Text = br.ReadString();
                txtTrainerName.Text = br.ReadString();
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
    }
}
