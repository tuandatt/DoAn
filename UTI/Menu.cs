using System;
using System.Collections.Generic;
using System.Text;
using DO_AN.GUI;
using DO_AN.ENT;

namespace DO_AN.UTI
{
    public class Menu
    {
        public void MenuChinh()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(38, 08); Console.WriteLine(" █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(38, 09); Console.WriteLine(" █                                           █");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(38, 10); Console.WriteLine(" █   ❶ 1.NHẬP DANH SÁCH HỌC SINH             █");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(38, 11); Console.WriteLine(" █   ❷ 2.NHẬP DANH SÁCH GIÁO VIÊN            █");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(38, 12); Console.WriteLine(" █   ❸ 3.KẾT THÚC                            █");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(38, 13); Console.WriteLine(" █                                           █");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(38, 14); Console.WriteLine("●▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀● ");
            MenuGui mng = new MenuGui();
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    Console.Clear();
                    mng.THhs();
                    break;
                case 2:
                    Console.Clear();
                    mng.THgv();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
            }

        }
    }
}
