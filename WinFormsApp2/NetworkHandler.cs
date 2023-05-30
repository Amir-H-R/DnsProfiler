using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal static class NetworkHandler
    {
        internal static IList<NetworkInterfaceProperties> NetworkInfo()  // To get current wifi config
        {
           
            IList<NetworkInterfaceProperties> networkInterfaces = NetworkInterface.GetAllNetworkInterfaces().Select(p => new NetworkInterfaceProperties
            {
                Name = p.Name
            }).ToList();
            return networkInterfaces;
        }
    }
    public class NetworkInterfaceProperties
    {
        public string Name { get; set; }
    }
}
