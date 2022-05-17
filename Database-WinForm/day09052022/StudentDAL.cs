using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;


namespace Database_WinForm.day09052022
{

    public class StudentDAL
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;

        public StudentDAL()
        {
            string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            conn = new SqlConnection(constr);

        }

        public int SaveStudent(Student stud)
        {
            string qry = "insert into Student values(@rollno,@name,@branch,@percentage)";

            cmd = new SqlCommand(qry, conn);

            cmd.Parameters.AddWithValue("@rollno", stud.RollNo);
            cmd.Parameters.AddWithValue("@name", stud.Name);
            cmd.Parameters.AddWithValue("@branch", stud.Branch);
            cmd.Parameters.AddWithValue("@percentage", stud.Percentage);

            conn.Open();

            int res = cmd.ExecuteNonQuery();
            conn.Close();
            return res;
        }

        public int UpdateStudent(Student stud)
        {
            string qry = "update Student  set Name=@name,Branch=@branch,Percentage=@percentage where RollNo=@rollno";

            cmd = new SqlCommand(qry, conn);


            cmd.Parameters.AddWithValue("@rollno", stud.RollNo);
            cmd.Parameters.AddWithValue("@name", stud.Name);
            cmd.Parameters.AddWithValue("@branch", stud.Branch);
            cmd.Parameters.AddWithValue("@percentage", stud.Percentage);

            conn.Open();

            int res = cmd.ExecuteNonQuery();
            conn.Close();
            return res;
           
        }

        public int DeleteStudent(Student stud)
        {
            string qry = "delete from Student where RollNo=@rollno";

            cmd = new SqlCommand(qry, conn);


            cmd.Parameters.AddWithValue("@rollno", stud.RollNo);
            

            conn.Open();

            int res = cmd.ExecuteNonQuery();

            conn.Close();
            return res;
           
        }

        public Student GetStudentByRollNo(int rollno)
        {
            Student stud = new Student();   
            string qry = "select * from Student where RollNo=@rollno";
            cmd = new SqlCommand(qry, conn);
            cmd.Parameters.AddWithValue("@rollno", rollno);
            conn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    stud.RollNo = Convert.ToInt32(dr["RollNo"]);
                    stud.Name = dr["Name"].ToString();
                    stud.Branch = dr["Branch"].ToString();
                    stud.Percentage = Convert.ToSingle(dr["Percentage"]);


                }
            }
            conn.Close();
            return stud;
        }

    }
}
