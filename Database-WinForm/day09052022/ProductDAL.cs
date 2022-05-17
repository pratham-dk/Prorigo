using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Database_WinForm
{
    public class ProductDAL
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;

        public ProductDAL()
        {
            string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            conn = new SqlConnection(constr);

        }
        
        public int SaveProduct(Product prod)
        {

            string qry = "insert into Product values(@id,@name,@price)";

            cmd = new SqlCommand(qry, conn);

            cmd.Parameters.AddWithValue("@id", prod.Id);
            cmd.Parameters.AddWithValue("@name", prod.Name);
            cmd.Parameters.AddWithValue("@price", prod.Price);

            conn.Open();

            int res = cmd.ExecuteNonQuery();
            conn.Close();
            return res;
        }


        public Product GetProductById(int id)
        {
            Product prod = new Product();
            string qry = "select * from Product where Id=@id";
            cmd = new SqlCommand(qry, conn);
            cmd.Parameters.AddWithValue("@id",id);
            conn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    prod.Id = Convert.ToInt32(dr["Id"]);
                    prod.Name= dr["Name"].ToString();
                    prod.Price = Convert.ToInt32(dr["Price"]);

                }
            }
            conn.Close();
            return prod;

        }


        public int UpdateProduct(Product prod)
        {
            string qry = "update Product set Name=@name,Price=@price where Id=@id";

            cmd = new SqlCommand(qry, conn);


            cmd.Parameters.AddWithValue("@id", prod.Id);
            cmd.Parameters.AddWithValue("@name", prod.Name);
            cmd.Parameters.AddWithValue("@price", prod.Price);

            conn.Open();

            int res = cmd.ExecuteNonQuery();
            return res;
            conn.Close();
        }


        public int DeleteProduct(Product prod)
        {
            string qry = "delete from Product where Id=@id";

            cmd = new SqlCommand(qry, conn);

            cmd.Parameters.AddWithValue("@id", prod.Id);
           
            conn.Open();

            int res = cmd.ExecuteNonQuery();
            return res;
            conn.Close() ;

        }
    }
}
