using System;
using System.Net;


namespace Game_Kursak.model
{
    internal class Client
    {
        public string userName = Environment.UserName;
        public string HOST_PORT = "127.0.0.1:9000";
        public string GetIpAddress()
        {
            string hostName = Dns.GetHostName();
            string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            return myIP;
        }
        public override string ToString()
        {
            return "Name: "+ userName + " IP: "+GetIpAddress();
        }
    }
}
