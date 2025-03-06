using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Battletech_3062_Start_Creator.Classes;
using System.Diagnostics;
using System.IO;

namespace Battletech_3062_Start_Creator.Manager
{
    /// <summary>
    /// Handles collections of mechs/vehicles/battle armor for slotting into starts
    /// Each Collections consists of a list of items(entirely of mechs, vehicles or battle armor) and a name.
    /// </summary>
    internal class ItemCollectionManager
    {
        public List<Collection> Collections = new List<Collection>();
        public void PopulateItemCollections()
        {
            string path = "D:\\Steam\\steamapps\\common\\BATTLETECH\\Mods\\BT Advanced Starters\\BTA_itemCollection_Mechs";
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                Collection i = new Collection(file);
                Collections.Add(i);
            }
        }
    }
}
