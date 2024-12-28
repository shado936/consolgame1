using System;
using System.IO;
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
            lvlMenagers lvls = new lvlMenagers();
            Console.WriteLine("1-обычная версия, 2-сюрприз");
            try
            {
                int n = Convert.ToInt32(Console.ReadLine());
                if (n == 1 || n == 2)
                {
                    lvls.playMusic(n);
                }
                else
                {
                    Console.WriteLine($"{n} не похоже на 1 или 2.....");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
            catch { Console.WriteLine("Так сложно Ввести нормально цифру..."); Console.ReadKey(); Environment.Exit(0); }
            lvls.lvl1(0);
        }
    }
}
