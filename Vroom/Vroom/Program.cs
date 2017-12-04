using System;
using System.IO;

namespace Vroom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Tesla driving system. I am Elon, your driving assistant. How would you like to proceed?");

            Vehicle sedan = new Vehicle();
            sedan.InputHandler();

            Console.ReadLine();
        }

    }    
}

