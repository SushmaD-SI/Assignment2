namespace StudentRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------MENU---------");
            Console.WriteLine("Press 1 to Add Student");
            Console.WriteLine("Press 2 to display the student details");
            Console.WriteLine("Press 3 to get GPA");
            string name;
            int choice = Convert.ToInt32(Console.ReadLine());
            List<Student> students = new List<Student>();
            Student s1 = new Student();
            School s2 = new School();
            int count = 0;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the name of the student: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter the age of the student: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the gender of the student: ");
                    string gender = Console.ReadLine();
                    Console.WriteLine("Enter the total no of courses enrolled: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("The Details of the student are: ");
                    s2.Display();
                    break;
                case 3:
                    Console.WriteLine("The Gpa for the student is: ");
                    Console.WriteLine(s2.CalculateGPA());
                    break;
                default:
                    Console.WriteLine("Entered the wrong choice");
                    break;
            }

        }
    }
}