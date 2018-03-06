using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Bai01
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Dns.GetHostName();
            IPHostEntry iphe = Dns.GetHostByName(name);
            foreach (IPAddress i in iphe.AddressList)
            {
                       Console.WriteLine(i.ToString());
            }
        }
    }
}
