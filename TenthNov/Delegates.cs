using System;
using System.Collections.Generic;
using System.Text;

namespace TenthNov
{
    public delegate void mydele(int x, int y);

    public class Delegates
    {



        public void add(int x, int y) {
                Console.WriteLine("The Sum is " + (x + y));
            }

            public void sub(int x, int y) {
                Console.WriteLine("The Difference is " + (x - y));
                Console.ReadKey();
            }
        
    }
}
