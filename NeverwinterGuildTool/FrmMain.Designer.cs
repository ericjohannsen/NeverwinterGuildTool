namespace NeverwinterGuildTool
{
    partial class FrmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGuildFilePath = new System.Windows.Forms.TextBox();
            this.btnPickGuildExport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtKickOlderThan = new System.Windows.Forms.DateTimePicker();
            this.btnGenKick = new System.Windows.Forms.Button();
            this.txtKickCommands = new System.Windows.Forms.TextBox();
            this.lblAccountAge = new System.Windows.Forms.Label();
            this.chkShowInfo = new System.Windows.Forms.CheckBox();
            this.btn30 = new System.Windows.Forms.Button();
            this.btn90 = new System.Windows.Forms.Button();
            this.btn60 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guild Export File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(102, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "from e.g. /ExportGuildMemberList C:\\Temp\\MyGuild.csv";
            // 
            // txtGuildFilePath
            // 
            this.txtGuildFilePath.Location = new System.Drawing.Point(16, 29);
            this.txtGuildFilePath.Name = "txtGuildFilePath";
            this.txtGuildFilePath.Size = new System.Drawing.Size(401, 20);
            this.txtGuildFilePath.TabIndex = 2;
            this.txtGuildFilePath.TextChanged += new System.EventHandler(this.txtGuildFilePath_TextChanged);
            // 
            // btnPickGuildExport
            // 
            this.btnPickGuildExport.Location = new System.Drawing.Point(424, 29);
            this.btnPickGuildExport.Name = "btnPickGuildExport";
            this.btnPickGuildExport.Size = new System.Drawing.Size(30, 20);
            this.btnPickGuildExport.TabIndex = 3;
            this.btnPickGuildExport.Text = "...";
            this.btnPickGuildExport.UseVisualStyleBackColor = true;
            this.btnPickGuildExport.Click += new System.EventHandler(this.btnPickGuildExport_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kick accounts inactive for";
            // 
            // dtKickOlderThan
            // 
            this.dtKickOlderThan.Location = new System.Drawing.Point(16, 72);
            this.dtKickOlderThan.Name = "dtKickOlderThan";
            this.dtKickOlderThan.Size = new System.Drawing.Size(200, 20);
            this.dtKickOlderThan.TabIndex = 5;
            this.dtKickOlderThan.ValueChanged += new System.EventHandler(this.dtKickOlderThan_ValueChanged);
            // 
            // btnGenKick
            // 
            this.btnGenKick.Enabled = false;
            this.btnGenKick.Location = new System.Drawing.Point(16, 110);
            this.btnGenKick.Name = "btnGenKick";
            this.btnGenKick.Size = new System.Drawing.Size(200, 23);
            this.btnGenKick.TabIndex = 6;
            this.btnGenKick.Text = "Generate &Kick Commands";
            this.btnGenKick.UseVisualStyleBackColor = true;
            this.btnGenKick.Click += new System.EventHandler(this.btnGenKick_Click);
            // 
            // txtKickCommands
            // 
            this.txtKickCommands.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKickCommands.Location = new System.Drawing.Point(19, 140);
            this.txtKickCommands.Multiline = true;
            this.txtKickCommands.Name = "txtKickCommands";
            this.txtKickCommands.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKickCommands.Size = new System.Drawing.Size(823, 241);
            this.txtKickCommands.TabIndex = 7;
            // 
            // lblAccountAge
            // 
            this.lblAccountAge.AutoSize = true;
            this.lblAccountAge.Location = new System.Drawing.Point(222, 73);
            this.lblAccountAge.Name = "lblAccountAge";
            this.lblAccountAge.Size = new System.Drawing.Size(38, 13);
            this.lblAccountAge.TabIndex = 8;
            this.lblAccountAge.Text = "0 days";
            // 
            // chkShowInfo
            // 
            this.chkShowInfo.AutoSize = true;
            this.chkShowInfo.Location = new System.Drawing.Point(234, 114);
            this.chkShowInfo.Name = "chkShowInfo";
            this.chkShowInfo.Size = new System.Drawing.Size(199, 17);
            this.chkShowInfo.TabIndex = 9;
            this.chkShowInfo.Text = "Show info instead of kick commands";
            this.chkShowInfo.UseVisualStyleBackColor = true;
            // 
            // btn30
            // 
            this.btn30.Location = new System.Drawing.Point(283, 73);
            this.btn30.Name = "btn30";
            this.btn30.Size = new System.Drawing.Size(58, 23);
            this.btn30.TabIndex = 10;
            this.btn30.Text = "30 days";
            this.btn30.UseVisualStyleBackColor = true;
            this.btn30.Click += new System.EventHandler(this.btn30_Click);
            // 
            // btn90
            // 
            this.btn90.Location = new System.Drawing.Point(411, 73);
            this.btn90.Name = "btn90";
            this.btn90.Size = new System.Drawing.Size(58, 23);
            this.btn90.TabIndex = 11;
            this.btn90.Text = "90 days";
            this.btn90.UseVisualStyleBackColor = true;
            this.btn90.Click += new System.EventHandler(this.btn90_Click);
            // 
            // btn60
            // 
            this.btn60.Location = new System.Drawing.Point(347, 73);
            this.btn60.Name = "btn60";
            this.btn60.Size = new System.Drawing.Size(58, 23);
            this.btn60.TabIndex = 12;
            this.btn60.Text = "60 days";
            this.btn60.UseVisualStyleBackColor = true;
            this.btn60.Click += new System.EventHandler(this.btn60_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 393);
            this.Controls.Add(this.btn60);
            this.Controls.Add(this.btn90);
            this.Controls.Add(this.btn30);
            this.Controls.Add(this.chkShowInfo);
            this.Controls.Add(this.lblAccountAge);
            this.Controls.Add(this.txtKickCommands);
            this.Controls.Add(this.btnGenKick);
            this.Controls.Add(this.dtKickOlderThan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPickGuildExport);
            this.Controls.Add(this.txtGuildFilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neverwinter Guild Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGuildFilePath;
        private System.Windows.Forms.Button btnPickGuildExport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtKickOlderThan;
        private System.Windows.Forms.Button btnGenKick;
        private System.Windows.Forms.TextBox txtKickCommands;
        private System.Windows.Forms.Label lblAccountAge;
        private System.Windows.Forms.CheckBox chkShowInfo;
        private System.Windows.Forms.Button btn30;
        private System.Windows.Forms.Button btn90;
        private System.Windows.Forms.Button btn60;
    }
}

