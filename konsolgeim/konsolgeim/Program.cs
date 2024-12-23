using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsolgeim
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            int p = 0;
            int F1 = 0;
            string[,]map = new string[5,5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == 2 && j == 2)
                    {
                        map[i, j] = "1";
                    }
                    else
                    {
                        map[i, j] = "0";
                    }
                    if ((i == 4 || i == 0 ) && (j == 3 || j ==1 || j == 3))
                    {
                        map[i, j] = "-";
                    }
                    if ((i == 4 || i == 0) && (j == 4 || j == 0))
                    {
                        map[i, j] = "+";
                    }
                    if ((i == 1 || i==3)  && (j == 0|| j == 4)) 
                    {
                        map[i, j] = "|";
                    }
                    if (i == 4 && j == 2)
                    {
                        map[i, j] = "-";
                    }
                    if(i == 2 && j == 4)
                    {
                        map[i, j] = "G";
                    }
                    if(i == 2 & j == 0)
                    {
                        map[i, j] = "A";
                    }
                    if(i == 0&& j == 2)
                    {
                        map[i,j] = "F"; 
                    }
                }
            }
            
            for (int c = 0; c < 1;)
            {
                Console.WriteLine("Управление: W-Вверх, S-Вниз, A-Влево, D-Вправо");
                for (int i = 0;i < 5; i++)
                {
                    for (int j = 0;j < 5 ; j++)
                    {
                        Console.Write(" " + map[i, j]+ " ");
                    }
                    Console.WriteLine();
                }
                ConsoleKeyInfo key;
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.W || key.Key == ConsoleKey.S || key.Key == ConsoleKey.A || key.Key == ConsoleKey.D)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            Console.Write(" " + map[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.W)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (map[i, j] == "1")
                                if(F1 !=1)
                                if (i == 1 && j == 2)
                                {
                                        try
                                        {
                                            Console.Clear();
                                            Console.WriteLine("F=G*A");
                                            Console.Write("F=");
                                            int t = Convert.ToInt32(Console.ReadLine());
                                            if (t == 12)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                map[0, 2] = "0";
                                                F1++;
                                                break;
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                            }
                                        }
                                        catch { break; }
                                }
                            if (i >= 1)
                            {
                                if (map[i - 1, j] != "-" && map[i - 1, j] != "|" && map[i - 1, j] != "+" && map[i-1,j]!="F")
                                {
                                    if (map[i, j] == "1" && i > 0)
                                    {
                                        map[i, j] = "0";
                                        map[i - 1, j] = "1";
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.A)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (map[i, j] == "1")
                                if (i == 2 && j == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("A=2+2*2");
                                    Console.ReadKey();
                                }
                            if (j >= 1)
                            {
                                if (map[i, j-1] != "-" && map[i, j - 1] != "|" && map[i, j - 1] != "+"&& map[i, j - 1] != "A")
                                {
                                    if (map[i, j] == "1")
                                    {
                                        map[i, j] = "0";
                                        map[i, j - 1] = "1";
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.D)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (map[i,j]=="1")
                            if (i == 2&&j==3)
                            {
                                    Console.Clear();
                                    Console.WriteLine("G=1+1");
                                    Console.ReadKey();
                            }
                            if (j < 4)
                            {
                                if (map[i, j + 1] != "-" && map[i, j + 1] != "|" && map[i, j + 1] != "+"&& map[i,j+1] != "G")
                                {
                                    if (map[i, j] == "1")
                                    {
                                        map[i, j] = "0";
                                        map[i, j + 1] = "1";
                                        break;
                                    }
                                }
                            }                       
                        }
                    }
                    Console.Clear();
                } 
                if (key.Key == ConsoleKey.S)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (map[i + 1, j] != "-" && map[i + 1, j] != "|" && map[i + 1, j] != "+")
                            {
                                if (map[i, j] == "1")
                                {
                                    map[i, j] = "0";
                                    map[i + 1, j] = "1";
                                    p++;
                                    break;
                                }
                            }
                        }
                        if(p == 1)
                        {
                            p = 0;
                            break;
                        }
                            
                    }
                    Console.Clear();
                }
            }
        }
    }
}
