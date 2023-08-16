using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecord
{
    internal class School
    {
        List<Student> student;
        Student Sm = new Student();
        public School() { }

        public void Display(string name)
        {
            foreach (Student s in student)
            {
                if (name == s.Name)
                {
                    Console.WriteLine(s);
                }
                else
                {
                    Console.WriteLine("You have entered a wrong name");
                }


            }
        }
        public void Display() { }
        public int CalculateGPA()
        {
            int AggGrade = 0;
            int count = 0;
            foreach (char s in Sm.CourseGrade)
            {
                count++;
                switch (s)
                {
                    case 'A':
                        AggGrade += 4;
                        break;
                    case 'B':
                        AggGrade += 3;
                        break;
                    case 'C':
                        AggGrade += 2;
                        break;
                    case 'D':
                        AggGrade += 1;
                        break;
                    case 'E':
                        AggGrade += 0;
                        break;

                }
            }

            return (AggGrade / count);
        }

    }
}


