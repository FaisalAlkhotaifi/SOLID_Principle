using System;
using NoOCP;
using OCP;

namespace OCP_DEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Running Bad Practice");

            BadPractice badPractice = new BadPractice();
            badPractice.Run();

            Console.WriteLine("--------------------");

            Console.WriteLine("--------------------");
            Console.WriteLine("Running Best Practice");

            BestPractice bestPractice = new BestPractice();
            bestPractice.Run();

            Console.WriteLine("--------------------");
        }
    }
}
