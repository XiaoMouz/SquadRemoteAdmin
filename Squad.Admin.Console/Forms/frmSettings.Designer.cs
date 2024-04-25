namespace Squad.Admin.Console.Forms
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpWKBReasons = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cboMessageTypes = new System.Windows.Forms.ComboBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.grpWKBReasons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Enabled = false;
            this.btnApply.Location = new System.Drawing.Point(514, 405);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(109, 33);
            this.btnApply.TabIndex = 10;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(629, 405);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 33);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpWKBReasons
            // 
            this.grpWKBReasons.Controls.Add(this.dataGridView1);
            this.grpWKBReasons.Controls.Add(this.cboMessageTypes);
            this.grpWKBReasons.Location = new System.Drawing.Point(13, 94);
            this.grpWKBReasons.Name = "grpWKBReasons";
            this.grpWKBReasons.Size = new System.Drawing.Size(725, 306);
            this.grpWKBReasons.TabIndex = 12;
            this.grpWKBReasons.TabStop = false;
            this.grpWKBReasons.Text = "警告消息 或 踢出/封禁 理由";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(713, 256);
            this.dataGridView1.TabIndex = 1;
            // 
            // cboMessageTypes
            // 
            this.cboMessageTypes.FormattingEnabled = true;
            this.cboMessageTypes.Location = new System.Drawing.Point(534, 18);
            this.cboMessageTypes.Name = "cboMessageTypes";
            this.cboMessageTypes.Size = new System.Drawing.Size(185, 20);
            this.cboMessageTypes.TabIndex = 0;
            this.cboMessageTypes.Text = "请选择分区";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(13, 8);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(239, 12);
            this.lblInstructions.TabIndex = 13;
            this.lblInstructions.Text = "在这里编写你的警告消息 或 踢出/封禁理由";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "在消息中这些关键字会被自动替换";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "PLAYERNAME - 此字符串会被替换为被操作的玩家名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(377, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "ADMINNAME - 这段会被替换为管理员名称，管理员名称请在连接时设置";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(419, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "如果你未提供名称就连接到服务端，\"ADMINNAME\" 将会被替换成 \"RCON Admin\"";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.grpWKBReasons);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "服务器 RCON 管理 - 操作设置";
            this.grpWKBReasons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpWKBReasons;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cboMessageTypes;
        private System.Windows.Forms.Label label4;
        private System.IO.Ports.SerialPort serialPort1;
    }
}