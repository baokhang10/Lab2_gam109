using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    public class bai2a
    {
        public static void Bai2a()
        {
            var userInfp = new
            {
                id = "2024",
                name = " faker",
                isplaying = false,
                bag = new
                {
                    skins = 0,
                    cups = 20,
                }
            };
            
            Console.WriteLine("Id: " +  userInfp.id);
            Console.WriteLine("Name: " + userInfp.name);
            Console.WriteLine("Isplaying:" + userInfp.isplaying);
            Console.WriteLine("bag skin: " + userInfp.bag.skins);
            Console.WriteLine("bag cups: " + userInfp.bag.cups);
           
        }
        
    }
}
