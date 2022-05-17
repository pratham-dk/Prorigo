using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_WinForm.day09052022
{
    public partial class EmployeeADOFormAssi : Form
    {
        EmployeeDAL empDAL = new EmployeeDAL();
        public EmployeeADOFormAssi()
        {
            InitializeComponent();
        }
        public void ClearAll()
        {
            txtEmpId.Clear();
            txtEmpName  .Clear();
            txtDesignation.Clear();
            txtSalary.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                emp.EmpId = Convert.ToInt32(txtEmpId.Text);
                emp.EmpName = txtEmpName.Text;
                emp.Designation = txtDesignation.Text;
                emp.Salary = Convert.ToSingle(txtSalary.Text);
                int res = empDAL.SaveEmp(emp);
                if (res == 1)
                {
                    MessageBox.Show("Data Inserted");
                    txtEmpId.Enabled = true;
                    ClearAll();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                emp.EmpId = Convert.ToInt32(txtEmpId.Text);
                emp.EmpName = txtEmpName.Text;
                emp.Designation = txtDesignation.Text;
                emp.Salary = Convert.ToSingle(txtSalary.Text);
                int res = empDAL.UpdateEmp(emp);
                if (res == 1)
                {
                    MessageBox.Show("Data Updated");
                    txtEmpId.Enabled = true;
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
                Employee emp = new Employee();
                emp.EmpId = Convert.ToInt32(txtEmpId.Text);
               
                int res = empDAL.DeleteEmp(emp);
                if (res == 1)
                {
                    MessageBox.Show("Data Deleted");
                    txtEmpId.Enabled = true;
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
              Employee emp = empDAL.GetEmployeeByEmpId(Convert.ToInt32(txtEmpId.Text));
                txtEmpName.Text = emp.EmpName;
                txtDesignation.Text = emp.Designation.ToString();
                txtSalary.Text = emp.Salary.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
