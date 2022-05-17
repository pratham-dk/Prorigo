using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;


namespace Database_WinForm.day09052022
{
    public class EmployeeDAL
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;

        public EmployeeDAL()
        {
            string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            conn = new SqlConnection(constr);

        }

        public int SaveEmp(Employee emp)
        {
            string qry = "insert into Employee values(@empid,@empname,@designation,@salary)";

            cmd = new SqlCommand(qry, conn);

            cmd.Parameters.AddWithValue("@empid", emp.EmpId);
            cmd.Parameters.AddWithValue("@empname", emp.EmpName);
            cmd.Parameters.AddWithValue("@designation", emp.Designation);
            cmd.Parameters.AddWithValue("@salary", emp.Salary);

            conn.Open();

            int res = cmd.ExecuteNonQuery();
            conn.Close();
            return res;
        }

        public int UpdateEmp(Employee emp)
        {

            string qry = "update Employee set EmpName=@empname,Designation=@designation,Salary=@salary where  EmpId=@empid";

            cmd = new SqlCommand(qry, conn);

            cmd.Parameters.AddWithValue("@empid", emp.EmpId);
            cmd.Parameters.AddWithValue("@empname", emp.EmpName);
            cmd.Parameters.AddWithValue("@designation", emp.Designation);
            cmd.Parameters.AddWithValue("@salary", emp.Salary);

            conn.Open();

            int res = cmd.ExecuteNonQuery();
            conn.Close();
            return res;
        }

        public int DeleteEmp(Employee emp)
        {

            string qry = "delete from Employee where EmpId=@empid";

            cmd = new SqlCommand(qry, conn);

            cmd.Parameters.AddWithValue("@empid", emp.EmpId);
           

            conn.Open();

            int res = cmd.ExecuteNonQuery();
            conn.Close();
            return res;
        }



        public Employee GetEmployeeByEmpId(int empid)
        {
            Employee emp = new Employee();
            string qry = "select * from employee where EmpId=@empid";
            cmd = new SqlCommand(qry, conn);
            cmd.Parameters.AddWithValue("@empid",empid);
            conn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    emp.EmpId = Convert.ToInt32(dr["EmpId"]);
                    emp.EmpName = dr["EmpName"].ToString();
                    emp.Designation = dr["Designation"].ToString();
                    emp.Salary = Convert.ToSingle(dr["Salary"]);


                }
            }
            conn.Close();
            return emp;
        }
    }
}
