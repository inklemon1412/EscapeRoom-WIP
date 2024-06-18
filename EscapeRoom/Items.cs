using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeRoom
{
    abstract class Items
    {
        public string Name { get; }
        public string Description { get; }

        

        protected Items(string name, string description) 
        {
            Name = name;
            Description = description;
            
           
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Item = {Name}");
            Console.WriteLine($"Description = {Description}");
            
        }
        public abstract void PickUp();
    }
}
