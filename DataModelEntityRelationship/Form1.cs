using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataModelEntityRelationship
{
    public partial class Form1 : Form
    {
      ApplicationEntities dbcontext = new ApplicationEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                emp.EmpName = txtEmpName.Text;
                emp.Designation=txtDesignation.Text;
                emp.Salary = Convert.ToDouble(txtSalary.Text);   
                
                dbcontext.Employees.Add(emp);   
                dbcontext.SaveChanges();
                MessageBox.Show("Done");

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
                Employee emp = dbcontext.Employees.Find(Convert.ToInt32(txtEmpId.Text));
                if (emp != null)
                {
                    emp.EmpName = txtEmpName.Text;
                    emp.Designation = txtDesignation.Text;
                    emp.Salary = Convert.ToDouble(txtSalary.Text);
                    dbcontext.SaveChanges();
                    MessageBox.Show("updated");
                }
                else
                {
                    MessageBox.Show("Record not found");
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
                Employee emp = dbcontext.Employees.Find(Convert.ToInt32(txtEmpId.Text));
                if (emp != null)
                {
                    txtEmpName.Text = emp.EmpName;
                    txtDesignation.Text = emp.Designation;
                    txtSalary.Text = emp.Salary.ToString();
                }
                else
                {
                    MessageBox.Show("Record not found");
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
                Employee emp = dbcontext.Employees.Find(Convert.ToInt32(txtEmpId.Text));
                if (emp != null)
                {
                    dbcontext.Employees.Remove(emp);
                    dbcontext.SaveChanges();
                    MessageBox.Show("deleted");
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbcontext.Employees.ToList();
        }
    }
}
