using System;
using System.IO;

namespace Vroom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Tesla driving system. I am Elon, your driving assistant. How would you like to proceed?");
            InputHandler();

            Console.ReadLine();
        }

        //here is the table of contents / main menu - it will be referred to from the InputHandler method
        static int NavigateMenu()
        {
            try
            {
                Console.WriteLine("1. Open the door.");
                Console.WriteLine("2. Close the door.");
                Console.WriteLine("3. Unlock the car.");
                Console.WriteLine("4. Lock the car.");
                Console.WriteLine("5. Start the car.");
                Console.WriteLine("6. Turn off the engine.");
                Console.WriteLine("7. Turn on the lights.");
                Console.WriteLine("8. Turn off the lights.");
                Console.WriteLine("9. Go offline.");

                int input = Convert.ToInt32(Console.ReadLine());
                return input;
            }
            catch (FormatException fe)
            {
                Console.WriteLine($"You entered {fe}. Please enter one of the numbers above.");
            }
            catch (Exception ex) { Console.WriteLine(ex); }
            finally { Console.WriteLine("Thanks for the entry."); }
            return 0;
        }

        //this method handles the user's selection and assigns a number to each method that the user can access
        static void InputHandler()
        {
            int choice = NavigateMenu();

            switch (choice)
            {
                case 1:
                    OpenDoor();
                    break;
                case 2:
                    CloseDoor();
                    break;
                case 3:
                    LockDoors();
                    break;
                case 4:
                    UnlockDoors();
                    break;
                case 5:
                    VroomVroom();
                    break;
                case 6:
                    TurnOff();
                    break;
                case 7:
                    Lumos();
                    break;
                case 8:
                    Tenebris();
                    break;
                case 9:
                    ExitNavigation();
                    break;
                default:
                    Console.WriteLine("Please choose from one of the available options.");
                    InputHandler();
                    break;
            }
        }

        //open door
        static void OpenDoor()
        {
            Console.WriteLine("The door is open. Feel free to enter.");
            Console.WriteLine();

            InputHandler();
        }

        //close door
        static void CloseDoor()
        {
            //if() { }

            Console.WriteLine("The door is now closed. What would you like to do next?");
            Console.WriteLine();

            InputHandler();

        }

        //lock
        static void LockDoors()
        {
            Console.WriteLine();
            InputHandler();
        }

        //unlock
        static void UnlockDoors()
        {
            Console.WriteLine();
            InputHandler();
        }

        //start the car
        static void VroomVroom()
        {
            Console.WriteLine();
            InputHandler();
        }

        //turn off the car
        static void TurnOff()
        {
            Console.WriteLine();
            InputHandler();
        }

        //turn on the lights - Harry Potter themed
        static void Lumos()
        {
            Console.WriteLine();
            InputHandler();
        }

        //turn off the lights - this one is in Latin, means "darkness"
        static void Tenebris()
        {
            Console.WriteLine();
            InputHandler();
        }

        //use this to turn off the driving assistant
        static void ExitNavigation()
        {
            Console.WriteLine("Sorry to see you go. Until next time!");
        }
    }
}

