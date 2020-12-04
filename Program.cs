using System;
using System.Collections.Generic;
using System.Text;
using DO_AN.UTI;

namespace DO_AN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Menu mn = new Menu();
            mn.MenuChinh();
            Console.ReadKey();
        }
    }
}
