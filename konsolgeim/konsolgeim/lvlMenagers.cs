using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace konsolgeim
{
    internal class lvlMenagers
    {
        static int F1=0;
        static int F2=0;
        public void playMusic(int n)
        {
            SoundPlayer player = new SoundPlayer();
            if (n == 1)
            {
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\music.wav";
            }
            if (n == 2)
            {
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\morg.wav";
            }
            if (n == 3)
            {
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\jingle bells.wav";
            }

            player.PlayLooping();
        }

        public void lvl2MainK(int Q)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            int p = 0;
            double G = 5, U = 30, K = 15, C = 0.5;
            double F = (G + U - K) * C;
            lvlMenagers lvls = new lvlMenagers();
            string[,] map = new string[5, 5];
            if (Q == 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (i == 4 && j == 2)
                        {
                            map[i, j] = "X";
                        }
                        else
                        {
                            map[i, j] = "O";
                        }
                        if ((i == 4 || i == 0) && (j == 3 || j == 1 || j == 3))
                        {
                            map[i, j] = "-";
                        }
                        if ((i == 4 || i == 0) && (j == 4 || j == 0))
                        {
                            map[i, j] = "+";
                        }
                        if ((i == 1 || i == 3) && (j == 0 || j == 4))
                        {
                            map[i, j] = "|";
                        }
                        if (i == 0 && j == 2)
                        {
                            map[i, j] = "F";
                        }
                        if (i == 2 && j == 4)
                        {
                            map[i, j] = "U";
                        }

                    }
                }
            }
            if (Q == 1)
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (i == 2 && j == 0)
                        {
                            map[i, j] = "X";
                        }
                        else
                        {
                            map[i, j] = "O";
                        }
                        if ((i == 4 || i == 0) && (j == 3 || j == 1 || j == 3))
                        {
                            map[i, j] = "-";
                        }
                        if ((i == 4 || i == 0) && (j == 4 || j == 0))
                        {
                            map[i, j] = "+";
                        }
                        if ((i == 1 || i == 3) && (j == 0 || j == 4))
                        {
                            map[i, j] = "|";
                        }
                        if (i == 0 && j == 2)
                        {
                            map[i, j] = "F";
                        }
                        if (i == 2 && j == 4)
                        {
                            map[i, j] = "U";
                        }

                    }
                }
            }
            if (Q == 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (i == 2 && j == 0)
                        {
                            map[i, j] = "X";
                        }
                        else
                        {
                            map[i, j] = "O";
                        }
                        if ((i == 4 || i == 0) && (j == 3 || j == 1 || j == 3))
                        {
                            map[i, j] = "-";
                        }
                        if ((i == 4 || i == 0) && (j == 4 || j == 0))
                        {
                            map[i, j] = "+";
                        }
                        if ((i == 1 || i == 3) && (j == 0 || j == 4))
                        {
                            map[i, j] = "|";
                        }
                        if (i == 2 && j == 4)
                        {
                            map[i, j] = "U";
                        }

                    }
                }
            }
            if (Q == 3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (i == 4 && j == 2)
                        {
                            map[i, j] = "X";
                        }
                        else
                        {
                            map[i, j] = "O";
                        }
                        if ((i == 4 || i == 0) && (j == 3 || j == 1 || j == 3))
                        {
                            map[i, j] = "-";
                        }
                        if ((i == 4 || i == 0) && (j == 4 || j == 0))
                        {
                            map[i, j] = "+";
                        }
                        if ((i == 1 || i == 3) && (j == 0 || j == 4))
                        {
                            map[i, j] = "|";
                        }
                        if (i == 2 && j == 4)
                        {
                            map[i, j] = "U";
                        }

                    }
                }
            }

            for (int c = 0; c < 1;)
            {
                Console.WriteLine("Управление: [W-Вверх] [S-Вниз] [A-Влево] [D-Вправо] [ESC-меню]");
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write(" " + map[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                ConsoleKeyInfo key;
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.W || key.Key == ConsoleKey.S || key.Key == ConsoleKey.A || key.Key == ConsoleKey.D || key.Key == ConsoleKey.Escape)
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
                if (key.Key == ConsoleKey.Escape)
                {
                    Program program = new Program();
                    Console.Clear();
                    Console.WriteLine("Вы уверены что хотите Выйти? прогресс не сохраниться \n[Y-да] [N-нет]");
                    for (int menu =0;menu<1 ; )
                    {
                        Console.Clear();
                        Console.WriteLine("Вы уверены что хотите Выйти? прогресс не сохраниться \n[Y-да] [N-нет]");
                        ConsoleKeyInfo keyV2 = Console.ReadKey();
                        switch (keyV2.Key)
                        {
                            case ConsoleKey.Y:
                                {
                                    program.menu();
                                    break;
                                }
                            case ConsoleKey.N:
                                {
                                    menu++;
                                    break;
                                }
                        }
                    }
                }
                if (key.Key == ConsoleKey.W)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (i >= 1)
                            {
                                if (map[i, j] == "X")
                                {
                                    if (map[i - 1, j] != "-" && map[i - 1, j] != "|" && map[i - 1, j] != "+" && map[i - 1, j] != "F")
                                    {
                                        map[i, j] = "O";
                                        map[i - 1, j] = "X";
                                        break;
                                    }
                                    if (map[i - 1, j] == "F")
                                    {
                                        if (F2 != 1)
                                        {
                                            try
                                            {
                                                Console.Clear();
                                                Console.WriteLine("F=(G+U-K)*C");
                                                // F = (5+30-15)*1/2
                                                Console.Write("F=");
                                                double t = Convert.ToInt32(Console.ReadLine());
                                                if (t == F)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    map[0, 2] = "O";
                                                    F2=1;
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    break;
                                                }
                                            }
                                            catch { break; }
                                        }
                                    }

                                }
                            }
                        }
                    }
                }
                if (key.Key == ConsoleKey.A)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (map[i, j] == "X")
                            {
                                if (i == 2 && j == 0)
                                {
                                    Console.Clear();
                                    lvls.lvl2V1();
                                }
                                if (j >= 1)
                                {

                                    if (map[i, j - 1] != "-" && map[i, j - 1] != "|" && map[i, j - 1] != "+")
                                    {
                                        map[i, j] = "O";
                                        map[i, j - 1] = "X";
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                if (key.Key == ConsoleKey.D)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {   
                            if (map[i, j + 1] != "-" && map[i, j + 1] != "|" && map[i, j + 1] != "+" )
                            {
                                if (map[i, j] == "X")
                                {
                                    if (i == 2 && j == 3)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("U=3+5+7+1*15");
                                        //U=30
                                        Console.ReadKey();
                                        break;
                                    }
                                    map[i, j] = "O";
                                    map[i, j + 1] = "X";
                                    break;
                                }
                            }
                        }
                    }
                }
                if (key.Key == ConsoleKey.S)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {

                            if (map[i, j] == "X")
                            {
                                if (i == 4 && j == 2)
                                {
                                    lvlMenagers lvl1 = new lvlMenagers();
                                    lvl1.lvl1(1);


                                }
                            }
                            if (i < 4)
                            {
                                if (map[i + 1, j] != "-" && map[i + 1, j] != "|" && map[i + 1, j] != "+")
                                {
                                    if (map[i, j] == "X")
                                    {

                                        map[i, j] = "O";
                                        map[i + 1, j] = "X";
                                        p++;
                                        break;

                                    }
                                }
                            }
                        }
                        if (p == 1)
                        {
                            p = 0;
                            break;
                        }
                    }
                }
                Console.Clear();
            }
        }
        
        public void lvl1(int z)
        {
            int p = 0;
            int a = 2;
            int g1 = 2;
            int g2 = 3;
            int a2;
            int g3;
            a2 = a + a * a;
            g3 = g1 + g2;
            Console.Clear();
            string[,] map = new string[5, 5];
            if (z ==0 )
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == 2 && j == 2)
                    {
                        map[i, j] = "X";
                    }
                    else
                    {
                        map[i, j] = "O";
                    }
                    if ((i == 4 || i == 0) && (j == 3 || j == 1 || j == 3))
                    {
                        map[i, j] = "-";
                    }
                    if ((i == 4 || i == 0) && (j == 4 || j == 0))
                    {
                        map[i, j] = "+";
                    }
                    if ((i == 1 || i == 3) && (j == 0 || j == 4))
                    {
                        map[i, j] = "|";
                    }
                    if (i == 4 && j == 2)
                    {
                        map[i, j] = "-";
                    }
                    if (i == 2 && j == 4)
                    {
                        map[i, j] = "G";
                    }
                    if (i == 2 & j == 0)
                    {
                        map[i, j] = "A";
                    }
                    if (i == 0 && j == 2)
                    {
                        map[i, j] = "F";
                    }
                }
            }
            if(z == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (i == 0 && j == 2)
                        {
                            map[i, j] = "X";
                        }
                        else
                        {
                            map[i, j] = "O";
                        }
                        if ((i == 4 || i == 0) && (j == 3 || j == 1 || j == 3))
                        {
                            map[i, j] = "-";
                        }
                        if ((i == 4 || i == 0) && (j == 4 || j == 0))
                        {
                            map[i, j] = "+";
                        }
                        if ((i == 1 || i == 3) && (j == 0 || j == 4))
                        {
                            map[i, j] = "|";
                        }
                        if (i == 4 && j == 2)
                        {
                            map[i, j] = "-";
                        }
                        if (i == 2 && j == 4)
                        {
                            map[i, j] = "G";
                        }
                        if (i == 2 & j == 0)
                        {
                            map[i, j] = "A";
                        }
                    }
                }
            }

            for (int c = 0; c < 1;)
            {
                Console.WriteLine("Управление: [W-Вверх] [S-Вниз] [A-Влево] [D-Вправо] [ESC-меню]");
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write(" " + map[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                ConsoleKeyInfo key;
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.W || key.Key == ConsoleKey.S || key.Key == ConsoleKey.A || key.Key == ConsoleKey.D || key.Key == ConsoleKey.Escape)
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
                if (key.Key == ConsoleKey.Escape)
                {
                    Program program = new Program();
                    Console.Clear();
                    Console.WriteLine("Вы уверены что хотите Выйти? прогресс не сохраниться \n[Y-да] [N-нет]");
                    for (int menu = 0; menu < 1;)
                    {
                        Console.Clear();
                        Console.WriteLine("Вы уверены что хотите Выйти? прогресс не сохраниться \n[Y-да] [N-нет]");
                        ConsoleKeyInfo keyV2 = Console.ReadKey();
                        switch (keyV2.Key)
                        {
                            case ConsoleKey.Y:
                                {
                                    program.menu();
                                    break;
                                }
                            case ConsoleKey.N:
                                {
                                    menu++;
                                    break;
                                }
                        }
                    }
                }
                if (key.Key == ConsoleKey.W)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (map[i, j] == "X")
                            {
                                if (i == 0 && j == 2)
                                {
                                    lvlMenagers lvl2 = new lvlMenagers();
                                    if (F2 ==0)
                                    lvl2.lvl2MainK(0);
                                    else lvl2.lvl2MainK(3);
                                    Console.ReadKey();
                                }
                                if (F1 != 1&&z==0)
                                {
                                    if (i == 1 && j == 2)
                                    {
                                        try
                                        {
                                            Console.Clear();
                                            Console.WriteLine("F=G*A");
                                            Console.Write("F=");
                                            int t = Convert.ToInt32(Console.ReadLine());
                                            int F = g3 * a2;
                                            if (t == F)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                map[0, 2] = "O";
                                                F1=1;
                                                break;
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                            }
                                        }
                                        catch { break; }
     
                                    }
                                }
                            }
                            if (i >= 1)
                            {
                                if (map[i - 1, j] != "-" && map[i - 1, j] != "|" && map[i - 1, j] != "+" && map[i - 1, j] != "F")
                                {
                                    if (map[i, j] ==    "X" && i > 0)
                                    {
                                        map[i, j] = "O";
                                        map[i - 1, j] = "X";
                                        break;
                                    }
                                }

                            }

                        }
                    }
                }
                if (key.Key == ConsoleKey.A)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (map[i, j] == "X")
                                if (i == 2 && j == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"A={a}+{a}*{a}");
                                    Console.ReadKey();
                                }
                            if (j >= 1)
                            {
                                if (map[i, j - 1] != "-" && map[i, j - 1] != "|" && map[i, j - 1] != "+" && map[i, j - 1] != "A")
                                {
                                    if (map[i, j] == "X")
                                    {
                                        map[i, j] = "O";
                                        map[i, j - 1] = "X";
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                if (key.Key == ConsoleKey.D)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (map[i, j] == "X")
                                if (i == 2 && j == 3)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"G={g1}+{g2}");
                                    Console.ReadKey();
                                }
                            if (j < 4)
                            {
                                if (map[i, j + 1] != "-" && map[i, j + 1] != "|" && map[i, j + 1] != "+" && map[i, j + 1] != "G")
                                {
                                    if (map[i, j] == "X")
                                    {
                                        map[i, j] = "O";
                                        map[i, j + 1] = "X";
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                if (key.Key == ConsoleKey.S)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (map[i + 1, j] != "-" && map[i + 1, j] != "|" && map[i + 1, j] != "+")
                            {
                                if (map[i, j] == "X")
                                {
                                    map[i, j] = "O";
                                    map[i + 1, j] = "X";
                                    p++;
                                    break;
                                }
                            }
                        }
                        if (p == 1)
                        {
                            p = 0;
                            break;
                        }

                    }
                }                   
                Console.Clear();
            }
        }
        public void lvl2V1()
        {
            lvlMenagers lvls = new lvlMenagers ();
            int p = 0;
            string[,] map = new string[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == 2 && j == 4)
                    {
                        map[i, j] = "X";
                    }
                    else
                    {
                        map[i, j] = "O";
                    }
                    if ((i == 4 || i == 0) && (j == 3 || j == 1 || j == 3))
                    {
                        map[i, j] = "-";
                    }
                    if ((i == 4 || i == 0) && (j == 4 || j == 0))
                    {
                        map[i, j] = "+";
                    }
                    if ((i == 1 || i == 3) && (j == 0 || j == 4))
                    {
                        map[i, j] = "|";
                    }
                    if(i == 4 && j == 2)
                    {
                        map[i, j] = "-";
                    }
                    if (i == 0 && j == 2)
                    {
                        map[i, j] = "K";
                    }
                    if (i == 2&& j == 0)
                    {
                        map[i, j] = "C";
                    }

                }
            }

            for (int c = 0; c < 1;)
            {
                Console.WriteLine("Управление: [W-Вверх] [S-Вниз] [A-Влево] [D-Вправо] [ESC-меню]");
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write(" " + map[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                ConsoleKeyInfo key;
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.W || key.Key == ConsoleKey.S || key.Key == ConsoleKey.A || key.Key == ConsoleKey.D || key.Key == ConsoleKey.Escape)
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
                if (key.Key == ConsoleKey.Escape)
                {
                    Program program = new Program();
                    Console.Clear();
                    Console.WriteLine("Вы уверены что хотите Выйти? прогресс не сохраниться \n[Y-да] [N-нет]");
                    for (int menu = 0; menu < 1;)
                    {
                        Console.Clear();
                        Console.WriteLine("Вы уверены что хотите Выйти? прогресс не сохраниться \n[Y-да] [N-нет]");
                        ConsoleKeyInfo keyV2 = Console.ReadKey();
                        switch (keyV2.Key)
                        {
                            case ConsoleKey.Y:
                                {
                                    program.menu();
                                    break;
                                }
                            case ConsoleKey.N:
                                {
                                    menu++;
                                    break;
                                }
                        }
                    }
                }
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
                                    if (map[i, j] == "X" && i > 0)
                                    {
                                        if(map[i - 1, j] == "K")
                                        {
                                            Console.Clear();
                                            Console.WriteLine("K=5*3-126*0");
                                            //k=15
                                            Console.ReadKey();
                                            break;
                                        }
                                        else
                                        {
                                        map[i, j] = "O";
                                        map[i - 1, j] = "X";
                                        break;
                                        }   
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
                                if (map[i, j - 1] != "-" && map[i, j - 1] != "|" && map[i, j - 1] != "+")
                                {
                                    if (map[i, j] == "X")
                                    {
                                        if(map[i, j - 1] == "C")
                                        {
                                            Console.Clear();
                                            Console.WriteLine("C=1,5-1");
                                            //C=0,5
                                            Console.ReadKey();
                                            break;
                                        }
                                        else
                                        {
                                            map[i, j] = "O";
                                            map[i, j - 1] = "X";
                                            break;
                                        } 
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
                            if (map[i, j] == "X")
                            {
                                
                                if (i == 2 && j == 4)
                                {
                                    if (F2 == 0)
                                    {
                                        Console.Clear();
                                        lvls.lvl2MainK(1);
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        lvls.lvl2MainK(2);
                                    }
                                }
                                if (map[i, j + 1] != "-" && map[i, j + 1] != "|" && map[i, j + 1] != "+")
                                {
                                    map[i, j] = "O";
                                    map[i, j + 1] = "X";
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
                                if (map[i, j] == "X")
                                {
                                    map[i, j] = "O";
                                    map[i + 1, j] = "X";
                                    p++;
                                    break;
                                }
                            }
                        }
                        if (p == 1)
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
