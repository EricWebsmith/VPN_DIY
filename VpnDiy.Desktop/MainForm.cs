using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VpnDiy.Desktop
{
    public partial class MainForm : Form
    {
        Config config = Config.Default;

        private List<Server> servers = null;
        private Dictionary<string, ServerExtension> extenstions = new Dictionary<string, ServerExtension>();
        private Dictionary<string, int> col_name_index_dict = new Dictionary<string, int>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.workingDirTextBox.Text = config.EC2WorkingFolder;
            this.pemTextBox.Text = config.EC2PemFilename;
            this.shadowsocksFolderTextBox.Text = config.ShadowsocksWorkingFolder;

            foreach(DataGridViewColumn col in dataGridView1.Columns)
            {
                col_name_index_dict[col.Name] = col.Index;
            }
            Refresh();
            timer1.Start();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;


            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var copy_cell = senderGrid.Rows[e.RowIndex].Cells["CopyIP"] as DataGridViewButtonCell;
                var restart_cell = senderGrid.Rows[e.RowIndex].Cells["RestartSS"] as DataGridViewButtonCell;
                var server = servers[e.RowIndex];
                var extension = extenstions[server.Id];

                if (senderGrid.Columns[e.ColumnIndex].Name == "CopyIP")
                {
                    if (!string.IsNullOrWhiteSpace(servers[e.RowIndex].IP))
                    {
                        Clipboard.SetText(servers[e.RowIndex].IP);
                        extension.IpCopied = true;
                        
                        copy_cell.Value = "Copied";
                    }
                }

                if (senderGrid.Columns[e.ColumnIndex].Name == "RestartSS")
                {
                    if (!string.IsNullOrWhiteSpace(servers[e.RowIndex].IP))
                    {
                        Clipboard.SetText(servers[e.RowIndex].IP);
                        ShadowsocksUtility.Restart(server.IP);
                        extension.ShadowsocksRestarted = true;
                        restart_cell.Value = "Restarted";
                    }
                }

                if (senderGrid.Columns[e.ColumnIndex].Name == "Start")
                {
                    string command = "ec2 start-instances --instance-ids " + servers[e.RowIndex].Id;
                    string result = AwsCommandUtility.Call(command);
                    resultTextBox.Text += "\r\n" + result;
                    Refresh();
                }

                if (senderGrid.Columns[e.ColumnIndex].Name == "Stop")
                {
                    string command = "ec2 stop-instances --instance-ids " + servers[e.RowIndex].Id;
                    string result = AwsCommandUtility.Call(command);
                    resultTextBox.Text = result;
                    extension.IpCopied = false;
                    extension.ShadowsocksRestarted = false;
                    Refresh();
                }

                if (senderGrid.Columns[e.ColumnIndex].Name == "SSH")
                {
                    string result = AwsCommandUtility.Ssh(servers[e.RowIndex].PublicDns);
                    resultTextBox.Text = result;
                }
            }
        }

        private void Refresh()
        {
            servers = AwsCommandUtility.GetServers();
            bindingSource1.DataSource = servers;
            lastRefreshToolStripLabel.Text = "Last Refreshed: " + DateTime.Now.ToString();

            //Fix extensions
            foreach(Server ec2 in servers )
            {
                if(!extenstions.ContainsKey(ec2.Id))
                {
                    extenstions.Add(ec2.Id,new ServerExtension());
                }
            }

            for(int i=0;i< servers.Count;i++)
            {
                var id = servers[i].Id;
                var copy_cell = dataGridView1.Rows[i].Cells["CopyIP"] as DataGridViewButtonCell;
                copy_cell.Value = extenstions[id].IpCopied?"Copied":"";
                var restart_cell = dataGridView1.Rows[i].Cells["RestartSS"] as DataGridViewButtonCell;
                restart_cell.Value = extenstions[id].IpCopied ? "Restarted" : "";
            }
        }

        private void RefreshToolStripButton_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Every30SecondsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 30000;
            timer1.Start();
            AutoRefreshToolStripDropDownButton.Text = "Every 30 Seconds";
        }

        private void EveryMinutetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 60000;
            timer1.Start();
            AutoRefreshToolStripDropDownButton.Text = "Every Minute";
        }

        private void StopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            AutoRefreshToolStripDropDownButton.Text = "Stop";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void settingsTextbox_Leave(object sender, EventArgs e)
        {
            config.EC2PemFilename = this.pemTextBox.Text;
            config.EC2WorkingFolder = this.workingDirTextBox.Text;
            config.ShadowsocksWorkingFolder = this.shadowsocksFolderTextBox.Text;
            config.Save();
        }
    }
}
