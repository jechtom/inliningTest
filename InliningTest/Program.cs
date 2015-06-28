using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InliningTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Run this project as both debug and release.");
            Console.WriteLine("Calling assembly should be: InliningTest\n(not InliningTest.SecondAsembly)");
            Console.WriteLine();

            var instance = new Implementation();
            instance.Execute();
        }
    }
}
