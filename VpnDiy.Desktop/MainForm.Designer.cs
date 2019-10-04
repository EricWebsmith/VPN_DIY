namespace VpnDiy.Desktop
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CopyIP = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RestartSS = new System.Windows.Forms.DataGridViewButtonColumn();
            this.launchTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Stop = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SSH = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.AutoRefreshToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.every30SecondsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.everyMinutetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastRefreshToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.awsGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pemTextBox = new System.Windows.Forms.TextBox();
            this.workingDirTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shadowsocksGroupBox = new System.Windows.Forms.GroupBox();
            this.shadowsocksFolderTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.awsGroupBox.SuspendLayout();
            this.shadowsocksGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.iPDataGridViewTextBoxColumn,
            this.CopyIP,
            this.RestartSS,
            this.launchTimeDataGridViewTextBoxColumn,
            this.Start,
            this.Stop,
            this.SSH});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(792, 109);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.Frozen = true;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.Frozen = true;
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iPDataGridViewTextBoxColumn
            // 
            this.iPDataGridViewTextBoxColumn.DataPropertyName = "IP";
            this.iPDataGridViewTextBoxColumn.Frozen = true;
            this.iPDataGridViewTextBoxColumn.HeaderText = "IP";
            this.iPDataGridViewTextBoxColumn.Name = "iPDataGridViewTextBoxColumn";
            this.iPDataGridViewTextBoxColumn.ReadOnly = true;
            this.iPDataGridViewTextBoxColumn.ToolTipText = "Ctrl+C to Copy";
            // 
            // CopyIP
            // 
            this.CopyIP.Frozen = true;
            this.CopyIP.HeaderText = "Copy IP";
            this.CopyIP.Name = "CopyIP";
            this.CopyIP.Text = "Copy IP";
            this.CopyIP.Width = 50;
            // 
            // RestartSS
            // 
            this.RestartSS.HeaderText = "RestartSS";
            this.RestartSS.Name = "RestartSS";
            this.RestartSS.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RestartSS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.RestartSS.ToolTipText = "Reconfigure Shadowsocks to use this IP and restart.";
            this.RestartSS.Width = 80;
            // 
            // launchTimeDataGridViewTextBoxColumn
            // 
            this.launchTimeDataGridViewTextBoxColumn.DataPropertyName = "LaunchTime";
            this.launchTimeDataGridViewTextBoxColumn.FillWeight = 150F;
            this.launchTimeDataGridViewTextBoxColumn.HeaderText = "LaunchTime";
            this.launchTimeDataGridViewTextBoxColumn.Name = "launchTimeDataGridViewTextBoxColumn";
            this.launchTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.launchTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // Start
            // 
            this.Start.FillWeight = 50F;
            this.Start.HeaderText = "Start";
            this.Start.Name = "Start";
            this.Start.ReadOnly = true;
            this.Start.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Start.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Start.Text = "Start";
            this.Start.UseColumnTextForButtonValue = true;
            this.Start.Width = 50;
            // 
            // Stop
            // 
            this.Stop.FillWeight = 50F;
            this.Stop.HeaderText = "Stop";
            this.Stop.Name = "Stop";
            this.Stop.ReadOnly = true;
            this.Stop.Text = "Stop";
            this.Stop.UseColumnTextForButtonValue = true;
            this.Stop.Width = 50;
            // 
            // SSH
            // 
            this.SSH.FillWeight = 50F;
            this.SSH.HeaderText = "SSH";
            this.SSH.Name = "SSH";
            this.SSH.ReadOnly = true;
            this.SSH.Text = "SSH...";
            this.SSH.UseColumnTextForButtonValue = true;
            this.SSH.Width = 50;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(VpnDiy.Server);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(12, 271);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(792, 181);
            this.resultTextBox.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // refreshToolStripButton
            // 

            this.refreshToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshToolStripButton.Name = "refreshToolStripButton";
            this.refreshToolStripButton.Size = new System.Drawing.Size(66, 22);
            this.refreshToolStripButton.Text = "Refresh";
            this.refreshToolStripButton.Click += new System.EventHandler(this.RefreshToolStripButton_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(78, 22);
            this.toolStripLabel1.Text = "Auto Refresh:";
            // 
            // AutoRefreshToolStripDropDownButton
            // 
            this.AutoRefreshToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.every30SecondsToolStripMenuItem,
            this.everyMinutetoolStripMenuItem,
            this.stopToolStripMenuItem});

            this.AutoRefreshToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AutoRefreshToolStripDropDownButton.Name = "AutoRefreshToolStripDropDownButton";
            this.AutoRefreshToolStripDropDownButton.Size = new System.Drawing.Size(126, 22);
            this.AutoRefreshToolStripDropDownButton.Text = "Every 30 Seconds";
            // 
            // every30SecondsToolStripMenuItem
            // 
            this.every30SecondsToolStripMenuItem.Name = "every30SecondsToolStripMenuItem";
            this.every30SecondsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.every30SecondsToolStripMenuItem.Text = "Every 30 Seconds";
            this.every30SecondsToolStripMenuItem.Click += new System.EventHandler(this.Every30SecondsToolStripMenuItem_Click);
            // 
            // everyMinutetoolStripMenuItem
            // 
            this.everyMinutetoolStripMenuItem.Name = "everyMinutetoolStripMenuItem";
            this.everyMinutetoolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.everyMinutetoolStripMenuItem.Text = "Every Minute";
            this.everyMinutetoolStripMenuItem.Click += new System.EventHandler(this.EveryMinutetoolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.StopToolStripMenuItem_Click);
            // 
            // lastRefreshToolStripLabel
            // 
            this.lastRefreshToolStripLabel.Name = "lastRefreshToolStripLabel";
            this.lastRefreshToolStripLabel.Size = new System.Drawing.Size(55, 22);
            this.lastRefreshToolStripLabel.Text = "Updated:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripButton,
            this.toolStripLabel1,
            this.AutoRefreshToolStripDropDownButton,
            this.lastRefreshToolStripLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(813, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // awsGroupBox
            // 
            this.awsGroupBox.Controls.Add(this.label2);
            this.awsGroupBox.Controls.Add(this.pemTextBox);
            this.awsGroupBox.Controls.Add(this.workingDirTextBox);
            this.awsGroupBox.Controls.Add(this.label1);
            this.awsGroupBox.Location = new System.Drawing.Point(12, 28);
            this.awsGroupBox.Name = "awsGroupBox";
            this.awsGroupBox.Size = new System.Drawing.Size(792, 76);
            this.awsGroupBox.TabIndex = 7;
            this.awsGroupBox.TabStop = false;
            this.awsGroupBox.Text = "AWS EC2 Settings (Ignore it if you don\'t use ssh)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pem Filename:";
            // 
            // pemTextBox
            // 
            this.pemTextBox.Location = new System.Drawing.Point(206, 47);
            this.pemTextBox.Name = "pemTextBox";
            this.pemTextBox.Size = new System.Drawing.Size(580, 20);
            this.pemTextBox.TabIndex = 6;
            this.pemTextBox.Leave += new System.EventHandler(this.settingsTextbox_Leave);
            // 
            // workingDirTextBox
            // 
            this.workingDirTextBox.Location = new System.Drawing.Point(206, 21);
            this.workingDirTextBox.Name = "workingDirTextBox";
            this.workingDirTextBox.Size = new System.Drawing.Size(580, 20);
            this.workingDirTextBox.TabIndex = 5;
            this.workingDirTextBox.Leave += new System.EventHandler(this.settingsTextbox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Working Directory(where the pem file is)";
            // 
            // shadowsocksGroupBox
            // 
            this.shadowsocksGroupBox.Controls.Add(this.shadowsocksFolderTextBox);
            this.shadowsocksGroupBox.Controls.Add(this.label3);
            this.shadowsocksGroupBox.Location = new System.Drawing.Point(12, 110);
            this.shadowsocksGroupBox.Name = "shadowsocksGroupBox";
            this.shadowsocksGroupBox.Size = new System.Drawing.Size(792, 40);
            this.shadowsocksGroupBox.TabIndex = 8;
            this.shadowsocksGroupBox.TabStop = false;
            this.shadowsocksGroupBox.Text = "Shadowsocks";
            // 
            // shadowsocksFolderTextBox
            // 
            this.shadowsocksFolderTextBox.Location = new System.Drawing.Point(206, 13);
            this.shadowsocksFolderTextBox.Name = "shadowsocksFolderTextBox";
            this.shadowsocksFolderTextBox.Size = new System.Drawing.Size(580, 20);
            this.shadowsocksFolderTextBox.TabIndex = 1;
            this.shadowsocksFolderTextBox.Leave += new System.EventHandler(this.settingsTextbox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Shadowsocks Folder:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 461);
            this.Controls.Add(this.shadowsocksGroupBox);
            this.Controls.Add(this.awsGroupBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.dataGridView1);
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "AWS EC2 & Shadowsocks Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.awsGroupBox.ResumeLayout(false);
            this.awsGroupBox.PerformLayout();
            this.shadowsocksGroupBox.ResumeLayout(false);
            this.shadowsocksGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripDropDownButton AutoRefreshToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem every30SecondsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem everyMinutetoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel lastRefreshToolStripLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox awsGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pemTextBox;
        private System.Windows.Forms.TextBox workingDirTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox shadowsocksGroupBox;
        private System.Windows.Forms.TextBox shadowsocksFolderTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn CopyIP;
        private System.Windows.Forms.DataGridViewButtonColumn RestartSS;
        private System.Windows.Forms.DataGridViewTextBoxColumn launchTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Start;
        private System.Windows.Forms.DataGridViewButtonColumn Stop;
        private System.Windows.Forms.DataGridViewButtonColumn SSH;
    }
}

