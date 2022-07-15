using System;
using System.Collections.Generic;
using System.Text;

namespace jenkinsapp
{
    class Mathrun
    {
        static void Main(string[] args)
        {
            MyMath math = new MyMath();
            int a=math.add(5, 10);
            int b=math.multiply(5, 10);
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
