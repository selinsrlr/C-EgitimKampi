using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CRUD -> create-read-update-delete

            Console.WriteLine("**** Menü Sipariş İşlem Paneli ****");
            Console.WriteLine();

            Console.WriteLine("------------------------");

            #region Kategori Ekleme İşlemi
            //Console.WriteLine("Eklemek istediğiniz kategori adı: ");
            //string categoryName = Console.ReadLine();   

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-VAE0PLA\\SQLEXPRESS; initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCategory (categoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori başarıyla eklendi.");
            #endregion

            #region Ürün Ekleme İşlemi
            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-VAE0PLA\\SQLEXPRESS; initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName, ProductPrice, ProductStatus) values(@p1,@p2,@p3)", connection);
            //command.Parameters.AddWithValue("@p1", productName);
            //command.Parameters.AddWithValue("@p2", productPrice);
            //command.Parameters.AddWithValue("@p3", true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Ürün eklemesi başarılı");

            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-VAE0PLA\\SQLEXPRESS; initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);

            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");

            //    }
            //    Console.WriteLine();

            //}

            //connection.Close();

            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün ID: ");
            //int productID = int.Parse(Console.ReadLine());  

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-VAE0PLA\\SQLEXPRESS; initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct where ProductID=@productID", connection);
            //command.Parameters.AddWithValue("@productID", productID);
            //command.ExecuteNonQuery();

            //connection.Close();
            //Console.WriteLine("Silme İşlemi Başarılı.");

            #endregion

            #region Ürün Güncelleme İşlemi

            Console.Write("Güncellenecek ürün id: ");
            int productID = int.Parse(Console.ReadLine());
            
            Console.Write("Ürün adı: ");
            string productName = Console.ReadLine();
            
            Console.Write("Ürün Fiyatı: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-VAE0PLA\\SQLEXPRESS; initial catalog=EgitimKampiDb;integrated security=true");
            connection.Open();

            SqlCommand command = new SqlCommand("Update TblProduct set ProductName=@productName, ProductPrice=@productPrice where ProductID=@productID", connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice); 
            command.Parameters.AddWithValue("@productID", productID); 
            command.ExecuteNonQuery();

            connection.Close();
            Console.WriteLine("Güncelleme başarılı");


            #endregion

            Console.Read();

        }
    }
}
