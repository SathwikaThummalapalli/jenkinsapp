using System;

namespace jenkinsapp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath m = new MyMath();
            Console.WriteLine("Hello World!");
            Console.WriteLine("welcome to jenkins");
            Console.ReadLine();
            int a = m.add(10, 5);
            int b = m.multiply(10, 5);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadLine();
            
        }
    }
}
