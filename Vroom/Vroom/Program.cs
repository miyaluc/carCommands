using System;

namespace Vroom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.ReadLine();
        }

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
            catch (FormatException fe)
            {
                Console.WriteLine($"You entered {fe}. Please enter one of the numbers above.");
            }
            catch (Exception ex) { Console.WriteLine(ex); }
            finally { Console.WriteLine("Thanks for the entry."); }
            return 0;
        }

        //this method handles the user's selection and assigns a number to each method that the user can access
        public void InputHandler()
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
                //case 9:
                //    break;
                default:
                    Console.WriteLine("Please choose from one of the available options.");
                    InputHandler();
                    break;
            }
        }

        //open door
        public void OpenDoor()
        {
            Console.WriteLine("The door is open. Feel free to enter.");

            InputHandler();
        }

        //close door
        public void CloseDoor()
        {

        }

        //lock
        public void LockDoors()
        {

        }

        //unlock
        public void UnlockDoors()
        {

        }

        //start the car
        public void VroomVroom()
        {

        }

        //turn off the car
        public void TurnOff()
        {

        }

        //turn on the lights - Harry Potter themed
        public void Lumos()
        {

        }

        //turn off the lights - this one is in Latin, means "darkness"
        public void Tenebris()
        {
        }

        //return to main menu
    }
}

