using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            double t;
            Console.WriteLine("ctg^-1*(x-pi)");
            Console.WriteLine("Введите значение для х");
            x=Console.ReadLine();
            t = Convert.ToDouble(x);
            double y = Math.Pow(Math.Tan(t - Math.PI), -1) ;
            Console.WriteLine("ctg^-1("+x+"-pi)="+y);
        }
    }
}

