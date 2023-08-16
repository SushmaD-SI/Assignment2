namespace LibraryMangementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            Library library1 = new Library();
            do
            {
                Console.WriteLine("Enter 1 To Add The Books");
                Console.WriteLine("Enter 2 To Display The List Of Books");
                Console.WriteLine("Enter 3 To Search For Book By Title or Author");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        library1.AddBook();
                        break;
                    case 2:
                        library1.DisplayItems();
                        break;
                    case 3:
                        Console.WriteLine("Enter the title of the book to be searched: ");
                        string Find = Console.ReadLine().ToLower();
                        library1.FindBooks(Find);
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }

            } while (choice != 4);
        }
    }
}