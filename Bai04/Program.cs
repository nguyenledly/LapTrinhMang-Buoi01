using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Bai04
{
    class Program
    {
        static void Main(string[] args)
        {
            string ip=null;
            string name = Dns.GetHostName();
            IPHostEntry iphe = Dns.GetHostByName(name);
            foreach (IPAddress i in iphe.AddressList)
            {
                ip = i.ToString();
            }
            // Tim vi tri cuoi cung cua ky tu "."
            int pos = ip.LastIndexOf(".");
            // Tu vi tri do, remove di cac ky tu sau no +1
            // newIP la dia chi IP moi sau khi tach khoi dau "." cuoi cung 
            string newIP = ip.Remove(pos+1);
            //Console.WriteLine(newIP);
            for (int i = 1; i < 3; i++)
            {
                string ipA = newIP + i;
                IPHostEntry iphe2 = Dns.Resolve(ipA);
                foreach (char j in iphe2.HostName)
                    Console.Write(j);
                Console.WriteLine();
            }
            
        }
    }
}
