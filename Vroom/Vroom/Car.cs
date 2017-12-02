using System;
using System.Collections.Generic;
using System.Text;

namespace Vroom
{
    class Car
    {
        public int NavigateMenu()
        {
            try
            {
                //here is the table of contents / main menu
                Console.WriteLine("Welcome to the Tesla driving system. I am Elon, your driving assistant. How would you like to proceed?");
                Console.WriteLine("1. Open the door.");
                Console.WriteLine("2. Close the door.");
                Console.WriteLine("3. Unlock the car.");
                Console.WriteLine("4. Lock the car.");
                Console.WriteLine("5. Start the car.");
                Console.WriteLine("6. Turn off the engine.");
                Console.WriteLine("7. Turn on the lights.");
                Console.WriteLine("8. Turn off the lights.");
                Console.WriteLine("9. Return to the main menu.");

                int input = Convert.ToInt32(Console.ReadLine());
                return input;
            }
            catch(FormatException fe)
            {
                Console.WriteLine($"You entered {fe}. Please enter one of the numbers above.");
            }
            catch (Exception ex) { Console.WriteLine(ex); }
            finally { Console.WriteLine("Thanks for the entry."); }
            return 0;
        }
        
        //open door


        //close door

        //lock

        //unlock

        //start the car

        //turn off the car

        //turn on the lights
    }
}
