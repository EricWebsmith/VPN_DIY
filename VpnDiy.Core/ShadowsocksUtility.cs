using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Linq;

namespace VpnDiy
{
    public static class ShadowsocksUtility
    {

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
            string oldIp = string.Empty;

            using (StreamReader reader = new StreamReader(System.IO.Path.Combine(Config.Default.ShadowsocksWorkingFolder, "gui-config.json")))
            {
                jsonString = reader.ReadToEnd();
                jdoc = JsonDocument.Parse(jsonString, options);
                oldIp = jdoc.RootElement.GetProperty("configs").EnumerateArray().First().GetProperty("server").GetString();
                jsonString = jsonString.Replace(oldIp, ip);
            }
            
            using (StreamWriter writer = new StreamWriter(System.IO.Path.Combine(Config.Default.ShadowsocksWorkingFolder, "gui-config.json")))
            {
                writer.Write(jsonString);
            }

            //step 3 start shadowsocks
            var shadowsocksInfo = new ProcessStartInfo();
            shadowsocksInfo.WorkingDirectory = Config.Default.ShadowsocksWorkingFolder;
            shadowsocksInfo.FileName = System.IO.Path.Combine(Config.Default.ShadowsocksWorkingFolder, "Shadowsocks.exe");
            shadowsocksInfo.CreateNoWindow = true;
            var shadowsocks = new Process();
            shadowsocks.StartInfo = shadowsocksInfo;
            shadowsocks.Start();
        }
    }
}
