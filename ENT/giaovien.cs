using System;
using System.Collections.Generic;
using System.Text;
using DO_AN.GUI;

namespace DO_AN.ENT
{
    public class giaovien
    {
        
        private string magv, hotengv, gioitinhgv, diachigv, sdtgv, mamh;
        private DateTime ngaysinhgv;

        public string Magv
        {
            get { return magv; }
            set
            {
                if (value != "")
                    magv = value;
            }
        }
        public string Hotengv 
        {
            get { return hotengv; }
            set
            {
                if (value != "")
                    hotengv = value;
            }
        }
        public string Gioitinhgv 
        {
            get { return gioitinhgv; }
            set
            {
                if (value != "")
                    gioitinhgv = value;
            }
        }
        public string Diachigv 
        {
            get { return diachigv; }
            set
            {
                if (value != "")
                    diachigv = value;
            }
        }
        public string Sdtgv 
        {
            get { return sdtgv; }
            set
            {
                if (value != "")
                    sdtgv = value;
            }
        }
        public string Mamh 
        {
            get { return mamh; }
            set
            {
                if (value != "")
                    mamh = value;
            }
        }
        public DateTime Ngaysinhgv { get => ngaysinhgv; set => ngaysinhgv = value; }
        public giaovien() { }
        public giaovien(string magv, string hotengv, string gioitinhgv,
            string diachigv, string sdtgv, string mamh , DateTime ngaysinhgv) 
        {
            this.magv = magv;
            this.hotengv = hotengv;
            this.gioitinhgv = gioitinhgv;
            this.diachigv = diachigv;
            this.sdtgv = sdtgv;
            this.mamh = mamh;
            this.ngaysinhgv = ngaysinhgv;
        }
        public void nhapgv()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(38, 01); Console.WriteLine("===>> NHẬP THÔNG TIN CỦA GIÁO VIÊN <===");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(38, 03); Console.Write("Nhập mã giáo viên: ");
            magv = Console.ReadLine();
            Console.SetCursorPosition(38, 04); Console.Write("Nhập họ tên của giáo viên: ");
            hotengv = Console.ReadLine();
            Console.SetCursorPosition(38, 05); Console.Write("Nhập giới tính:");
            gioitinhgv = Console.ReadLine();
            Console.SetCursorPosition(38, 06); Console.Write("Nhập mã môn học giảng dạy: ");
            mamh = Console.ReadLine();
            Console.SetCursorPosition(38, 07); Console.Write("Nhập ngày tháng năm sinh: ");
            ngaysinhgv = DateTime.Parse(Console.ReadLine());
            Console.SetCursorPosition(38, 08); Console.Write("Nhập địa chỉ: ");
            diachigv = Console.ReadLine();
            Console.SetCursorPosition(38, 09); Console.Write("Nhập số điện thoạ: ");
            sdtgv = Console.ReadLine();
        }
        public void hien()
        {

        }
    }
    public class QLGV
    {
        private giaovien[] ds;
        private int a;
        public void Nhapgv()
        {
            MenuGui mng = new MenuGui();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(38, 2); Console.Write(" __________________________");
            Console.SetCursorPosition(38, 3); Console.Write("| Nhập số lượng giáo viên: |");
            Console.SetCursorPosition(38, 4); Console.Write("|__________________________|");
            Console.SetCursorPosition(63, 3); a = int.Parse(Console.ReadLine());
            ds = new giaovien[a];
            for (int i = 0; i < a; ++i)
            {
                Console.Clear();
                ds[i] = new giaovien();
                ds[i].nhapgv();
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(45, 09); Console.WriteLine("ĐÃ NHẬP XONG");
            Console.SetCursorPosition(45, 10); Console.WriteLine("NHẤN PHÍM BẤT KỲ ĐỂ QUAY LẠI");
            Console.ReadKey();
            Console.Clear();
            mng.THhs();

        }
    }
}
