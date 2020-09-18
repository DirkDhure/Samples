using System;
using System.Linq;

namespace Sorting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string input:");
            var input = Console.ReadLine();
            Console.WriteLine(ProcessInput(input));
            Console.ReadLine();

        }

        // Process the string by removing white space, changing string case and sorting the letters
        public static string ProcessInput(string input)
        {
            // change case
            input = input.ToLower();

            // select only letters
            var filteredInput = from c in input
                                where char.IsLetter(c)
                                select c;

            //perform sorting
            string output = SortInput(filteredInput.ToArray());
            
            return output;

        }

        // sorts characters in an array using bubble sort algorythm
        public static string SortInput(char[] input)
        {
            bool swapped;
            char temp;
            do
            {
                swapped = false;
                for (int index = 0; index < input.Length; index++)
                {

                    if ((index < input.Length - 1) && (input[index] > input[index + 1]))
                    {
                        temp = input[index];
                        input[index] = input[index + 1];
                        input[index + 1] = temp;
                        swapped = true;
                    }
                }

            } while (swapped);

            return new string(input.ToArray());
        }
    }
}
