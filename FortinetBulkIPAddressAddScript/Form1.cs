using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FortinetBulkIPAddressAddScript
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtIPs_Enter(object sender, EventArgs e)
        {
            if (txtIPs.Text == "Paste the IP Addresses here, without spaces, in lines")
            {
                txtIPs.Text = "";
                txtIPs.ForeColor = Color.DarkMagenta;
            }

        }

        private void txtIPs_Leave(object sender, EventArgs e)
        {
            if (txtIPs.Text == "")
            {
                txtIPs.Text = "Paste the IP Addresses here, without spaces, in lines";
                txtIPs.ForeColor = Color.SeaGreen;
            }

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string conf1 = "config firewall address";
            string code1 = "    edit ";
            string code2 = Environment.NewLine + "        set subnet ";
            string code3 = "/32";
            string code4 = Environment.NewLine + "    next";
            string conf2 = "end";

            string conf3 = "config firewall addrgrp";
            string code5 = Environment.NewLine + "    edit deny-ips";
            string code6 = Environment.NewLine + "        set member ";
            string code7 = Environment.NewLine + "    next";
            string conf4 = "end";

            var ipadress = new StringBuilder();
            foreach (var line in txtIPs.Lines)
            {
                ipadress.AppendLine(code1 + line + code2 + line + code3 + code4);
            }

            var ipgroup = new StringBuilder();
            foreach (var line in txtIPs.Lines)
            {
                ipgroup.Append(line + " ");
            }

            File.WriteAllText(@"FortinetBulkIPAddressScript.txt", conf1 + Environment.NewLine + ipadress.ToString() + conf2 + Environment.NewLine + conf3 + code5 + code6 + ipgroup.ToString() + code7 + Environment.NewLine + conf4);
        }

        private void picGithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ibati");
        }

        private void picWebsite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ibrahimbati.com");
        }

        private void picTwitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/ibati");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtIPs.Text = "Paste the IP Addresses here, without spaces, in lines";
            txtIPs.ForeColor = Color.SeaGreen;
        }


    }
}
