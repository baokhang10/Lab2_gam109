using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Gam109
{
    public class bai1b
    {

        public static void GetDetail (dynamic value)
        {
            Console.WriteLine("Value: " + value);


        }
        public static void Bai1b()
        {
            GetDetail(10);
            GetDetail("game");
            GetDetail(1.5);
            GetDetail(true); 

        }
    }
}
