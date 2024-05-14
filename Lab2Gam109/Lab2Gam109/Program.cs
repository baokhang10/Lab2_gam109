using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Gam109
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("bai 1a");
            bai1a.start();

            Console.WriteLine();
            Console.WriteLine("bai 1b");
            bai1b.Bai1b();

            Console.WriteLine();
            Console.WriteLine("bai1 c");
            var user = new UserDataa(1 , " 1st player", 1 );
            bai1c.XuatThongTin("level: ", user.level) ;
            bai1c.XuatThongTin("Name: ", user.name);
            bai1c.XuatThongTin("Id: " , user.id);
            Console.WriteLine();

            Console.ReadLine();
        }
        
    }
}
