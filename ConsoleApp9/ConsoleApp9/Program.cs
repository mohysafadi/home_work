using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];
            Random rvg = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rvg.Next(25, 75);
            }

            // طباعة الأرقام المولدة
            Console.WriteLine("Generated numbers:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            //😁 حساب التكرار بالطريقة التكرارية
            Console.WriteLine("\nFrequensy of each value ( Repetitive method):");
            mohy_aldeen_repetition(numbers);

            //😁 حساب التكرار بالطريقة العودية
            Console.WriteLine("\nFrequensy of each value (Recursive method ):");
            Dictionary<int, int> occurrences = new Dictionary<int, int>();
            mohy_aldeen_repetition(numbers, occurrences, 0);
            foreach (var occ in occurrences)
            {
                Console.WriteLine($"value {occ.Key} Repeated {occ.Value} once");
            }
        }

        static void mohy_aldeen_repetition(int[] numbers)
        {
            Dictionary<int, int> occurrences = new Dictionary<int, int>();

            foreach (int number in numbers)
            {
                if (occurrences.ContainsKey(number))
                {
                    occurrences[number]++;
                }
                else
                {
                    occurrences[number] = 1;
                }
            }

            foreach (var occ in occurrences)
            {
                Console.WriteLine($"value {occ.Key} Repeated {occ.Value} once");
            }
        }

        static void mohy_aldeen_repetition(int[] numbers, Dictionary<int, int> occurrences, int index)
        {
            if (index >= numbers.Length)
                return;

            if (occurrences.ContainsKey(numbers[index]))
            {
                occurrences[numbers[index]]++;
            }
            else
            {
                occurrences[numbers[index]] = 1;
            }

            mohy_aldeen_repetition(numbers, occurrences, index + 1);
        }
    }
}