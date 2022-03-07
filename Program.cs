using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deconstructor
{

    internal class Program
    {
        public static void main()
        {
            Console.ReadLine();
        }
        class home
        {
            public home()
            {
                Console.WriteLine("home class created");
            }
            ~home()
            {
                Console.WriteLine("home class destroved");
            }
        }
    }
}
