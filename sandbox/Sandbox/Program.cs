using System;

class Program
{
    class Test
    {
        public Test _test = new Test();

        string a;
        public void yourmom()
        {
            _test.a = "bruh";

            Console.WriteLine(_test.a);
            
        }

    }
    static void Main(string[] args)
    {
        Test Test = new Test();

        Test._test.yourmom();
    }
}