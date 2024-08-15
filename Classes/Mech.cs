using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battletech_3062_Start_Creator.Classes
{
    /// <summary>
    /// Immutable class for mechs
    /// May polymorph into 
    /// </summary>
    class Mech : Interface
    {
        public string Name { get; set; }
        public int? Rarity { get; set; }

        /// <summary>
        /// Constructor for Mech objects
        /// </summary>
        public Mech(string name, int rarity) 
        {
            Name = name;
            Rarity = rarity;
        }
    }
}
