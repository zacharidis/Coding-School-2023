using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Libs {
    public class Serializer {

        public void SerializeToFile(object obj, string fileName) {

            string jsonString = JsonSerializer.Serialize(obj);

            File.WriteAllText(fileName, jsonString);
        }

        public T DeserializeFromFile<T>(string fileName) {

            string jsonString = File.ReadAllText(fileName);

            T? obj = JsonSerializer.Deserialize<T>(jsonString);

            return obj;

        }


    }
}
