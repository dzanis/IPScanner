namespace IPScanner
{
	partial class IPScannerForm
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
            this.lvIPList = new System.Windows.Forms.ListView();
            this.chIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPing = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRecognized = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ipFrom = new IPAddressControlLib.IPAddressControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ipTo = new IPAddressControlLib.IPAddressControl();
            this.viewall = new System.Windows.Forms.CheckBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvIPList
            // 
            this.lvIPList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvIPList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvIPList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chIP,
            this.chPing,
            this.chHost,
            this.chRecognized});
            this.lvIPList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvIPList.FullRowSelect = true;
            this.lvIPList.GridLines = true;
            this.lvIPList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lvIPList.Location = new System.Drawing.Point(-1, 32);
            this.lvIPList.MultiSelect = false;
            this.lvIPList.Name = "lvIPList";
            this.lvIPList.Size = new System.Drawing.Size(467, 230);
            this.lvIPList.TabIndex = 0;
            this.lvIPList.UseCompatibleStateImageBehavior = false;
            this.lvIPList.View = System.Windows.Forms.View.Details;
            this.lvIPList.Click += new System.EventHandler(this.lvIPList_Click);
            // 
            // chIP
            // 
            this.chIP.Text = "IP";
            this.chIP.Width = 93;
            // 
            // chPing
            // 
            this.chPing.Text = "Ping";
            this.chPing.Width = 61;
            // 
            // chHost
            // 
            this.chHost.Text = "Host";
            this.chHost.Width = 164;
            // 
            // chRecognized
            // 
            this.chRecognized.Text = "Html Title";
            this.chRecognized.Width = 119;
            // 
            // ipFrom
            // 
            this.ipFrom.AllowInternalTab = false;
            this.ipFrom.AutoHeight = true;
            this.ipFrom.BackColor = System.Drawing.SystemColors.Window;
            this.ipFrom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipFrom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipFrom.Location = new System.Drawing.Point(68, 6);
            this.ipFrom.MinimumSize = new System.Drawing.Size(87, 20);
            this.ipFrom.Name = "ipFrom";
            this.ipFrom.ReadOnly = false;
            this.ipFrom.Size = new System.Drawing.Size(112, 20);
            this.ipFrom.TabIndex = 1;
            this.ipFrom.Text = "192.168.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP range:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "to";
            // 
            // ipTo
            // 
            this.ipTo.AllowInternalTab = false;
            this.ipTo.AutoHeight = true;
            this.ipTo.BackColor = System.Drawing.SystemColors.Window;
            this.ipTo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipTo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipTo.Location = new System.Drawing.Point(208, 6);
            this.ipTo.MinimumSize = new System.Drawing.Size(87, 20);
            this.ipTo.Name = "ipTo";
            this.ipTo.ReadOnly = false;
            this.ipTo.Size = new System.Drawing.Size(112, 20);
            this.ipTo.TabIndex = 3;
            this.ipTo.Text = "192.168.0.254";
            // 
            // viewall
            // 
            this.viewall.AutoSize = true;
            this.viewall.Location = new System.Drawing.Point(415, 9);
            this.viewall.Name = "viewall";
            this.viewall.Size = new System.Drawing.Size(37, 17);
            this.viewall.TabIndex = 5;
            this.viewall.Text = "All";
            this.viewall.UseVisualStyleBackColor = true;
            this.viewall.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(325, 5);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 6;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // IPScannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 262);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.lvIPList);
            this.Controls.Add(this.viewall);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ipTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipFrom);
            this.Name = "IPScannerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP Scanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IPScannerForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView lvIPList;
		private IPAddressControlLib.IPAddressControl ipFrom;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private IPAddressControlLib.IPAddressControl ipTo;
		private System.Windows.Forms.ColumnHeader chIP;
		private System.Windows.Forms.ColumnHeader chPing;
		private System.Windows.Forms.ColumnHeader chHost;
		private System.Windows.Forms.ColumnHeader chRecognized;
        private System.Windows.Forms.CheckBox viewall;
        private System.Windows.Forms.Button btnScan;
    }
}

