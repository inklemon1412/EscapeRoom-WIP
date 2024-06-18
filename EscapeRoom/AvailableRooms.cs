using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EscapeRoom
{
    class AvailableRooms
    {
        public string[] _rooms;
        public string _currentRoom;
        int currentItems = 0;
        int ItemsNeededToUnlock = 0;



        public AvailableRooms()
        {
            _currentRoom = "Room 1";
            _rooms = new[] { "Room 1", "Room 2", "Room3" };

        }
        public void Search()
        {
            Console.WriteLine($"Current items: {currentItems}");
            if (_currentRoom == "Room 1" && ItemsNeededToUnlock > 3)

            Console.WriteLine("Where would you like to look?");
            Console.WriteLine("1) The shady corner");
            Console.WriteLine("2) Behind the sofa");
            Console.WriteLine("3) The shelf");
            Console.WriteLine("Hint: Sometimes you will find 2-3 items in your search. Only one of these items is needed, in a total of three from each hunt. \r\n You will need three correct items to be able to proceed to the next room");
            var userChoice = Console.ReadLine();
            if (userChoice == "1")
            {
                CornerLook();
            }
           else if (userChoice == "2")
            {
                SofaLook();
            }
    

        void CornerLook()
            {
                while (true)
                {
                    Console.WriteLine("Searching...");
                    Thread.Sleep(600);
                    Console.WriteLine("Item found");
                    var key1 = new Keys(
                        "A rusty key",
                        "Who knows what it's for",
                        2
                        );
                    key1.ShowInfo();
                    Console.WriteLine("Searching...");
                    Thread.Sleep(600);
                    var junk1 = new Junk(
                        "A crumpled paper",
                        "Something seems to be written on the inside. Could be helpful.",
                        false
                        );
                    junk1.ShowInfo();
                    Search();
                }
            }

            void SofaLook()
            {
                while (true)
                {
                    Console.WriteLine("Searching...");
                    Thread.Sleep(600);
                    Console.WriteLine("Item found");
                    var junk2 = new Junk(
                        "A used sock",
                        "Trash. Just trash. Eww",
                        true
                        );
                    junk2.ShowInfo();
                    Search();
                }
            }
        }
    }
}
    

