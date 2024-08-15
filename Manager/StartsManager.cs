using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Battletech_3062_Start_Creator.Classes;

namespace Battletech_3062_Start_Creator.Manager
{
    class StartsManager
    {
        public List<Start> Starts = new List<Start>();

        public void PopulateStarts() 
        {
            string path = @"D:\Steam\steamapps\common\BATTLETECH\Mods\BT Advanced Starters\BTA_Starters_Base";
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                Start i = new Start(file);
                Starts.Add(i);
            }
        }
    }
}