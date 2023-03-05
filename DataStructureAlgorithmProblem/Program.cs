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

            Console.WriteLine("1.Permutation \n Enter your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Enter a string: ");
                    string str = Console.ReadLine();
                    int n = str.Length;
                    permutation.permute(str, 0, n - 1);
                    break;

                case 2:
                    BinarySearch binarySearch = new BinarySearch();
                    Console.WriteLine("Enter word to search:");
                    str = Console.ReadLine();
                    binarySearch.search(str);
                    break;

                case 3:
                    InsertionSort insertion = new InsertionSort();
                    Console.WriteLine("How many strings you want to add:");
                    int no = Convert.ToInt32(Console.ReadLine());
                    string[] array = new string[no];
                    for (int i = 0; i < no; i++)
                    {
                        Console.WriteLine("Enter string:");
                        string s = Console.ReadLine();
                        array[i] = s;
                    }
                    insertion.Sorting(array);
                    break;

                case 4:
                    BubbleSorting bubble = new BubbleSorting();
                    Console.WriteLine("\nHow many strings you want to add:");
                    n = Convert.ToInt32(Console.ReadLine());
                    string[] unsorted = new string[n];
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("Enter string:");
                        string s = Console.ReadLine();
                        unsorted[i] = s;
                    }
                    bubble.Sort(unsorted);
                    break;

                case 5:
                    AnagramDetection anagram = new AnagramDetection();
                    Console.WriteLine("Enter first strings:");
                    string s1 = Console.ReadLine();
                    Console.WriteLine("Enter first strings:");
                    string s2 = Console.ReadLine();
                    anagram.Detection(s1, s2);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
            Console.ReadKey();

        }
    }
}