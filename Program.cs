using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment1 Question1 ");
            A1Q1 obj1=new A1Q1();
            obj1.function1();
            Console.ReadLine();
            Console.WriteLine("Assignment1 Question2 ");
            A1Q2 obj2=new A1Q2();
            obj2.function1();
            Console.ReadLine();

        }
    }

    class A1Q1
    {
        private int num;
        public void function1()
        {
            Console.WriteLine("Function1 of Class Q1A1");
        }

    }

    class A1Q2
    {
        private int num;
        public void function1()
        {
            Console.WriteLine("Function1 of Class Q1A2");
        }

    }
}
