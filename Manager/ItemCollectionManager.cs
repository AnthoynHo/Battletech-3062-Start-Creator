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
        public  string? Name { get; set; }
        public List<Mech> Mechs = new List<Mech>();
        public void PopulateCollections(string filename)
        {
            List<string> list = new List<string>();
            //Get file info
            //Currently using hard coded values
            using (var reader = new StreamReader(@"D:\Steam\steamapps\common\BATTLETECH\Mods\BT Advanced Starters\BTA_itemCollection_Mechs\" + filename))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    list.Add(line);
                    Trace.WriteLine(line);
                }
            }
            //
            string temp = list.First();
            string[] nameString = temp.Split(",");
            Name = nameString[0];
            list.RemoveAt(0);
            foreach (var line in list)
            {
                Trace.WriteLine(line.Trim());
                string[] stringArray = line.Split(",");
                Mech mech = new Mech(stringArray[0], int.Parse(stringArray[3]));
                Mechs.Add(mech);
            }
        }
    }
}
