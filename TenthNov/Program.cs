using System;

namespace TenthNov
{
    class Program
    {
        static void Main(string[] args) {
            Delegates delegates = new Delegates();
            //make an object of class A
            mydele m = new mydele(delegates.add);
            m(10, 20);
            mydele m1 = new mydele(delegates.sub);
            m1(10, 20);

    }
    }
}
