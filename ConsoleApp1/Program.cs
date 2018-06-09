using System;
using ClassLibrary1;
using ClassLibrary2;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Class1.a); // C# .net standard
            Console.WriteLine(Class1.b);
            Console.WriteLine(Class1.c == "国");
            Console.WriteLine(Say.a); // F# .net standard
            Console.WriteLine(Say.b);
            Console.WriteLine(Say.c == "国");
            Console.WriteLine("Hello World!");
        }
    }
}
