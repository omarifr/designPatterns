using System;
using System.Runtime.CompilerServices;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var mustang = Car.GetInstance();

            mustang.Motor = "V8";
            var challenger = Car.GetInstance();

            Console.Write(mustang.Motor);
            Console.ReadLine();
        }
    }

    internal class Car
    {
        private static Car _instance;
        private Car() { }

        public static Car GetInstance()
        {
            if (_instance != null)
                return _instance;
            return new Car();
        }
        
        public string Motor { get; set; }
        public string Transmission { get; set; }
    }
}
