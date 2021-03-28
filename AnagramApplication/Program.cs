using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramApplication
{
    class Program
    {
        static bool anagramResult = false;
        static void Main(string[] args)
        {
            bool exitProgram = false;

            while (!exitProgram)
            {
                Console.WriteLine("Enter first string: ");
                string inputFirst = Console.ReadLine();
                Console.WriteLine("Enter second string: ");
                string inputSecond = Console.ReadLine();

                if (inputFirst.Length <= inputSecond.Length)
                {
                    permute(inputFirst.ToLower(), 0, inputFirst.Length - 1, inputSecond.ToLower());
                    Console.WriteLine("An anagram of {0} in {1} is {2}.", inputFirst, inputSecond, anagramResult.ToString());
                }
                else
                    Console.WriteLine("First string should be equal or lesser than Second string!!");
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                anagramResult = false;
            }
        }

        private static void permute(string str1, int l, int r, string str2)
        {
            if (l == r)
            {
                if (str2.Contains(str1))
                {
                    anagramResult = true;
                }
            }
            else
            {
                for (int i = l; i <= r; i++)
                {
                    if (anagramResult == false)
                    {
                        str1 = swapIndex(str1, l, i);
                        permute(str1, l + 1, r, str2);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        private static string swapIndex(string str1, int Ori, int Des)
        {
            char temp;
            char[] charArray = str1.ToCharArray();
            temp = charArray[Ori];
            charArray[Ori] = charArray[Des];
            charArray[Des] = temp;
            string s = new string(charArray);
            return s;
        }
    }
}
