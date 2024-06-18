using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EscapeRoom
{
    internal class GameRoom
    {

        public static void Start()
        {

            var availableRooms = new AvailableRooms();
            

            while (true)
            {
                Console.WriteLine("Welcome to the escape room");
                Console.WriteLine($"You are now in {availableRooms._currentRoom} ");
                Console.WriteLine("Press 1 to search the room");
                Console.WriteLine("Press 2 to go to the next room, if able to");
                var userInput = Console.ReadLine();
                switch(userInput)
                {
                    case "1":
                        availableRooms.Search();
                        break;
                }

            }
        }
    }
}

