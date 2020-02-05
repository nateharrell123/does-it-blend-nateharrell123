using System;
using System.Collections.Generic;

namespace DoesItBlend
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var b = new Banana();
            var m = new Mango();
            var s = new Strawberry();
            var c = new IceCubes();
            Console.WriteLine(b.Blend());
            Console.WriteLine(m.Blend());
            Console.WriteLine(s.Blend());

            List<IBlendable> fruits = new List<IBlendable>() { b, m, s, c };
            foreach(var fruit in fruits)
            {
                Console.WriteLine(fruit.Blend());
            }
        }
    }
}
