using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6_1
{
    class Numbers
    {
        private int NumOne;
        private int NumTwo;

        public Numbers()
        {

        }

        public Numbers(int Num1)
        {
            NumOne = Num1;
        }

        public Numbers(int Num1, int Num2)
        {
            NumOne = Num1;
            NumTwo = Num2;
        }

        public void Display()
        {
            Console.WriteLine($"{NumOne} {NumTwo}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Numbers num = new Numbers();
            num.Display();
            Numbers num1 = new Numbers(1);
            num1.Display();
            Numbers num2 = new Numbers(2, 3);
            num2.Display();

            Console.ReadLine();
        }
    }
}
