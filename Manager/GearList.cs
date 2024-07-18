using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Battletech_3062_Start_Creator.Classes;
using System.IO;
using System.Diagnostics;

namespace Battletech_3062_Start_Creator.Manager
{
    /// <summary>
    /// List of all Mechs, Vehicles and Battle Armor
    /// </summary>
     class GearList
    {
        private string? Name { get; set; }

        List <Mech> Mechs = new List<Mech>();
        List <string> list = new List<string>();

        public void PopulateMechs()
        {
            Trace.WriteLine("Test");
            using(var reader = new StreamReader(@"D:\Steam\steamapps\common\BATTLETECH\Mods\BT Advanced Starters\BTA_itemCollection_Mechs\itemCollection_Mechs_Generic_APC.csv"))
            {
                
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    list.Add(line);
                    Trace.WriteLine(line);
                }
                
            }
            Name = list.First();
            list.RemoveAt(0);
            foreach (var line in list)
            {
                Trace.WriteLine(line.Trim());
                string[] stringArray = line.Split(",");
                Mech mech = new Mech(stringArray[0], int.Parse(stringArray[3]));
                Mechs.Add(mech);
            }
            foreach (Mech mech in Mechs)
            {
                Trace.WriteLine(mech.Name);
            }
        }
    }
}
