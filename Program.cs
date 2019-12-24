using System;
using System.Numerics;
using System.Runtime.InteropServices.ComTypes;

namespace QuantumModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger l = new Logger();

            Ket k1 = new Ket(new Complex[]{ new Complex(2,2), 2 }, "k1");
            Ket k2 = new Ket(new Complex[]{ new Complex(2,2), 2 }, "k2");
            Console.WriteLine(k2);
            Ket k3 = new Ket(new Complex[]{ new Complex(2,2), 2 }, "k3");
            int scalar = 3;
            var sum = new Ket(2, "sum");
            var product = scalar * k1;
            sum = k1 + k2;
            Console.WriteLine(sum);
        }
    }
}
