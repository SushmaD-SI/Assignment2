using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecord
{
    internal class Student
    {
        string name;
        int age;
        string gender;
        List<char> coursegrade;

        public Student(string Name, int Age, string Gender, List<string> CourseGrade)
        {
            this.name = Name;
            this.age = Age;
            this.gender = Gender;
            List<char> courseGrade = new List<char>();
        }
        public Student() { }

        public string Name
        {
            get;
            set;
        }
        public int Age
        { get; set; }

        public string Gender
        { get; set; }

        public List<char> CourseGrade
        { get; set; }
        public int gpa { get; set; }
    }
}
