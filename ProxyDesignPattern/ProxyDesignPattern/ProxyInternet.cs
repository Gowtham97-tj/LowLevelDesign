using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyDesignPattern
{
    public class ProxyInternet : IInternet
    {
        private IInternet internet = new RealInternet();
        private static List<String> bannedSites = new List<String>();
        public ProxyInternet()
        {
            bannedSites.Add("abc.com");
            bannedSites.Add("def.com");
            bannedSites.Add("ijk.com");
            bannedSites.Add("lnm.com");
        }
        
        public void connectTo(string serverhost)
        {
            if (bannedSites.Contains(serverhost.ToLower()))
            {
                throw new Exception("Access Denied");
            }

            internet.connectTo(serverhost);
        }
    }
} 
