namespace Squad.Admin.Console.Forms
{
    partial class frmMainConsole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainConsole));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpPlayerList = new System.Windows.Forms.GroupBox();
            this.grdPlayers = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grpConsole = new System.Windows.Forms.GroupBox();
            this.btnClearConsole = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstHistory = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.txtServerPort = new System.Windows.Forms.MaskedTextBox();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRconPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblConnectedTo = new System.Windows.Forms.Label();
            this.lblMapLabel = new System.Windows.Forms.Label();
            this.lblMapName = new System.Windows.Forms.Label();
            this.playerCountLabel = new System.Windows.Forms.Label();
            this.lblPlayerCount = new System.Windows.Forms.Label();
            this.PlayerCount = new System.Windows.Forms.Label();
            this.cSlot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPlayer = new System.Windows.Forms.DataGridViewLinkColumn();
            this.cSteam64Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDisconnect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipsMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpPlayerList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPlayers)).BeginInit();
            this.grpConsole.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grpPlayerList
            // 
            this.grpPlayerList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpPlayerList.Controls.Add(this.PlayerCount);
            this.grpPlayerList.Controls.Add(this.grdPlayers);
            this.grpPlayerList.Controls.Add(this.playerCountLabel);
            this.grpPlayerList.Controls.Add(this.btnRefresh);
            this.grpPlayerList.Enabled = false;
            this.grpPlayerList.Location = new System.Drawing.Point(12, 105);
            this.grpPlayerList.Name = "grpPlayerList";
            this.grpPlayerList.Size = new System.Drawing.Size(639, 621);
            this.grpPlayerList.TabIndex = 0;
            this.grpPlayerList.TabStop = false;
            this.grpPlayerList.Text = "玩家列表";
            // 
            // grdPlayers
            // 
            this.grdPlayers.AllowUserToAddRows = false;
            this.grdPlayers.AllowUserToDeleteRows = false;
            this.grdPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grdPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cSlot,
            this.cPlayer,
            this.cSteam64Id,
            this.cStatus,
            this.cDisconnect});
            this.grdPlayers.Location = new System.Drawing.Point(9, 42);
            this.grdPlayers.Name = "grdPlayers";
            this.grdPlayers.ReadOnly = true;
            this.grdPlayers.Size = new System.Drawing.Size(624, 534);
            this.grdPlayers.TabIndex = 11;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.Location = new System.Drawing.Point(482, 582);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(151, 33);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "刷新玩家列表";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // grpConsole
            // 
            this.grpConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpConsole.Controls.Add(this.btnClearConsole);
            this.grpConsole.Controls.Add(this.label2);
            this.grpConsole.Controls.Add(this.lstHistory);
            this.grpConsole.Controls.Add(this.label1);
            this.grpConsole.Controls.Add(this.btnClear);
            this.grpConsole.Controls.Add(this.btnSend);
            this.grpConsole.Controls.Add(this.txtResponse);
            this.grpConsole.Controls.Add(this.txtCommand);
            this.grpConsole.Enabled = false;
            this.grpConsole.Location = new System.Drawing.Point(657, 105);
            this.grpConsole.Name = "grpConsole";
            this.grpConsole.Size = new System.Drawing.Size(481, 621);
            this.grpConsole.TabIndex = 0;
            this.grpConsole.TabStop = false;
            this.grpConsole.Text = "控制台";
            // 
            // btnClearConsole
            // 
            this.btnClearConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearConsole.Location = new System.Drawing.Point(366, 582);
            this.btnClearConsole.Name = "btnClearConsole";
            this.btnClearConsole.Size = new System.Drawing.Size(109, 33);
            this.btnClearConsole.TabIndex = 8;
            this.btnClearConsole.Text = "清空控制台日志";
            this.btnClearConsole.UseVisualStyleBackColor = true;
            this.btnClearConsole.Click += new System.EventHandler(this.btnClearConsole_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "指令记录 (双击再次执行)";
            // 
            // lstHistory
            // 
            this.lstHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstHistory.FormattingEnabled = true;
            this.lstHistory.ItemHeight = 12;
            this.lstHistory.Location = new System.Drawing.Point(6, 100);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(469, 136);
            this.lstHistory.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "服务器控制台输出";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(366, 241);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 33);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "清除记录";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(366, 42);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(109, 33);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "发送指令";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtResponse
            // 
            this.txtResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResponse.BackColor = System.Drawing.Color.Black;
            this.txtResponse.ForeColor = System.Drawing.Color.Lime;
            this.txtResponse.Location = new System.Drawing.Point(6, 299);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ReadOnly = true;
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResponse.Size = new System.Drawing.Size(469, 278);
            this.txtResponse.TabIndex = 7;
            // 
            // txtCommand
            // 
            this.txtCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCommand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCommand.Location = new System.Drawing.Point(6, 18);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(469, 21);
            this.txtCommand.TabIndex = 1;
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(1098, 11);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(40, 37);
            this.btnSettings.TabIndex = 11;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtServerIP);
            this.panel1.Controls.Add(this.txtServerPort);
            this.panel1.Controls.Add(this.chkShowPassword);
            this.panel1.Controls.Add(this.btnDisconnect);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.txtDisplayName);
            this.panel1.Controls.Add(this.lblDisplayName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtRconPassword);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 89);
            this.panel1.TabIndex = 0;
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(278, 9);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(102, 21);
            this.txtServerIP.TabIndex = 2;
            // 
            // txtServerPort
            // 
            this.txtServerPort.Location = new System.Drawing.Point(424, 9);
            this.txtServerPort.Mask = "#####";
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(49, 21);
            this.txtServerPort.TabIndex = 4;
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Location = new System.Drawing.Point(394, 33);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(72, 16);
            this.chkShowPassword.TabIndex = 9;
            this.chkShowPassword.Text = "显示密码";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(515, 44);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(109, 33);
            this.btnDisconnect.TabIndex = 10;
            this.btnDisconnect.Text = "断开连接";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Enabled = false;
            this.btnConnect.Location = new System.Drawing.Point(515, 6);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(109, 33);
            this.btnConnect.TabIndex = 9;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(278, 55);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(162, 21);
            this.txtDisplayName.TabIndex = 8;
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Location = new System.Drawing.Point(188, 58);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(71, 12);
            this.lblDisplayName.TabIndex = 7;
            this.lblDisplayName.Text = "管理员名称:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "密码:";
            // 
            // txtRconPassword
            // 
            this.txtRconPassword.Location = new System.Drawing.Point(278, 31);
            this.txtRconPassword.Name = "txtRconPassword";
            this.txtRconPassword.Size = new System.Drawing.Size(102, 21);
            this.txtRconPassword.TabIndex = 6;
            this.txtRconPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "端口:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "服务器 IP:";
            // 
            // lblConnectedTo
            // 
            this.lblConnectedTo.AutoSize = true;
            this.lblConnectedTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectedTo.Location = new System.Drawing.Point(663, 11);
            this.lblConnectedTo.Name = "lblConnectedTo";
            this.lblConnectedTo.Size = new System.Drawing.Size(0, 17);
            this.lblConnectedTo.TabIndex = 12;
            // 
            // lblMapLabel
            // 
            this.lblMapLabel.AutoSize = true;
            this.lblMapLabel.Location = new System.Drawing.Point(663, 38);
            this.lblMapLabel.Name = "lblMapLabel";
            this.lblMapLabel.Size = new System.Drawing.Size(59, 12);
            this.lblMapLabel.TabIndex = 13;
            this.lblMapLabel.Text = "当前地图:";
            this.lblMapLabel.Visible = false;
            // 
            // lblMapName
            // 
            this.lblMapName.AutoSize = true;
            this.lblMapName.Location = new System.Drawing.Point(737, 38);
            this.lblMapName.Name = "lblMapName";
            this.lblMapName.Size = new System.Drawing.Size(0, 12);
            this.lblMapName.TabIndex = 14;
            // 
            // playerCountLabel
            // 
            this.playerCountLabel.AutoSize = true;
            this.playerCountLabel.Location = new System.Drawing.Point(316, 21);
            this.playerCountLabel.Name = "playerCountLabel";
            this.playerCountLabel.Size = new System.Drawing.Size(53, 12);
            this.playerCountLabel.TabIndex = 15;
            this.playerCountLabel.Text = "玩家数: ";
            // 
            // lblPlayerCount
            // 
            this.lblPlayerCount.AutoSize = true;
            this.lblPlayerCount.Location = new System.Drawing.Point(739, 56);
            this.lblPlayerCount.Name = "lblPlayerCount";
            this.lblPlayerCount.Size = new System.Drawing.Size(0, 12);
            this.lblPlayerCount.TabIndex = 16;
            // 
            // PlayerCount
            // 
            this.PlayerCount.AutoSize = true;
            this.PlayerCount.Location = new System.Drawing.Point(363, 21);
            this.PlayerCount.Name = "PlayerCount";
            this.PlayerCount.Size = new System.Drawing.Size(11, 12);
            this.PlayerCount.TabIndex = 16;
            this.PlayerCount.Text = "0";
            // 
            // cSlot
            // 
            this.cSlot.HeaderText = "ID";
            this.cSlot.Name = "cSlot";
            this.cSlot.ReadOnly = true;
            this.cSlot.Width = 40;
            // 
            // cPlayer
            // 
            this.cPlayer.HeaderText = "玩家名称";
            this.cPlayer.Name = "cPlayer";
            this.cPlayer.ReadOnly = true;
            this.cPlayer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cPlayer.Width = 160;
            // 
            // cSteam64Id
            // 
            this.cSteam64Id.HeaderText = "Steam 64";
            this.cSteam64Id.Name = "cSteam64Id";
            this.cSteam64Id.ReadOnly = true;
            this.cSteam64Id.Width = 165;
            // 
            // cStatus
            // 
            this.cStatus.HeaderText = "状态";
            this.cStatus.Name = "cStatus";
            this.cStatus.ReadOnly = true;
            // 
            // cDisconnect
            // 
            this.cDisconnect.HeaderText = "断开连接时间";
            this.cDisconnect.Name = "cDisconnect";
            this.cDisconnect.ReadOnly = true;
            // 
            // TipsMsg
            // 
            this.TipsMsg.AutoSize = true;
            this.TipsMsg.Location = new System.Drawing.Point(661, 77);
            this.TipsMsg.Name = "TipsMsg";
            this.TipsMsg.Size = new System.Drawing.Size(0, 12);
            this.TipsMsg.TabIndex = 17;
            // 
            // frmMainConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 738);
            this.Controls.Add(this.TipsMsg);
            this.Controls.Add(this.lblPlayerCount);
            this.Controls.Add(this.lblMapName);
            this.Controls.Add(this.lblMapLabel);
            this.Controls.Add(this.lblConnectedTo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.grpConsole);
            this.Controls.Add(this.grpPlayerList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainConsole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Squad 服务器 RCON 管理";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpPlayerList.ResumeLayout(false);
            this.grpPlayerList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPlayers)).EndInit();
            this.grpConsole.ResumeLayout(false);
            this.grpConsole.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpPlayerList;
        private System.Windows.Forms.GroupBox grpConsole;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdPlayers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstHistory;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRconPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.MaskedTextBox txtServerPort;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.Button btnClearConsole;
        private System.Windows.Forms.Label lblConnectedTo;
        private System.Windows.Forms.Label lblMapLabel;
        private System.Windows.Forms.Label lblMapName;
        private System.Windows.Forms.Label playerCountLabel;
        private System.Windows.Forms.Label lblPlayerCount;
        private System.Windows.Forms.Label PlayerCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSlot;
        private System.Windows.Forms.DataGridViewLinkColumn cPlayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSteam64Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDisconnect;
        private System.Windows.Forms.Label TipsMsg;
    }
}