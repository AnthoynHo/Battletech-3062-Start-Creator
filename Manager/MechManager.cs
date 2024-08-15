using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Battletech_3062_Start_Creator.Classes;

namespace Battletech_3062_Start_Creator.Manager
{
    /// <summary>
    /// Handles lists of mechs, when selected displays a mech with it's type and name
    /// </summary>
    class MechManager
    {
        public List<Mech> Mechs = new List<Mech>();
        public MechManager() { }

        public void PopulateMechs(string filename)
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
            //string temp = list.First();
            //string[] nameString = temp.Split(",");
            //Name = nameString[0];
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
