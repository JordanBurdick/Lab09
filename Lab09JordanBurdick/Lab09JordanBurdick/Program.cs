using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09JordanBurdick
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath MJ = new MyMath();

            MJ.Divide(12, 3);
            Console.WriteLine(MJ.getResult());
            MJ.Add(2, 2);
            Console.WriteLine(MJ.getResult());
            MJ.Subtract(100, 50);
            Console.WriteLine(MJ.getResult());
            MJ.Multiply(20, 4);
            Console.WriteLine(MJ.getResult());



            //pls
        }
    }
}
