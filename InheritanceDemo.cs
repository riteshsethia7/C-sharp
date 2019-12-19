using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Dimen
    {
        public int width, height,length;
        public void setdim(int w,int h)
        {
            width = w;
            height = h;
        } 
        // Method overloading with differtent parameters
        public void setdim(int l)
        {
            length = l;
        }
    }
    // hierarichal inheritance 
    class Rect: Dimen
    {
        public int getarea()
        {
            return (width * height);
        }
    }
    // hierarichal inheritance 
    class Square : Dimen
    {
        public int are;
        public int getarea()
        {
            are = length * length;
            return are;
        }
    }

    class Cube : Square
    {
        public int cu,areaa;
        public int getcube()
        {
            areaa = getarea();
            cu = areaa * length;
            return cu;
        }
       
    }
    // multiple inheritance interfaces
    interface M1
    {
        void Length();
    }
    interface M2
    {
        void Width();
    }
    // multiple inheritance class
    class Multiple : M1, M2
    {
        public int len, wid;
        public void Length()
        {
            len = 60;
        }
        public void Width()
        {
            wid = 80;
        }
        public int area()
        {
            return (len * wid);
        }
    }
    class InheritanceDemo
    {
        static void Main(String[] args)
        {
            Rect re = new Rect();
            Square sq = new Square(); // heirarichal inheritance
            Cube cu = new Cube(); // multi-level inheritance
            Multiple mu = new Multiple();//Multiple inheritance
            re.setdim(50, 60);//sets width 50 and height 60
            sq.setdim(30);//sets length as 30
            cu.setdim(40);//sets length as 40
            mu.Length();//length for M1 interface
            mu.Width();//width  for M2 interface
            Console.WriteLine("Area of rectangle is : " + re.getarea());
            Console.WriteLine("Area of Square using heirarichal inheritance is : " + sq.getarea());
            Console.WriteLine("Area of Cube using multi level inheritance is : " + cu.getcube());
            Console.WriteLine("Area using multiple inheritance is : " + mu.area());
        }
    } 
}
