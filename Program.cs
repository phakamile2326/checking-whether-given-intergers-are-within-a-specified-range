using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checking_whether_given_intergers_are_within_a_specified_range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(check(11, 20, 12));
            Console.WriteLine(check(30,30,17));
            Console.WriteLine(check(25,35,50));
            Console.WriteLine(check(15,12,8));
            Console.ReadKey();
        }
        public static bool check(int x, int y, int z)
        {
            return (x>= 20 && x <=50) ||(y>= 20 && y <=50) || (z>= 20 && z <=50);
        }
    }
}
