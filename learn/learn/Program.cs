using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N\t\t10*N\t\t100*N\t\t1000*N");

            for (int i = 3; i < 8; i++)

            {
                Console.WriteLine();
                Console.WriteLine($"{i}\t\t{i * 10}\t\t{i * 100}\t\t{i * 1000}");
            }
            Console.ReadLine();

                    


        }
    }
}
