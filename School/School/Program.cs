using System;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Course
    {
        string courseName;
        string instructor;
        List<string> textbooks = new List<string>();

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }
        public string Instructor
        {
            get { return instructor; }
            set { instructor = value; }
        }
        public List<string> Textbooks
        {
            get { return textbooks; }
            set { textbooks = value; }
        }

    }
    public class Student
    {
        string name;
        int studentId;
        int numberOfCredits = 0;
        double gpa = 0;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }
        public int NumberOfCredits
        {
            get { return numberOfCredits; }
            set { numberOfCredits = value; }
        }
        public double Gpa
        {
            get { return gpa; }
            set { gpa = value; }
        }

    }
    

}
