using System;
using System.IO;
using Newtonsoft.Json;

namespace SerializationHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Console.ReadLine();

            string jsonAsString = string.Empty;

            try
            {
                using (var stream = File.OpenText(path))
                {
                    jsonAsString = stream.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            var resultObject = JsonConvert.DeserializeObject<Response>(jsonAsString);

        }
    }
}
