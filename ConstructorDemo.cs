using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Student
    {
        public string name;
        public int rollno;
        //default Constructor
        public Student()
        {
            Console.WriteLine("Default Constructor");
        }
        //parameterized Constructor
        public Student(string n, int r)
        {
            name = n;
            rollno = r;               
        }
        //Copy constructor
        public Student(Student ab)
        {
            name = ab.name;
            rollno = ab.rollno;
        }
        public void printdetails()
        {
            Console.WriteLine("Details are :" + name + " - " + rollno);
        }
        //Deconstructor 
         ~Student()
        {
            Console.WriteLine("Deconstructor was called");//gets executed automatically
        }
    }
    class ConstructorDemo
    {
        public static void Main(String[] args)
        {
            Student s = new Student();//default constructor instance
            Student s1 = new Student("Ritesh",38);//parametrized constructor instance
            Student s2 = new Student(s1);//copy constructor instance 
            s.printdetails();
            s2.printdetails();
                      
        }
    }
    
}
