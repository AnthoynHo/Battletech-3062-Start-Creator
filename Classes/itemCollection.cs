using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Battletech_3062_Start_Creator.Classes;

namespace Battletech_3062_Start_Creator.Classes
{
    /// <summary>
    /// List of all mechs in an item collection for creating a new start.
    /// </summary>
    class itemCollection
    {
        public string? Name { get; }

        List <Mech> Mechs = new List<Mech>();
    }
}
