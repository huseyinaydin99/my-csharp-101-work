using _021_Ado_Net_Demo.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace _021_Ado_Net_Demo.Data
{
    public class ProductDal
    {
        public SqlConnection GetSqlConnection()
        {
            SqlConnection sqlConnection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true");
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            return sqlConnection;
        }
        public List<Product> GetAll()
        {
            SqlConnection sqlConnection = this.GetSqlConnection();
            ConnectionControl(sqlConnection);
            SqlCommand sqlCommand = new SqlCommand("select * from Product", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<Product> products = new List<Product>();
            while (sqlDataReader.Read())
            {
                Product product = new Product()
                {
                    Id = Convert.ToInt32(sqlDataReader["Id"]),
                    Name = sqlDataReader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(sqlDataReader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(sqlDataReader["UnitPrice"])
                };
                products.Add(product);
            }

            sqlDataReader.Close();
            sqlConnection.Close();
            return products;
        }

        private static void ConnectionControl(SqlConnection sqlConnection)
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public DataTable GetAll2()
        {
            SqlConnection sqlConnection = this.GetSqlConnection();
            ConnectionControl(sqlConnection);
            SqlCommand sqlCommand = new SqlCommand("select * from Product", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            sqlDataReader.Close();
            sqlConnection.Close();
            return dataTable;
        }

        public bool Add(Product product)
        {
            bool returnResult = false;
            SqlConnection sqlConnection = this.GetSqlConnection();
            ConnectionControl(sqlConnection);
            string sql = "insert into Product values(@name,@unitprice,@stockamount)";
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@name",product.Name);
            sqlCommand.Parameters.AddWithValue("@unitprice", product.UnitPrice);
            sqlCommand.Parameters.AddWithValue("@stockamount", product.StockAmount);
            int result = sqlCommand.ExecuteNonQuery();
            if (result >= 1)
                returnResult = true;
            sqlConnection.Close();
            return returnResult;
        }

        public bool Update(Product product)
        {
            bool returnResult = false;
            SqlConnection sqlConnection = this.GetSqlConnection();
            ConnectionControl(sqlConnection);
            string sql = "update Product set Name=@name,UnitPrice=@unitprice,stockamount=@stockamount where Id=@id";
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@name", product.Name);
            sqlCommand.Parameters.AddWithValue("@unitprice", product.UnitPrice);
            sqlCommand.Parameters.AddWithValue("@stockamount", product.StockAmount);
            sqlCommand.Parameters.AddWithValue("@id",product.Id);
            int result = sqlCommand.ExecuteNonQuery();
            if (result >= 1)
                returnResult = true;
            sqlConnection.Close();
            return returnResult;
        }

        public bool Delete(int id)
        {
            bool returnResult = false;
            SqlConnection sqlConnection = this.GetSqlConnection();
            ConnectionControl(sqlConnection);
            string sql = "delete from Product where Id=@id";
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@id", id);
            int result = sqlCommand.ExecuteNonQuery();
            if (result >= 1)
                returnResult = true;
            sqlConnection.Close();
            return returnResult;
        }
    }
}
