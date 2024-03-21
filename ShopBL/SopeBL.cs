using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopDAL;
using Entities;

namespace ShopBL
{
    public class ShopBL
    {
        List<Customer> listOfCustomer;
        DBConnection fileConnection;
        public ShopBL()
        {
            fileConnection = new DBConnection();
            listOfCustomer = fileConnection.GetAllCustomer();
        }

        public IEnumerable<Customer> GetAllCustomer()
        {
            return listOfCustomer;
        }
    }
}
