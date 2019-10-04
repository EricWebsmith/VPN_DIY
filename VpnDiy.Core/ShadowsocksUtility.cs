using System.Diagnostics;
using System.IO;
using System.Text.Json;

namespace VpnDiy
{
    public static class ShadowsocksUtility
    {
        public static string WorkingFolder { get; set; }

        public static void Restart(string ip)
        {
            //step 1 close shadowsocks
            var processes = Process.GetProcessesByName("Shadowsocks");

            foreach (Process proc in processes)
            {
                proc.CloseMainWindow();
                proc.Kill();
            }

            //step 2 reconfigure shadowsocks

            var options = new JsonDocumentOptions
            {
                AllowTrailingCommas = true
            };


            JsonDocument jdoc = null;
            string jsonString = string.Empty;

            using (StreamReader reader = new StreamReader(System.IO.Path.Combine(WorkingFolder, "gui-config.json")))
            {
                jsonString = reader.ReadToEnd();
                jdoc = JsonDocument.Parse(jsonString, options);
                
            }

            var oldIp=jdoc.RootElement.GetProperty("configs").EnumerateArray().Current.GetProperty("server").GetString();
            jsonString=jsonString.Replace(oldIp, ip);


            using (StreamWriter writer = new StreamWriter(System.IO.Path.Combine(WorkingFolder, "gui-config.json")))
            {
                writer.Write(jsonString);
            }

            //step 3 start shadowsocks
            var shadowsocksInfo = new ProcessStartInfo();
            shadowsocksInfo.WorkingDirectory = WorkingFolder;
            shadowsocksInfo.FileName = "Shadowsocks.exe";
            shadowsocksInfo.CreateNoWindow = true;
            var shadowsocks = new Process();
            shadowsocks.StartInfo = shadowsocksInfo;
            shadowsocks.Start();
        }
    }
}
