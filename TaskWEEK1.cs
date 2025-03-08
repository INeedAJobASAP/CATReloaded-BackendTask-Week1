using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region ArrayLargestNum
namespace ArrayLargestNum
{
    internal class Program
    {
        static void Main()
        {
            int[] n = new int[10];
            Console.WriteLine("Enter 10 numbers:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Number {i + 1}: ");
                n[i] = int.Parse(Console.ReadLine());
            }
            int max = n[0];
            for (int i = 1; i < 10; i++)
            {
                if (n[i] > max)
                    max = n[i];
            }
            
            Console.WriteLine($"The largest number is: {max}");
            return;
        }
    }
}
#endregion


#region VowORConst
namespace VowORConst
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("enter character: ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (c)
            {
                case 'a':
                case 'A':
                case 'e':
                case 'E':
                case 'i':
                case 'I':
                case 'o':
                case 'O':
                case 'u':
                case 'U':
                    Console.WriteLine("vowel");
                    break;
                default:
                    Console.WriteLine("consonant");
                    break;
            }
        }

    }
}
#endregion

#region upto12_MUL
namespace upto12_MUL
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter an integer: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{num}x{i}={num * i}");
            }
        }
    }
}
#endregion

#region _3_4Division
namespace _3_4Division
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            if (n % 3 == 0 && n % 4 == 0)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
            return;
        }
    }
}
#endregion

#region DecToBin
namespace DecToBin
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("enter decimal number: ");
            int n = int.Parse(Console.ReadLine());
            string binary = "";
            while (n > 0)
            {
                binary = (n % 2) + binary;
                n /= 2;
            }
            Console.WriteLine("binary number: " + binary);
        }
    }
}

#endregion

#region MergeArr
namespace MergeArr
{
    internal class Program
    {
        static void Main()
        {
            int[] arr1 = { 1, 3, 5, 7 };
            int[] arr2 = { 2, 4, 6, 8 };
            int[] mergedarr = arr1.Concat(arr2).OrderBy(n => n).ToArray();

            Console.Write("Merged Sorted Array: ");
            for (int i = 0; i < mergedarr.Length; i++)
            {
                Console.Write(mergedarr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
#endregion

#region SecLargestNum
namespace SecLargestNum
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = { 10, 20, 4, 45, 99, 8 };
            Array.Sort(numbers);
            int secMax = numbers[numbers.Length - 2];

            Console.WriteLine($"Second largest number is: {secMax}");
        }
    }
}
#endregion

#region ReverseArr
namespace ReverseArr
{
    internal class Program
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Array in Reverse:");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
#endregion
