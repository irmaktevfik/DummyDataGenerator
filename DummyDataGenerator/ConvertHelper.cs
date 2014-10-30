using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyDataGenerator
{
    public class ConvertHelper
    {
        public static List<Dictionary<string, string>> GetProperties(string[] files)
        {
            List<Dictionary<string, string>> dataToReturn = new List<Dictionary<string, string>>();
            List<Dictionary<string, string>> parsedData;
            foreach (var file in files)
            {
                StringBuilder sb = new StringBuilder();
                using (StreamReader sr = new StreamReader(file))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        sb.AppendLine(line);
                    }
                }
                string allines = sb.ToString();
                //string result = @"{ ""data"" : [" + allines + "]}";
                try
                {
                    parsedData = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(allines);
                }
                catch (JsonSerializationException)
                {
                    parsedData = null;
                }
                dataToReturn.AddRange(parsedData);
            }
            return dataToReturn;
        }
    }
}
