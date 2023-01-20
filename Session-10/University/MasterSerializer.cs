using System.Text.Json;

namespace University
{
    public class MasterSerializer
    {
        public void Serialize(object obj)
        {
            string jsonString = JsonSerializer.Serialize(obj);
        }


        public void SerializeToFile(object obj, string fileName)
        {

            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(obj, options);

            File.WriteAllText(fileName, jsonString);
        }


        public T Deserialize<T>(string fileName)
        {

            string jsonString = File.ReadAllText(fileName);
            T? obj = JsonSerializer.Deserialize<T>(jsonString);

            return obj;
        }

    }
}