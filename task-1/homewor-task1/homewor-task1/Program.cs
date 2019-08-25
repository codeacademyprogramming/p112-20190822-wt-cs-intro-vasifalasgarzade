using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ededleri daxil edin");
            string line = Console.ReadLine();

            string[] strArray = line.Split(' ');

            int[] regemler = Array.ConvertAll(strArray, int.Parse);

            Console.WriteLine("En boyuk eded: " + Maxeded(regemler));
            Console.WriteLine("En kicik eded: " + Mineded(regemler));
            Console.WriteLine("Ededlerin cemi: " + findcem(regemler));

            int[] reversedArray = reverseArray(regemler);

            for (int i = 0; i < reversedArray.Length; i++)
            {
                Console.Write(reversedArray[i] + " ");
            }

            Console.ReadLine();
        }

        static int Maxeded(int[] array)
        {
            return array.Max();
        }

        static int Mineded(int[] array)
        {
            return array.Min();
        }

        static int findcem(int[] array)
        {
            return array.Sum();
        }

        static int[] reverseArray(int[] array)
        {
            int[] ters = array;
            Array.Reverse(ters);
            return ters;
        }
    }
}
