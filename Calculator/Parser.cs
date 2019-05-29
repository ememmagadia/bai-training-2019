using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Parser
    {
        bool IsOperator(char content)
        {
            if (content != '+'
             || content != '-'
             || content != '*'
             || content != '/'
             || content != ' ')
            {
                Console.Write(" {0} is not an operator or whitespace. ", content);
                return false;
            }
            else return true;
        }
        public void Parse(string input)
        {
            Console.Clear();
            Console.WriteLine("You entered {0}", input);

            int invalid = 0;
            char[] contents = input.ToCharArray();
            for(int i = 0; i < contents.Length; i++)
            {
                //Parse to check if there are invalid characters in the input
                Console.Write(contents[i]);
                if (!Char.IsDigit(contents[i]))
                {
                    Console.Write(" is not a digit. ");
                    if (!IsOperator(contents[i])) invalid++;
                }
            }

            if (invalid > 0)
            {
                Calculator c = new Calculator();
                Console.WriteLine("Invalid characters found!");
                Console.ReadLine();
                c.ComputeStringMenu();
            }
        }
    }
}
