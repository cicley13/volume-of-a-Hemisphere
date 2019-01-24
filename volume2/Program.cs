using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volume
{
    class Program
    {
        public static void Main(string[] args)
        {
            double volume, v;

            Console.WriteLine("Enter the radius of the hemisphere:       ");
            double r = Convert.ToDouble(Console.ReadLine());

            volume = 4/3 * Math.PI * r * r * r;
            v = volume/ Math.Sqrt(2);

            Console.WriteLine("The volume is: "+ v);
            Console.ReadLine();
        }
    }
}
