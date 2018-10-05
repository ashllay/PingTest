using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingTest
{
    public partial class Main : Form
    {
        string Server, User, Password;
        string BinDir = AppDomain.CurrentDomain.BaseDirectory + @"Bin\";
        public int ping = 0;
        public string ms = " ms";
        public int wakeywakey = 400;
        public int sPort;
        BackgroundWorker bw1 = new BackgroundWorker();
        public Main()
        {
            InitializeComponent();
        }

        public void SetPing()
        {
            CheckForIllegalCrossThreadCalls = false;
            bw1.WorkerSupportsCancellation = true;
            bw1.WorkerReportsProgress = true;
            bw1.DoWork += new DoWorkEventHandler(bw1_DoWork);
            bw1.ProgressChanged += new ProgressChangedEventHandler(bw1_ProgressChanged);

            //if (!string.IsNullOrWhiteSpace(Server))
            //{
            bw1.RunWorkerAsync();
            //}
        }

        public void bw1_DoWork(object Sender, DoWorkEventArgs e)
        {
            // Set ping
            //   AddTextLog("Getting Ping From Server...");
            try
            {
                if (!string.IsNullOrWhiteSpace(Txb_Port.Text))
                {
                    var sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    sock.Blocking = true;
                    var stopwatch = new Stopwatch();
                    stopwatch.Start();
                    sock.Connect(Server, sPort);
                    stopwatch.Stop();
                    int ms = Convert.ToInt32(stopwatch.Elapsed.TotalMilliseconds);
                    sock.Close();
                    ping = ms;
                }
                else
                {
                    ping = Convert.ToInt32(new Ping().Send(Server).RoundtripTime.ToString());
                }
            }
            catch { ping = 0; }
            if (Regex.IsMatch(ping.ToString(), @"^\d+$") == true)
            {
                LbPing.Text = ping + ms;
            }
            else
            {
                LbPing.Text = "Offline";
            }

            BackgroundWorker worker = (BackgroundWorker)Sender;
            while (!worker.CancellationPending)
            {
                // Loop Progress
                worker.ReportProgress(0);
                // Input Ping Into Label
                Thread.Sleep(200);
                try
                {
                    if (!string.IsNullOrWhiteSpace(Txb_Port.Text))
                    {
                        var sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        sock.Blocking = true;
                        var stopwatch = new Stopwatch();
                        stopwatch.Start();
                        sock.Connect(Server, sPort);
                        stopwatch.Stop();
                        int ms = Convert.ToInt32(stopwatch.Elapsed.TotalMilliseconds);
                        sock.Close();
                        ping = ms;
                    }
                    else
                    {
                        ping = Convert.ToInt32(new Ping().Send(Server).RoundtripTime.ToString());
                    }
                }
                catch { ping = 0; }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bw1 != null && bw1.IsBusy)
            {
                bw1.CancelAsync();
            }
        }

        public void bw1_ProgressChanged(object Sender, ProgressChangedEventArgs e)
        {
            if (Regex.IsMatch(ping.ToString(), @"^\d+$") == true)
            {
                LbPing.Text = ping + ms;
            }
            else
            {
                LbPing.Text = "Offline";
            }
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            Btn_Start.Text = "Start";
            Int32.TryParse(Txb_Port.Text, out sPort);
            Server = Txb_IP.Text;

            if (bw1 != null && bw1.IsBusy)
            {
                bw1.CancelAsync();
            }
            else
            {
                SetPing();
                Btn_Start.Text = "Stop";
            }
        }
    }
}
