using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Threading;

namespace konsolgeim
{
    internal class lvl3BossFait
    {
        public static int time = 15;
        public static int zadaha = 0, G = 0;
        private static System.Timers.Timer aTimer;
        public static double num1, num2, num3, F1, F2, F3, F4;
        public static ConsoleKeyInfo keyV3;
        public static Program lvls = new Program();
        public static lvlMenagers lvlsV2 = new lvlMenagers();
        public void Bossfait()
        {
            zadaha = 0;
            G = 0;
            time = 15;
            Console.WriteLine("press any key to start");
            Console.ReadKey();
            randoming(0);
            SetTimer();
            zadaci();
            for (; zadaha < 3;)
            {
            }
            Console.Clear();
            Console.WriteLine("Y=20");
            Console.ReadKey();
            lvlsV2.lvl3(1);
            
        }
        private static void SetTimer()
        {
            aTimer = new System.Timers.Timer(1000);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.Clear();
            if (G == 0)
            {
                Console.Write("8b        d8     \r\n Y8,    ,8P      \r\n  Y8,  ,8P       \r\n   \"8aa8\"        \r\n    `88'         \r\n     88          \r\n     88          \r\n     88          ");
                Console.WriteLine();
            }
            if (G == 1)
            {
                Console.Write("8b       ,d8     \r\nY8,    ,8P'      \r\n Y8,  ,8P       \r\n  \"8aa8\"        \r\n   `88'        \r\n    88         \r\n    88,          \r\n    '88          ");
                Console.WriteLine();
            }
            if (G == 2)
            {
                Console.Write("8b        d8     \r\n Y8,    ,8P      \r\n  Y8,  ,8P       \r\n   \"8aa8\"        \r\n    `88'         \r\n     88          \r\n     88          \r\n     88          ");
                Console.WriteLine();
            }
            if (G == 3)
            {
                Console.Write("8b,       d8     \r\n 'Y8,    ,8P      \r\n    Y8, ,8P       \r\n    \"8aa8\"        \r\n     `88'         \r\n      88           \r\n     ,88          \r\n     88'          ");
                G = -1;
                Console.WriteLine();
            }
            G++;
            if (time > 0)
            {
                if (time >= 10)
                    Console.Write("    [" + time + "]");
                else
                {
                    Console.Write("    [" + 0 + time + "]");
                }
                switch (zadaha)
                {
                    case 0:
                        {
                            Console.Write($"\n{num1}+{num2}+{num3}=\n");
                            Console.WriteLine($"[W]-({F1})\n[A]-({F2})\n[S]-({F3})\n[D]-({F4})\n");
                            break;
                        }
                    case 1:
                        {
                            Console.Write($"\n{num1}+{num2}*{num3}=\n");
                            Console.WriteLine($"[W]-({F3})\n[A]-({F2})\n[S]-({F1})\n[D]-({F4})\n");
                            break;
                        }
                    case 2:
                        {
                            Console.Write($"\n√({num1})*{num2}-{num3}=\n");
                            Console.WriteLine($"[W]-({F4})\n[A]-({F2})\n[S]-({F3})\n[D]-({F1})\n");
                            break;
                        }
                    case 3:
                        {
                            Console.Write($"\n{num1}^2-{num2}=\n");
                            Console.WriteLine($"[W]-({F2})\n[A]-({F1})\n[S]-({F3})\n[D]-({F4})\n");
                            break;
                        }
                }       
                time--;
            }
            else
            {
                Console.Write("время вышло");
            }
        }
        public static void zadaci()
        {
            F1 = num1 + num2 + num3;
            keyV3 = Console.ReadKey();
            if (keyV3.Key == ConsoleKey.W)
            {
                zadaha++;
                randoming(0);
                time = 10;
                F1 = num1 + num2 * num3;
                keyV3 = Console.ReadKey();
                if (keyV3.Key == ConsoleKey.S)
                {
                    zadaha++;
                    randoming(1);
                    time = 10;
                    if (num1 == 1)
                    {
                        num1 = 1;

                    }
                    if (num1 == 2)
                    {
                        num1 = 4;
                    }
                    if (num1 == 3)
                    {
                        num1 = 9;
                    }
                    if (num1 == 4)
                    {
                        num1 = 16;
                    }
                    F1 = Math.Sqrt(num1) * num2 - num3;
                    keyV3 = Console.ReadKey();
                    if (keyV3.Key == ConsoleKey.D)
                    {
                        zadaha++;
                        randoming(0);
                        time = 10;
                        F1 = Math.Pow(num1, 2) - num2;
                        keyV3 = Console.ReadKey();
                        if (keyV3.Key == ConsoleKey.A)
                        {
                            zadaha++;
                            aTimer.Dispose();
                        }
                        else
                        {
                            Console.Clear();
                            aTimer.Dispose();
                            Console.WriteLine("you died");
                            Console.ReadKey();
                            lvls.menu();
                        }
                    }
                    else
                    {
                        Console.Clear();
                        aTimer.Dispose();
                        Console.WriteLine("you died");
                        Console.ReadKey();
                        lvls.menu();
                    }
                }
                else
                {
                    Console.Clear();
                    aTimer.Dispose();
                    Console.WriteLine("you died");
                    Console.ReadKey();
                    lvls.menu();
                }
            }
            else
            {
                Console.Clear();
                aTimer.Dispose();
                Console.WriteLine("you died");
                Console.ReadKey();
                lvls.menu();
            }
        }
        public static void randoming(int a)
        {
            Random rnd = new Random();
            if (a == 0)
            {
                num1 = rnd.Next(1, 11);
                num2 = rnd.Next(1, 11);
            }
            else
            {
                num1 = rnd.Next(1, 5);
                num2 = rnd.Next(2, 4);

            }
            num3 = rnd.Next(1, 11);
            F2 = rnd.Next(-5, 15);
            F3 = rnd.Next(-5, 15);
            F4 = rnd.Next(-5, 15);
            if (F1 == F2 || F1 == F3 || F1 == F4 || F2 == F3 || F2 == F4 || F3 == F4)
            {
                F2 = rnd.Next(-5, 15);
                F3 = rnd.Next(-5, 15);
                F4 = rnd.Next(-5, 15);
            }

        }
    }
}

