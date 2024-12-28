using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design;

namespace konsolgeim
{
    internal class Program
    {
        static int n = 1;
        static int musicstart = 0;
        static lvlMenagers lvls = new lvlMenagers();
        static Program pr = new Program();
        static void Main(string[] args)
        {
            pr.menu();
        }
        public void menu()
        {
            Console.Clear();
            int g = 0;
            if (musicstart == 0)
            {
                lvls.playMusic(n);
                musicstart = 1;
            }   
            ConsoleKeyInfo key;
            Console.WriteLine(" [A-влево] [D-вправо] [Enter-выбрать]");
            Console.WriteLine(" <start> settings  exit");
            for (; ; )
            {
                key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.D:
                        {
                            if (g != 2)
                            {
                                g++;
                            }
                            else
                            {
                                g = 0;
                            }
                            break;
                        }
                    case ConsoleKey.A:
                        {
                            if (g != 0)
                            {
                                g--;
                            }
                            else
                            {
                                g = 2;
                            }
                            break;

                        }
                    case ConsoleKey.Enter:
                        {
                            if (g == 0)
                            {
                                pr.start();
                            }
                            if (g == 1)
                            {
                                Console.Clear();
                                pr.settings();
                            }
                            if (g == 2)
                            {
                                Environment.Exit(0);
                            }

                            break;

                        }
                    case ConsoleKey.Escape:
                        {
                            if (g == 0)
                            {
                                Console.Clear();
                                Console.WriteLine(" [A-влево] [D-вправо] [Enter-выбрать]");
                                Console.WriteLine(" <start> settings  exit");
                            }
                            if (g == 1)
                            {
                                Console.Clear();
                                Console.WriteLine(" [A-влево] [D-вправо] [Enter-выбрать]");
                                Console.WriteLine("  start <settings> exit");
                            }
                            if (g == 2)
                            {
                                Console.Clear();
                                Console.WriteLine(" [A-влево] [D-вправо] [Enter-выбрать]");
                                Console.WriteLine("  start  settings <exit>");
                            }
                            break;
                        }
                }
                if (g == 0)
                {
                    Console.Clear();
                    Console.WriteLine(" [A-влево] [D-вправо] [Enter-выбрать]");
                    Console.WriteLine(" <start> settings  exit");
                }
                if (g == 1)
                {
                    Console.Clear();
                    Console.WriteLine(" [A-влево] [D-вправо] [Enter-выбрать]");
                    Console.WriteLine("  start <settings> exit");
                }
                if (g == 2)
                {
                    Console.Clear();
                    Console.WriteLine(" [A-влево] [D-вправо] [Enter-выбрать]");
                    Console.WriteLine("  start  settings <exit>");
                }
            }
        }
        public void start()
        {
            lvls.lvl1(0);
        }
        public void settings()
        {
            int g = 0;
            ConsoleKeyInfo key;
            Console.WriteLine(" [W-вверх] [S-вниз] \n");
            Console.WriteLine("  [music] \n <defolt> \n   morg \n \n   exit ");
            for (; ; )
            {
                key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.S:
                        {
                            if (g != 2)
                            {
                                g++;
                            }
                            else
                            {
                                g = 0;
                            }
                            break;
                        }
                    case ConsoleKey.W:
                        {
                            if (g != 0)
                            {
                                g--;
                            }
                            else
                            {
                                g = 2;
                            }
                            break;

                        }
                    case ConsoleKey.Enter:
                        {
                            if (g == 0)
                            {
                                n = 1;
                                lvls.playMusic(n);
                            }
                            if (g == 1)
                            {
                                n = 2;
                                lvls.playMusic(n);
                            }
                            if (g == 2)
                            {
                                pr.menu();
                            }

                            break;

                        }
                    case ConsoleKey.Escape:
                        {
                            if (g == 0)
                            {
                                Console.Clear();
                                Console.WriteLine(" [W-вверх] [S-вниз] \n");
                                Console.WriteLine("  [music] \n <defolt> \n   morg \n \n   exit ");
                            }
                            if (g == 1)
                            {
                                Console.Clear();
                                Console.WriteLine(" [W-вверх] [S-вниз] \n");
                                Console.WriteLine("  [music] \n  defolt \n  <morg> \n \n   exit ");
                            }
                            if (g == 2)
                            {
                                Console.Clear();
                                Console.WriteLine(" [W-вверх] [S-вниз] \n");
                                Console.WriteLine("  [music] \n  defolt \n   morg \n \n  <exit> ");
                            }
                            break ;
                        }
                }
                if (g == 0)
                {
                    Console.Clear();
                    Console.WriteLine(" [W-вверх] [S-вниз] \n");
                    Console.WriteLine("  [music] \n <defolt> \n   morg \n \n   exit ");
                }
                if (g == 1)
                {
                    Console.Clear();
                    Console.WriteLine(" [W-вверх] [S-вниз] \n");
                    Console.WriteLine("  [music] \n  defolt \n  <morg> \n \n   exit ");
                }
                if (g == 2)
                {
                    Console.Clear();
                    Console.WriteLine(" [W-вверх] [S-вниз] \n");
                    Console.WriteLine("  [music] \n  defolt \n   morg \n \n  <exit> ");
                }
            }
        }
    }
}
