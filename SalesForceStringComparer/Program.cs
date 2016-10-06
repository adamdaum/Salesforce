using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesForceStringComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            var myString1 = "ababc";
            var myString2 = "ccccaABLKKb";
            var myString3 = "   aba";
            var myString4 = "bbc dc";
            var myString5 = "";
            var myString6 = "2aaa3"; // 2
            var myString7 = "##22a"; // a
            var myString8 = "@@3a2535"; // a 
            var myString9 = "22Ala25"; // l
            var myString10 = "AAB7#@"; // b
            var myString11 = "4 more 4.3 times"; // 4 
            var myString12 = "10 is the number ten"; // 1 
            var myString13 = "20 is the number 2 + 0"; // i
            var myString14 = "This IS A teeeest"; // a
            var myString15 = "Salesforce is the best company to work for."; // l


            Console.WriteLine(String.Format("The first non repeating character in the string {0} is {1}", myString1, GetFirstNonRepeatingCharacterFromString(myString1)));
            Console.WriteLine(String.Format("The first non repeating character in the string {0} is {1}", myString2, GetFirstNonRepeatingCharacterFromString(myString2)));
            Console.WriteLine(String.Format("The first non repeating character in the string {0} is {1}", myString3, GetFirstNonRepeatingCharacterFromString(myString3)));
            Console.WriteLine(String.Format("The first non repeating character in the string {0} is {1}", myString4, GetFirstNonRepeatingCharacterFromString(myString4)));
            Console.WriteLine(String.Format("The first non repeating character in the string {0} is {1}", myString5, GetFirstNonRepeatingCharacterFromString(myString5)));
            Console.WriteLine(String.Format("The first non repeating character in the string {0} is {1}", myString6, GetFirstNonRepeatingCharacterFromString(myString6)));
            Console.WriteLine(String.Format("The first non repeating character in the string {0} is {1}", myString7, GetFirstNonRepeatingCharacterFromString(myString7)));
            Console.WriteLine(String.Format("The first non repeating character in the string {0} is {1}", myString8, GetFirstNonRepeatingCharacterFromString(myString8)));
            Console.WriteLine(String.Format("The first non repeating character in the string {0} is {1}", myString9, GetFirstNonRepeatingCharacterFromString(myString9)));
            Console.WriteLine(String.Format("The first non repeating character in the string {0} is {1}", myString10, GetFirstNonRepeatingCharacterFromString(myString10)));
            Console.WriteLine(String.Format("The first non repeating character in the string {0} is {1}", myString11, GetFirstNonRepeatingCharacterFromString(myString11)));
            Console.WriteLine(String.Format("The first non repeating character in the string {0} is {1}", myString12, GetFirstNonRepeatingCharacterFromString(myString12)));
            Console.WriteLine(String.Format("The first non repeating character in the string {0} is {1}", myString13, GetFirstNonRepeatingCharacterFromString(myString13)));
            Console.WriteLine(String.Format("The first non repeating character in the string {0} is {1}", myString14, GetFirstNonRepeatingCharacterFromString(myString14)));
            Console.WriteLine(String.Format("The first non repeating character in the string {0} is {1}", myString15, GetFirstNonRepeatingCharacterFromString(myString15)));
            Console.ReadLine();


        }

        public static char GetFirstNonRepeatingCharacterFromString(string input)
        {
            var result = new char();

            input = input.ToLower();

            var characterList = input.ToList();

            foreach (char character in characterList)
            {
                if (characterList.IndexOf(character) == characterList.LastIndexOf(character))
                {
                    result = character;
                    break;
                }
            }

            return result;
        }


    }
}
