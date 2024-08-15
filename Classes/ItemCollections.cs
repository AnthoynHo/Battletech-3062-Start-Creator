using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Battletech_3062_Start_Creator.Classes
{
    /// <summary>
    /// List of all mechs in an item collection for creating a new start.
    /// </summary>
    class Collection : Interface
    {
        public string Name { get; set; }
        public List<Mech> Meches { get; set; }

        public Collection(string name, List<Mech> meches)
        {
            Name = name;
            Meches = meches;
        }   
    }
}
