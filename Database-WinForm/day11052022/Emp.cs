using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_WinForm.day11052022
{
    public partial class Emp : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommandBuilder scb;
        DataSet ds;
        public Emp()
        {
            InitializeComponent();
            string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            conn = new SqlConnection(constr);
        }

        public DataSet GetEmps()
        {
            da = new SqlDataAdapter("select * from Employee1", conn);
            // apply PK contrainst to the col which is in Dataset table.
            // Id -> Pk in the DB same apply PK to Id col which is in the DataSet
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            // commandbuilder track dataset table & generate sql query that will be pass to the 
            // dataadapter object
            scb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "emp");// emp is a name given to DataTable which is in DataSet
            return ds;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            ds = GetEmps();
            DataRow row = ds.Tables["emp"].NewRow();
            row["EmpName"] = txtEmpName.Text;
            row["Designation"] = txtDesignation.Text;
            row["Salary"] = txtSalary.Text;

            ds.Tables["emp"].Rows.Add(row);
            int res = da.Update(ds.Tables["emp"]);
            if(res==1)
                MessageBox.Show("Record Saved");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            double sal = Convert.ToDouble(txtSalary.Text);
            
            

                ds = GetEmps();
                // Find() method only work with PK col in the dataset
                DataRow row = ds.Tables["emp"].Rows.Find(Convert.ToInt32(txtEmpId.Text));
                if (row != null)
                {
                    row["Name"] = txtEmpName.Text;
                row["Designation"] = txtEmpName.Text;
                row["Salary"] = txtSalary.Text;
                    int res = da.Update(ds.Tables["emp"]);
                    if (res == 1)
                        MessageBox.Show("record updated");
                }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ds = GetEmps();
            // Find() method only work with PK col in the dataset
            DataRow row = ds.Tables["emp"].Rows.Find(Convert.ToInt32(txtEmpId.Text));
            if (row != null)
            {
                txtEmpName.Text = row["EmpName"].ToString();
                txtDesignation.Text = row["Designation"].ToString();
                txtSalary.Text = row["Salary"].ToString();
            }
            else
            {
                MessageBox.Show("Record not found");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ds = GetEmps();
            // Find() method only work with PK col in the dataset
            DataRow row = ds.Tables["emp"].Rows.Find(Convert.ToInt32(txtEmpId.Text));
            if (row != null)
            {
                row.Delete();
                int res = da.Update(ds.Tables["emp"]);
                if (res == 1)
                    MessageBox.Show("record deleted");
            }
            else
            {
                MessageBox.Show("Record not found");
            }
        }
    }
}
