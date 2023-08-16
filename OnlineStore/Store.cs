using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    internal class Store
    {
        List <Product> prod =new List <Product> ();
        double totalprice = 0;
        
        public void AddProducts()
        {
            Console.WriteLine("Enter the name of the product: ");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the price of the product: ");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Quantity of the product: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Category of the product: ");
            string category = Convert.ToString(Console.ReadLine());

            int totalprice = price*quantity;

            Product newItem = new Product(name, price, quantity, category,totalprice);
            prod.Add(newItem);
            this.totalprice = price * quantity;
        }

        public void DisplayProducts()
        {
            foreach (var Prod in prod)
            {
                Prod.Display_Details();
            }
        }

        

    }
}
