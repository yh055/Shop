using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace ShopDAL
{
    public class DBConnection
    {
        public List<Customer> GetAllCustomer()
        {
            string conStr = 
                ConfigurationManager.ConnectionStrings["Shop"].ConnectionString;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = conStr;

            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "SELECT * from Customer";

            SqlDataReader reader;

            List<Customer> listOfCustomer = new List<Customer>();
            try
            {
                con.Open();

                reader = com.ExecuteReader();

                while( reader.Read())
                {
                    int id = int.Parse(reader["Id"].ToString());
                    string fname = reader["FirstName"].ToString();
                    string lname = reader["LastName"].ToString();
                    string city = reader["City"].ToString();
                    string country = reader["Country"].ToString();
                    string phone = reader["Phone"].ToString();
                    var newCustomer = new Customer(id, fname,lname, city, country,phone);
                    listOfCustomer.Add(newCustomer);
                }
            }
            catch(Exception ex)
            {

            }
            return listOfCustomer;
        }
        //string filePath = Directory.GetCurrentDirectory() + @"\..\..\..\Src\BookList.txt";
        //public List<BookDetails> ReadAllBooks()
        //{
        //    var allLines = File.ReadAllLines(filePath);
        //    List<BookDetails> listOfBooks = new List<BookDetails>();
        //    foreach (var text in allLines)
        //    {
        //        string [] detailsAsString = text.Split(',');
        //        int id = int.Parse(detailsAsString[0]);
        //        string name = detailsAsString[1];
        //        int price = int.Parse(detailsAsString[2]);
        //        int numberOfPages = int.Parse(detailsAsString[3]);
        //        int minAge = int.Parse(detailsAsString[4]);
        //        int maxAge = int.Parse(detailsAsString[5]);
        //        bool isComics = bool.Parse(detailsAsString[6]);
        //        var newBook = new BookDetails(id, name, price, numberOfPages,
        //            minAge, maxAge, isComics);
        //        listOfBooks.Add(newBook);
        //    }
        //    return listOfBooks;
        //}
    }
}
