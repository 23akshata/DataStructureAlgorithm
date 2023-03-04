using DataStructureAlgorithmProblem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Permutation permutation = new Permutation();

            Console.Write("1.Permutation \n Enter your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Enter a string: ");
                    string str = Console.ReadLine();
                    int n = str.Length;
                    permutation.permute(str, 0, n - 1);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
            Console.ReadKey();

        }
    }
}