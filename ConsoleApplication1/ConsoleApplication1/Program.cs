﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            //產生亂數物件
            Random rand = new Random();

            //紀錄次數的變數
            int n = 0;

            

            //產生六個亂數
            while (n<=10)
            {
                int r1 = rand.Next(1, 43);
                int r2 = rand.Next(1, 43);
                int r3 = rand.Next(1, 43);
                int r4 = rand.Next(1, 43);
                int r5 = rand.Next(1, 43);
                int r6 = rand.Next(1, 43);

                //印出
                Console.WriteLine("{0:00} {1:00} {2:00} {3:00} {4:00} {5:00} ", r1, r2, r3, r4, r5, r6);

                //次數+1
                n = n + 1;


                //暫停螢幕

                Console.ReadLine();
            }
        }
    }
}
