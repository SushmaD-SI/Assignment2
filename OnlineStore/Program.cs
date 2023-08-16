
namespace OnlineStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            Store store = new Store();
            do
            {
                Console.WriteLine("Enter 1 to enter the store ");
                Console.WriteLine("Enter 2 to display the store items ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        store.AddProducts();
                        break;
                    case 2:
                        store.DisplayProducts();
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            } while (choice != 0);
        }
    }
}