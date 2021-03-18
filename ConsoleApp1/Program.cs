using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo!");
            string helloWorldMessage = "Hello World";
            Console.WriteLine(HelloWorld(helloWorldMessage));
        }
        private static string HelloWorld(string message)
        {
            return message;
        }
    }
}
