using System;
using System.Collections.Generic;
using System.Text;
using DO_AN.ENT;
using DO_AN.ENT.Diem;
using DO_AN.UTI;

namespace DO_AN.GUI
{
    public class MenuGui 
    {
        Menu mn = new Menu();
        public void THhs()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(38, 03); Console.WriteLine(" █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(38, 04); Console.WriteLine(" █                                                 █");
            Console.ForegroundColor = ConsoleColor.Magenta; 
            Console.SetCursorPosition(38, 05); Console.WriteLine(" █    ❶ 1.Nhập thông tin học sinh                  █");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(38, 06); Console.WriteLine(" █    ❷ 2.Nhập điểm của học sinh                   █");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(38, 07); Console.WriteLine(" █    ❸ 3.Tìm học sin                              █");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(38, 08); Console.WriteLine(" █    ❹ 4.Sửa học sinh                             █");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(38, 09); Console.WriteLine(" █    ❺ 5.Xóa thông tin học sinh                   █");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(38, 10); Console.WriteLine(" █    ❻ 6.Hiển thị thông tin học sinh              █");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(38, 11); Console.WriteLine(" █    ❼ 7.Hiển thị thông tin điểm của học sinh     █");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(38, 12); Console.WriteLine(" █    ❽ 8.Exit                                     █");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(38, 13); Console.WriteLine(" █                                                 █");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(38, 14); Console.WriteLine("●▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀● ");
            QLHS ql = new QLHS();
            diemtp dtp = new diemtp();
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    Console.Clear();
                    ql.NhapHS();
                    break;
                case 2:
                    Console.Clear();
                    dtp.nhapdiem();
                    break;
                case 6:
                    Console.Clear();
                    ql.HienHS();
                    break;
                case 8:
                    Console.Clear();
                    mn.MenuChinh();
                    break;
            }
        }
        public void THgv()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(38, 03); Console.WriteLine(" █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(38, 04); Console.WriteLine(" █                                                 █");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(38, 05); Console.WriteLine(" █    ❶ 1.Nhập thông tin giáo viên                 █");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(38, 06); Console.WriteLine(" █    ❷ 2.Sửa thông tin giáo viên                  █");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(38, 07); Console.WriteLine(" █    ❸ 3.Xóa thông tin giáo viên                  █");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(38, 08); Console.WriteLine(" █    ❹ 4.Tìm giáo viên                            █");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(38, 09); Console.WriteLine(" █    ❺ 5.Hiển thị thông tin giáo viên             █");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(38, 10); Console.WriteLine(" █    ❻ 6.Exit                                     █");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(38, 11); Console.WriteLine(" █                                                 █");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(38, 12); Console.WriteLine("●▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀● ");
            QLGV gv = new QLGV();
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    Console.Clear();
                    gv.Nhapgv();
                    break;
                case 6:
                    Console.Clear();
                    mn.MenuChinh();
                    break;
            }
        }
    }
}
