﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    public class bai2b
    {
        public static void Bai2b()
        {
            int y = 10;
            Action<int> AnonymousMethod = delegate (int x)
            {
                int sum = x + y;
                int sub = x - y;
                Console.WriteLine("sum: " + sum);
                Console.WriteLine("sub: " + sub);

            };
            AnonymousMethod(5);
        }
    }
}
