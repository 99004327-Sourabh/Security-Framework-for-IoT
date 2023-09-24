using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
namespace UserApp
{
        public class Mac
        {
            public static string GetMacAddress()
            {
                #region Following code used to fetch Mac address
                const int MIN_MAC_ADDR_LENGTH = 12;
                string macAddress = string.Empty;
                long maxSpeed = -1;

                foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
                {
                    string tempMac = nic.GetPhysicalAddress().ToString();
                    if (nic.Speed > maxSpeed && !string.IsNullOrEmpty(tempMac) && tempMac.Length >= MIN_MAC_ADDR_LENGTH)
                    {
                        maxSpeed = nic.Speed;
                        macAddress = tempMac;
                    }
                }

                #endregion
                return macAddress;
            }

            public static string GetLocalIp()
            {
                IPAddress[] ips = Dns.GetHostEntry(Environment.MachineName).AddressList;
                foreach (IPAddress ip in ips)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        //if (ip.ToString().StartsWith("192"))
                        return ip.ToString();
                    }
                }
                return "127.0.0.1";
            }

        }
}
