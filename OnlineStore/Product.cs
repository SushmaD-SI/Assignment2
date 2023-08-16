using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OnlineStore
{
    internal class Product
    {
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }   
        public  int QuantityInStock { get; set; }

        public string Category { get; set; }

        public int TotalPrice { get; set; }

        public Product( string productname , int productprice , int quantityinstock , string category ,int totalprice) 
        {
            ProductName = productname;
            ProductPrice = productprice;
            QuantityInStock = quantityinstock;
            Category = category;
            TotalPrice = totalprice;
        }

        public double CalPrice()
        {
            TotalPrice =ProductPrice * QuantityInStock;
            return TotalPrice;
        }
        public void Display_Details()
        {
            Console.WriteLine("*********** Online Store Details **********");
            Console.WriteLine($"The name of the product is             :{ProductName}");
            Console.WriteLine($"The price of the product is            :{ProductPrice}");
            Console.WriteLine($"The Quantity of the product is         :{QuantityInStock}");
            Console.WriteLine($"The total price of all the product is  :{CalPrice()}");
        }


    }
}
