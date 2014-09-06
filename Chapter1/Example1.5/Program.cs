﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Example1._5
{
    public static class Program
    {
        [ThreadStaticAttribute]
        public static int field;

        public static void Main()
        {
            new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    field++;
                    Console.WriteLine("Thread A: {0}", field);
                }
            }).Start();
            new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    field++;
                    Console.WriteLine("Thread B: {0}", field);
                }
            }).Start();
            Console.ReadKey();
        }
    }
}