using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Battletech_3062_Start_Creator.Classes;

namespace Battletech_3062_Start_Creator.Classes
{
    internal class Start
    {
        public string Filename { get; set; }
        public string Name { get; set; }
        public string ID { get; set; }
        public string System { get; set; }
        public double ScoreModifier { get; set; }
        public string MechLists { get; set; }
          
        

        public Start(string filepath)
        {
            StartJson temp = new StartJson();
            StartJson.StartData Data = temp.DeserializeStart(filepath);
            Filename = filepath.Replace("D:\\Steam\\steamapps\\common\\BATTLETECH\\Mods\\BT Advanced Starters\\BTA_Starters_Base\\", "");
            Name = Data.Instructions[0].Value.Name;
            ID = Data.Instructions[0].Value.ID;
            ScoreModifier = Data.Instructions[0].Value.CareerScoreModifier;
            System = Data.Instructions[0].Value.DifficultyConstants[0].ConstantValue;
            MechLists = Data.Instructions[0].Value.DifficultyConstants[1].ConstantValue;
        }

        
    }
}