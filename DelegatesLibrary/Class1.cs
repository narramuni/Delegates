using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesLibrary
{
    public delegate void GreetDelegate(string name);

    public delegate string MakeFirstCharacterUppercaseDelegate(string input);

    public delegate string AttachStringToEachOther(string s1, string s2);

    public delegate int FindLength(string s);

    public class StringOperations
    {
        public event MakeFirstCharacterUppercaseDelegate MakeFirstCharacterUppercaseEvent;

        public string MakeFirstCharacterUppercase(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            char[] charArray = input.ToCharArray();
            charArray[0] = char.ToUpper(charArray[0]);
            return new string(charArray);
        }

        public event GreetDelegate GreetEvent;

        public void GreetUser(string name)
        {
            // Trigger the GreetEvent to greet the user
            GreetEvent?.Invoke(name);
        }
        public string ConcatStrings(string s1, string s2)
        {
            return s1 + s2;

        }


        public int StringLength(string s)
        {
            return s.Length;
        }

    }
}
