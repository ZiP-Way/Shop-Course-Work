using Shop.Tools;
using System.Data.OleDb;

namespace Shop
{
    class DBController
    {
        private static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Shop.mdb";
        private static OleDbConnection myConnection;

        public static void DBConnection()
        {
            myConnection = new OleDbConnection(connectString);
        }

        public static void InsertToDb(Product product)
        {
            string query = $"INSERT INTO [Products] ([p_name],[p_price],[p_img],[p_type],[p_brand]) VALUES (?, ?, ?, ?, ?)";

            using (OleDbCommand command = new OleDbCommand(query, myConnection))
            {
                myConnection.Open();

                command.Parameters.Add(new OleDbParameter("@p_name", product.Name));
                command.Parameters.Add(new OleDbParameter("@p_price", product.Price));

                OleDbParameter param = command.Parameters.AddWithValue("@p_img", System.Data.SqlDbType.Binary);
                byte[] binaryImg = ImageConverter.ConvertImgToByte(product.Image); 
                param.Value = binaryImg;
                param.Size = binaryImg.Length;

                command.Parameters.Add(new OleDbParameter("@p_type", product.Type));
                command.Parameters.Add(new OleDbParameter("@p_brand", product.Brand));

                command.ExecuteNonQuery();

                myConnection.Close();
            }
        }

        public static int GetProductId(Product product)
        {
            int id = 0;
            string query = $"SELECT p_id FROM Products WHERE p_name = ?";

            using (OleDbCommand command = new OleDbCommand(query, myConnection))
            {
                myConnection.Open();

                command.Parameters.Add(new OleDbParameter("p_name", product.Name));
                id = (int)command.ExecuteScalar();

                myConnection.Close();
            }

            return id;
        }
        
        public static void UpdateFieldDb(Product product)
        {
            string query = $"UPDATE Products SET p_name = ?, p_price = ?, p_img = ?, p_type = ?, p_brand = ? WHERE p_id = ?";

            using (OleDbCommand command = new OleDbCommand(query, myConnection))
            {
                myConnection.Open();

                command.Parameters.Add(new OleDbParameter("p_name", product.Name));
                command.Parameters.Add(new OleDbParameter("p_price", product.Price));

                OleDbParameter param = command.Parameters.AddWithValue("p_img", System.Data.SqlDbType.Binary);
                byte[] binaryImg = ImageConverter.ConvertImgToByte(product.Image);
                param.Value = binaryImg;
                param.Size = binaryImg.Length;

                command.Parameters.Add(new OleDbParameter("p_type", product.Type));
                command.Parameters.Add(new OleDbParameter("p_brand", product.Brand));
                command.Parameters.Add(new OleDbParameter("p_id", product.ID));

                command.ExecuteNonQuery();

                myConnection.Close();
            }
        }

        public static void DeleteFromDb(int id)
        {
            string query = $"DELETE FROM Products WHERE p_id = {id}";

            using (OleDbCommand command = new OleDbCommand(query, myConnection))
            {
                myConnection.Open();

                command.ExecuteNonQuery();

                myConnection.Close();
            }
        }

        public static Product[] GetProductsFromDb()
        {
            Product[] products = new Product[GetNumberOfRows()];

            int index = 0;
            string query = "SELECT * FROM Products ORDER BY p_id";

            using (OleDbCommand command = new OleDbCommand(query, myConnection))
            {
                myConnection.Open();

                OleDbDataReader oReader = command.ExecuteReader();
                while (oReader.Read())
                {
                    products[index].ID = (int)oReader["p_id"];
                    products[index].Name = (string)oReader["p_name"];
                    products[index].Price = (int)oReader["p_price"];
                    products[index].Image = ImageConverter.ConvertBytesToImg((byte[])oReader["p_img"]);
                    products[index].Type = (string)oReader["p_type"];
                    products[index].Brand = (string)oReader["p_brand"];

                    index++;
                }

                myConnection.Close();
            }

            return products;
        }

        private static int GetNumberOfRows()
        {
            string query = "SELECT COUNT(*) FROM Products";
            int numOfRows;

            using(OleDbCommand command = new OleDbCommand(query, myConnection))
            {
                myConnection.Open();

                numOfRows = (int)command.ExecuteScalar();

                myConnection.Close();
            }

            return numOfRows;
        }
    }
}
