using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Bai02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("0: Ten mien sang IP --- 1: IP sang ten mien: ");
            int n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.Write("Nhap ten mien: ");
                string name = Console.ReadLine();
                IPHostEntry iphe = Dns.Resolve(name);
                foreach (IPAddress i in iphe.AddressList)
                    Console.WriteLine(i);
            }
            else
            {
                Console.Write("Nhap IP: ");
                string ip = Console.ReadLine();
                IPHostEntry iphe = Dns.Resolve(ip);
                foreach (char i in iphe.HostName)
                    Console.Write(i);
                Console.WriteLine();
            }
            
        }
    }
}
