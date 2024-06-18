using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeRoom
{
    class Junk : Items
    {
        public bool IsSmelly { get; }

        public Junk(string name, string description, bool isSmelly)
         : base(name, description)
        {
            IsSmelly = isSmelly;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
           if (IsSmelly) Console.WriteLine("It smells real bad");
        }

        public override void PickUp()
        {

            Console.WriteLine($"You have picked up the item. Hope you know what you're doing");
        }



    }
}


