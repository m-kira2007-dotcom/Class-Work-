using Model.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data
{
    public class JsonShelterSerializer : BaseSerializer
    {
        public override string Extension => ".json";

        // Типы сохраняются прямо в строку JSON через маркер "$type"
        private readonly JsonSerializerSettings _settings = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.All,
            Formatting = Formatting.Indented
        };

        public override void Serialize(string filePath, Shelter[] data)
        {
            string json = JsonConvert.SerializeObject(data, _settings);
            File.WriteAllText(filePath, json);
        }

        public override Shelter[] Deserialize(string filePath)
        {
            if (!File.Exists(filePath)) return Array.Empty<Shelter>();
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Shelter[]>(json, _settings) ?? Array.Empty<Shelter>();
        }

        public override void SerializeSelection(string filePath, List<Pet> pets)
        {
            string json = JsonConvert.SerializeObject(pets, _settings);
            File.WriteAllText(filePath, json);
        }
    }
}
