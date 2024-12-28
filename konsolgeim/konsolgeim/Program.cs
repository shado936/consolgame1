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
            lvls.playMusic();   
            lvls.lvl1(0);
        }
    }
}
