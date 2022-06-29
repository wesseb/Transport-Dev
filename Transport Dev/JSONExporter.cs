using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Transport_Dev
{
    public class dbConfig
    {
        public string? hostName { get; set; }
        public int port { get; set; }
        public string? DBname { get; set; }
        public string? userName { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? password { get; set; }
    }

    public class JSONExporter
    {
        private const string jsonFileName = @"config.json";
        
        public static void saveConfigToJSON(string? hostName, int port, string? DBname, string? userName, string? password = null)
        {
            try
            {
                using (FileStream fs = File.Open(jsonFileName, FileMode.OpenOrCreate))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    dbConfig db = new dbConfig
                    {
                        hostName = hostName,
                        port = port,
                        DBname = DBname,
                        userName = userName,
                        password = password != null ? AesEncrypter.EncryptToAesAndOutput(password) : null
                    };

                    JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };

                    string finalOutput = JsonSerializer.Serialize(db, options);


                    //TODO: Poprawienie zapisu pliku (modyfikacji)
                    sw.WriteLine(finalOutput);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }
    }
}
