using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeRoom
{
    class Keys : Items
    {
        public int Weight { get; }

        public Keys(string name, string description, int weight)
         : base(name, description)
        {
            Weight = weight;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Weight = {Weight}");
        }

        public override void PickUp()
        {
          
            Console.WriteLine($"You have picked up the item");
        }



    }
}
