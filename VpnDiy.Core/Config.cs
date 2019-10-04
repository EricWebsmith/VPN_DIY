using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace VpnDiy
{
    [Serializable]
    public class Config
    {
        public string EC2WorkingFolder { get; set; }

        public string EC2PemFilename { get; set; }

        public string ShadowsocksWorkingFolder { get; set; }

        private static Config _default = null;

        public static Config Default
        {
            get
            {
                if(_default == null)
                {
                    _default = Load();
                }
                return _default;
            }
        }

        private Config()
        {

        }

        public void Save()
        {
            string jsonString = JsonSerializer.Serialize(this);
            using (StreamWriter sw = new StreamWriter("config.json"))
            {
                sw.Write(jsonString);
            }
        }

        private static Config Load()
        {
            if (!File.Exists("config.json"))
            {
                return new Config();
            }

            using (StreamReader sr = new StreamReader("config.json"))
            {
                string jsonString = sr.ReadToEnd();
                return JsonSerializer.Deserialize<Config>(jsonString);
            }
        }

    }
}
