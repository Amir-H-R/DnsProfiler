using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.XmlUtility;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {

        XmlHandler handler;
        public Form1()
        {
            handler = new XmlHandler();
            InitializeComponent();
            dnsComboBox.DataSource = handler.GetAllProfiles();
            dnsComboBox.DisplayMember = "Name";
            dnsComboBox.ValueMember = "Id";

            interfaceComboBox.DataSource = NetworkHandler.NetworkInfo();
            interfaceComboBox.DisplayMember = "Name";
            interfaceComboBox.ValueMember = "Name";
            interfaceComboBox.SelectedIndex = -1;

            txt_second_dns.Text = String.Empty;
            txt_pri_dns.Text = String.Empty;


        }

        private void SetIP(string arg)
        {

            try
            {

                ProcessStartInfo psi = new ProcessStartInfo("cmd.exe");
                psi.UseShellExecute = true;
                psi.WindowStyle = ProcessWindowStyle.Hidden;
                psi.Verb = "runas";
                psi.Arguments = arg;
                Process.Start(psi);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


        private void btn_setIP_Click(object sender, EventArgs e)
        {
            var profile = handler.GetProfile(dnsComboBox.SelectedValue.ToString());

            string PrimaryDNS = txt_pri_dns.Text == " " ? profile.PrimaryDns : txt_pri_dns.Text;
            string SecondDNS = txt_second_dns.Text == " " ? profile.SecondaryDns : txt_second_dns.Text;
            string wifiName = interfaceComboBox.SelectedValue.ToString();
            string dnsComand = "/c netsh interface ip set dns name=" + wifiName + " static " + PrimaryDNS + " & netsh interface ip add dns name=" + wifiName + " " + SecondDNS + " index=2";

            SetIP(dnsComand);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://laptrinhvb.net");
        }

        private void btn_Auto_Click(object sender, EventArgs e)
        {
            var wifiName = interfaceComboBox.SelectedValue == null ? " " : interfaceComboBox.SelectedValue.ToString();
            SetIP("/c netsh interface ip set address " + wifiName + " dhcp & netsh interface ip set dns " + wifiName + " dhcp");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            handler = new XmlHandler();
            Profile profile = handler.GetProfile(dnsComboBox.SelectedValue.ToString());
            txt_pri_dns.Text = profile.PrimaryDns;
            txt_second_dns.Text = profile.SecondaryDns;
        }

        private void newProfileButton_Click(object sender, EventArgs e)
        {
            string primaryDns = txt_pri_dns.Text;
            string secondaryDns = txt_second_dns.Text;
            string profileName = txt_profile_name.Text;
            XmlHandler.AddNewProfile(primaryDns, secondaryDns, profileName);
        }

        private void btn_delete_config_Click(object sender, EventArgs e)
        {
            handler.DeleteProfile(dnsComboBox.SelectedValue.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
