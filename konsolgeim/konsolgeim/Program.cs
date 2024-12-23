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
                }
            }
            
            for (int c = 0; c < 1;)
            {
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
                if (key.Key == ConsoleKey.W)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (i >= 1)
                            {
                                if (map[i - 1, j] != "-" && map[i - 1, j] != "|" && map[i - 1, j] != "+")
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
                            if (j >= 1)
                            {
                                if (map[i, j-1] != "-" && map[i, j - 1] != "|" && map[i, j - 1] != "+")
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
                        for (int j = 0; j < 4; j++)
                        {    
                                if (map[i, j + 1] != "-" && map[i, j + 1] != "|" && map[i, j + 1] != "+")
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
