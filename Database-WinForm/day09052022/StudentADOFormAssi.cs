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
    public partial class StudentADOFormAssi : Form
    {
        StudentDAL studDAL = new StudentDAL();
        public StudentADOFormAssi()
        {
            InitializeComponent();
        }

        public void ClearAll()
        {
            txtRollNo.Clear();
            txtName.Clear();
            txtBranch.Clear();
           txtPercentage.Clear();   
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
               Student stud = new Student();
                stud.RollNo = Convert.ToInt32(txtRollNo.Text);
                stud.Name = txtName.Text;
                stud.Branch = txtBranch.Text;
                stud.Percentage = Convert.ToInt32(txtPercentage.Text);
                int res = studDAL.SaveStudent(stud);
                if (res == 1)
                {
                    MessageBox.Show("Data Inserted");
                    txtRollNo.Enabled = true;
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
                Student stud = new Student();
                stud.RollNo = Convert.ToInt32(txtRollNo.Text);
                stud.Name = txtName.Text;
                stud.Branch = txtBranch.Text;
                stud.Percentage = Convert.ToInt32(txtPercentage.Text);
                int res = studDAL.UpdateStudent(stud);
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
                Student stud = new Student();
                stud.RollNo = Convert.ToInt32(txtRollNo.Text);
            
                int res = studDAL.DeleteStudent(stud);
                if (res == 1)
                {
                    MessageBox.Show("Data Deleted");
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
                Student stud = studDAL.GetStudentByRollNo(Convert.ToInt32(txtRollNo.Text));
                txtName.Text = stud.Name;
                txtBranch.Text = stud.Branch.ToString();
                txtPercentage.Text = stud.Percentage.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
