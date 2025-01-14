using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToC_.Fountain_Of_Objects
{
    public class TheDoor
    {

        public void RunDoor()
        {
            Door myDoor = new Door(1235);


            GameString("Welcome to the Door Puzzle");
            GameString("You are in a room with no doors.Input a passcode in the console to create a door.");
            GameString("Please remember your passcode, as once created the door cant be unlocked without it.");

            int input;


            while (true)
            {
                string userInput = Console.ReadLine();
                bool isNumber = int.TryParse(userInput, out input);
                if (isNumber)
                {
                    CreateDoor(input);
                    Console.Clear();
                    break;
                }
                else
                {
                    GameString("Invalid input. Please try again.");
                }

            }

            GameString("You can now fidlle with the door");
            while (true)
            {

                GameString("Press 1: To OPEN the door");
                GameString("Press 2: To CLOSE the door");
                GameString("Press 3: To LOCK the door");
                GameString("Press 4: To UNLOCK the door");
                GameString("Press 5: To change passcode");
                Console.ForegroundColor = ConsoleColor.Blue;
                GameString($"Current DoorState:{myDoor.MyDoorState}");

                Console.ForegroundColor = ConsoleColor.White;
                input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (input == 1)
                {
                    myDoor.OpenDoor();

                }
                else if (input == 2)
                {
                    myDoor.CloseDoor();
                }
                else if (input == 3)
                {
                    myDoor.LockDoor();
                }
                else if (input == 4)
                {
                    if (myDoor.MyDoorState == DoorState.Locked)
                    {
                        GameString("Please input the passcode to unlock the door.");
                        input = Convert.ToInt32(Console.ReadLine());
                        Unlocker(input);
                    }
                    else
                    {

                        GameString("The door is not locked.");
                    }

                }
                else if (input == 5)
                {
                    GameString("Please Enter The Current Passcode to change it.");
                    input = Convert.ToInt32(Console.ReadLine());
                    if (input == myDoor.MyPasscode)
                    {
                        ChangePasscode();
                    }
                    else
                    {
                        GameString("Incorrect Passcode. Please try again.");
                    }

                }
                else
                {
                    GameString("Invalid input. Please try again.");
                }
            }


           void ChangePasscode()
            {
                GameString("Please input the new Passcode to unlock the door.");
                input = Convert.ToInt32(Console.ReadLine());
                myDoor.MyPasscode = input;
                GameString("Passcode has been changed.");
                myDoor.MyDoorState = DoorState.Locked;
                GameString("The door has been locked.");
            }  



            void Unlocker(int input)
            {

                myDoor.UnlockDoor(input);
            }



            void CreateDoor(int input)
            {
                myDoor = new Door(input);
            }






            void GameString(string message)
            {
                Console.WriteLine(message);
                Console.WriteLine();
            }
        }


    }

    public class Door
    {
        private DoorState _doorState;
        private int _passcode;



        public DoorState MyDoorState
        {
            get { return _doorState; }
            set { _doorState = value; }
        }


        public int MyPasscode
        {
            get { return _passcode; }
            set { _passcode = value; }
        }


        public Door(int myPasscode)
        {
            _doorState = DoorState.Locked;
            MyPasscode = myPasscode;
        }

        public void UnlockDoor(int passcode)
        {
            if (MyDoorState == DoorState.Locked)
            {
                if (passcode == MyPasscode)
                {
                    MyDoorState = DoorState.Unlock;
                    SetGreen();
                    StateMessage("The door is now unlocked.");
                    SetWhite();

                }
                else
                {
                    SetRed();
                    StateMessage("Incorrect passcode. The door remains locked.");
                    SetWhite();

                }

            }
            else if (MyDoorState == DoorState.Unlock)
            {
                SetRed();
                StateMessage("The door is already unlocked.");
                SetWhite();

            }
            else
            {
                SetRed();
                StateMessage("The door is not locked.");
                SetWhite();
            }

        }


        public void OpenDoor()
        {
            if (MyDoorState == DoorState.Unlock)
            {
                MyDoorState = DoorState.Open;
                SetGreen();
                StateMessage("The door is now open.");
                SetWhite();
            }
            else if (MyDoorState == DoorState.Closed)
            {
                MyDoorState = DoorState.Open;
                SetGreen();
                Console.WriteLine("The door is now open.");
                SetWhite();
            }
            else if (MyDoorState == DoorState.Locked)
            {
                SetRed();
                StateMessage("The door is locked. You need to unlock it first.");
                SetWhite();
            }
        }

        public void CloseDoor()
        {
            if (MyDoorState == DoorState.Open)
            {
                MyDoorState = DoorState.Closed;
                SetGreen();
                Console.WriteLine("The door is now closed.");
                SetWhite();
            }
            else
            {
                SetRed();
                Console.WriteLine("The door is already closed.");
                SetWhite();
            }
        }

        public void LockDoor()
        {
            if (MyDoorState == DoorState.Closed || MyDoorState == DoorState.Unlock)
            {
                MyDoorState = DoorState.Locked;
                SetGreen();
                Console.WriteLine("The door is now locked.");
                SetWhite();
            }
            else if (MyDoorState == DoorState.Open)
            {
                SetRed();
                StateMessage("The door is open. You need to close it first.");
            }
            else
            {
                SetRed();
                StateMessage("The door is already locked.");
                SetWhite();
            }
        }


        public void SetWhite()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void SetRed()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        public void SetGreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public void StateMessage(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine();
        }

    }


    public enum DoorState
    {
        Open,
        Closed,
        Locked,
        Unlock

    }
}

