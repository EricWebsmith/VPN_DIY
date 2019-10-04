using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace VpnDiy
{
    public static class AwsCommandUtility
    {
        public static string Ssh(string publicDns)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.UseShellExecute = false;
            startInfo.WorkingDirectory = Config.Default.EC2WorkingFolder;
            startInfo.FileName = "ssh";
            startInfo.Arguments = $" -i \"{Config.Default.EC2PemFilename}\" ec2-user@{publicDns}";
            startInfo.RedirectStandardError = true;
            Process p = Process.Start(startInfo);
            using (StreamReader errorReader = p.StandardError)
            {
                string errorMessage = errorReader.ReadToEnd();
                if (!string.IsNullOrWhiteSpace(errorMessage))
                {
                    return errorMessage;
                }
            }
            return "SSH Closed";
        }

        public static string Start(string id)
        {
            string command = "ec2 start-instances --instance-ids " + id;
            return AwsCommandUtility.Call(command);
        }

        public static string Stop(string id)
        {
            string command = "ec2 stop-instances --instance-ids " + id;
            return AwsCommandUtility.Call(command);
        }

        public static string Call(string arguments)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "aws";
            startInfo.Arguments = arguments;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            Process p = Process.Start(startInfo);
            StreamReader sr = p.StandardOutput;
            string output = sr.ReadToEnd();
            return output;
        }

        public static string Call(string filename, string arguments)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = filename;
            startInfo.Arguments = arguments;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            Process p = Process.Start(startInfo);
            StreamReader sr = p.StandardOutput;
            string output = sr.ReadToEnd();
            return output;
        }

        public static List<Server> GetServers()
        {
            List<Server> servers = new List<Server>();
            string arguments = "ec2 describe-instances";
            string output = Call(arguments);

            var options = new JsonDocumentOptions
            {
                AllowTrailingCommas = true
            };

            using (JsonDocument document = JsonDocument.Parse(output, options))
            {
                foreach(var reservation in document.RootElement.GetProperty("Reservations").EnumerateArray())
                {
                    foreach(var instance in reservation.GetProperty("Instances").EnumerateArray())
                    {
                        Server server = new Server();
                        server.Id = instance.GetProperty("InstanceId").GetString();
                        server.Name = instance.GetProperty("Tags").EnumerateArray().First().GetProperty("Value").GetString();
                        server.State = instance.GetProperty("State").GetProperty("Name").GetString();
                        server.LaunchTime = instance.GetProperty("LaunchTime").GetDateTime();
                        server.LaunchTime = server.LaunchTime.ToLocalTime();
                        server.PublicDns = instance.GetProperty("PublicDnsName").GetString();
                        JsonElement ipElement;
                        if( instance.TryGetProperty("PublicIpAddress", out ipElement))
                        {
                            server.IP = ipElement.GetString();
                        }
                        
                        servers.Add(server);
                    }
                }
            }

            return servers;
        }
    }
}
