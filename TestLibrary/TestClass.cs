using System;

namespace TestLibrary
{
    public class TestClass
    {
        public string GetName(string name)
        {
            return name;
        }
        public string FooBar(int num)
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                return "Foobar";
            }
            if (num % 3 == 0)
            {
                return "Foo";
            }
            if (num % 5 == 0)
            {
                return "Bar";
            }
            else
            {
                return num.ToString();
            }
        }
    }
}
