using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace Battletech_3062_Start_Creator.Classes
{
    class StartJson
    {
        public class Instruction
        {
            public string JSONPath { get; set; }
            public string Action { get; set; }
            public Values Value { get; set; }

            public class Values
            {
                public string ID { get; set; }
                public string Name { get; set; }
                public string TelemetryEventDesc { get; set; }
                public int DifficultyValue { get; set; }
                public double CareerScoreModifier { get; set; }
                public List<DifficultyConstant> DifficultyConstants { get; set; }
            }

            public class DifficultyConstant
            {
                public string ConstantType { get; set; }
                public string ConstantName { get; set; }
                public string ConstantValue { get; set; }
            }
        }

        public class StartData
        {
            public string TargetID { get; set; }
            public List<Instruction> Instructions { get; set; }
        }

        public StartData DeserializeStart(string filePath)
        {
            try
            {
                string json = File.ReadAllText(filePath);
                StartData startObject = JsonSerializer.Deserialize<StartData>(json);
                return startObject;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deserializing JSON: {ex.Message}");
                return null;
            }
        }
    }
}
