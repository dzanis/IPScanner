using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;

namespace IPScanner
{
    
    public partial class IPScannerForm : Form
	{
		NetworkScanner scanner = new NetworkScanner();
		Timer timer = new Timer();
		public IPScannerForm()
		{
			InitializeComponent();
            this.chPing.Width = 0;
            this.chHost.Width = 0;
            List<Tuple<IPAddress, IPAddress>> ipRanges = IPRanges.GetOperationalIPRanges();
			if (ipRanges.Count > 0)
			{
				ipFrom.IPAddress = ipRanges[0].Item1;
				ipTo.IPAddress = ipRanges[0].Item2;
                startScanIP();
            }
		}

		List<IPScanResult> results;

        private void startScanIP()
        {
            timer.Stop();
			lvIPList.Items.Clear();
			results = scanner.BeginScan(ipFrom.IPAddress, ipTo.IPAddress);
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

		private void btnScan_Click(object sender, EventArgs e)
		{
            startScanIP();
		}

		void timer_Tick(object sender, EventArgs e)
		{
			PopulateListView();
		}

        bool viewAll_IP = false;

		private void PopulateListView()
		{
			bool itemModified = false;
			for (int i = 0; i < results.Count; i++)
			{
                IPScanResult result = results[i];
                
                    if (result.status == ScanStatus.Complete || result.status == ScanStatus.Partial)
                    {
                        if (GetPingTime(result) != "N/A" || viewAll_IP)//withouth no active ip OR view all ip adress
                        {
                                string ip = result.ip.ToString();
                                ListViewItem[] matchedItems = lvIPList.Items.Find(ip, false);
                                if (matchedItems.Length > 0)
                                {
                                    matchedItems[0].Tag = result.response;
                                    matchedItems[0].SubItems[0].Text = result.ip.ToString();
                                    matchedItems[0].SubItems[1].Text = GetPingTime(result);
                                    matchedItems[0].SubItems[2].Text = result.host;
                                    matchedItems[0].SubItems[3].Text = result.identification;
                                    if (result.identification.Length > 4)// if HttpTitle find
                                    {
                                        matchedItems[0].BackColor = Color.Aqua;
                                    }
                                }
                                else
                                {
                                    ListViewItem lvi = new ListViewItem(new string[] { result.ip.ToString(), GetPingTime(result), result.host, result.identification });
                                    lvi.Name = ip;
                                    lvIPList.Items.Add(lvi);
                                }
                                itemModified = true;
                         }
				     }
               				
				
			}
		}

		private string GetPingTime(IPScanResult result)
		{
			if (result.ping > -1)
				return result.ping + " ms";
			return "N/A";
		}

		private void IPScannerForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			timer.Stop();
			scanner.Abort();
		}


        private void lvIPList_Click(object sender, EventArgs e)
        {
            if (lvIPList.SelectedItems.Count > 0)
            {
                HttpResponseData response = (HttpResponseData)lvIPList.SelectedItems[0].Tag;
                Process.Start(response.host);
            }
   
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            viewAll_IP = viewall.Checked;
            if (viewall.Checked)
            {
                this.chPing.Width = 61;
                this.chHost.Width = 164;
            }
            else
            {
                this.chPing.Width = 0;
                this.chHost.Width = 0;
            }
            startScanIP();
        }

        

    }
}
