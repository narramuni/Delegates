using DelegatesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringOperations operations = new StringOperations();

            AttachStringToEachOther attachDelegate = operations.ConcatStrings;
            FindLength lengthDelegate = operations.StringLength;


            operations.GreetEvent += GreetUser;

            operations.MakeFirstCharacterUppercaseEvent += operations.MakeFirstCharacterUppercase;

            Console.Write("Enter a string to make the first character uppercase: ");
            string inputToUppercase = Console.ReadLine();


            string uppercaseString = operations.MakeFirstCharacterUppercase(inputToUppercase);


            Console.WriteLine("String with the first character in uppercase: " + uppercaseString);

            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            operations.GreetUser(userName);



            Console.Write("Enter the first string: ");
            string str1 = Console.ReadLine();

            Console.Write("Enter the second string: ");
            string str2 = Console.ReadLine();


            string concatenatedString = attachDelegate(str1, str2);


            Console.WriteLine("Concatenated String: " + concatenatedString);

            Console.Write("Enter a string to find its length: ");
            string inputString = Console.ReadLine();


            int length = lengthDelegate(inputString);
            Console.WriteLine("Length of the string: " + length);



            Console.ReadLine();
        }

        static void GreetUser(string name)
        {

            Console.WriteLine($"Hii,{name}");
        }


        static string MakeFirstCharacterUppercase(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            char[] charArray = input.ToCharArray();
            charArray[0] = char.ToUpper(charArray[0]);
            return new string(charArray);
        }
    }
}
