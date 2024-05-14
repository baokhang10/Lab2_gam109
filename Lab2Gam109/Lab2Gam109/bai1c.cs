using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Gam109
{
    public class UserDataa
    {
        public int id;
        public string name;
        public int level;

      
        public UserDataa()
        {
            id = 0;
            name = "kkk";
            level = 0;
        }
        public UserDataa(int id, string name, int level)
        {
            this.id = id;
            this.name = name;
            this.level = level;
        }
        public  void XuatThongTin()
        {
            Console.WriteLine("Id" + id);
            Console.WriteLine("Name" + name);   
            Console.WriteLine("Level: " + level);

        }
    }
    public class bai1c
    {
        public static void XuatThongTin(string attributeName , dynamic attribute)

        {
            Console.WriteLine(attributeName + ": " + attribute);

        }
    }
}
