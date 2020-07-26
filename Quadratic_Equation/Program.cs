using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic_Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of b");
            double b=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of a");
            double a = Convert.ToDouble(Console.ReadLine());           
            Console.WriteLine("Enter the value of c");
            double c = Convert.ToDouble(Console.ReadLine());
            double dis = Convert.ToDouble((b * b) - (4 * a * c));
            double s_dis = Math.Sqrt(dis);
            double q_y1 = (- b + s_dis) / 2 * a;
            Console.WriteLine("Quadratic first Answer is " + q_y1);
            double q_y2 = (-b - s_dis) / 2 * a;
            Console.WriteLine("Quadratic second Answer is " + q_y2);
            Console.ReadKey();

        }
    }
}
