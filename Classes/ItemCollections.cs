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
        public List<Mech>? Mechs { get; set; }


        public Collection(string filepath)
        {
            List<string> list = new List<string>();
            //Get file info
            //Currently using hard coded values
            using (var reader = new StreamReader(filepath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    if (line == null)
                    {
                        continue;
                    }
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
                if (line == "")
                {
                    continue;
                }
                if (Mechs == null)
                {
                    Mechs = new List<Mech>();
                    string[] stringArray = line.Split(",");
                    Mech mech = new Mech(stringArray[0], int.Parse(stringArray[3]));
                    Mechs.Add(mech);
                }
                else
                {
                    Trace.WriteLine(line.Trim());
                    string[] stringArray = line.Split(",");
                    Mech mech = new Mech(stringArray[0], int.Parse(stringArray[3]));
                    Mechs.Add(mech);
                }
            }
        }   
    }
}
