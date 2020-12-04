using System;
using System.Collections.Generic;
using System.Text;
using DO_AN.GUI;

namespace DO_AN.ENT
{
    public class hocsinh
    {
        private string mahs, hoten, gioitinh, lop, diachi, tenngh, qhvngh, sdtngh, trangthai;
        private DateTime ngaysinh; 
        public string Mahs
        {
            get { return mahs; }
            set
            {
                if (value != "")
                    mahs = value;
            }
        }
        public string Hoten
        {
            get { return hoten; }
            set
            {
                if (value != "")
                    hoten = value;
            }
        }
        public string Gioitinh
        {
            get { return gioitinh; }
            set
            {
                if (value != "")
                    gioitinh = value;
            }
        }
        public string Lop
        {
            get { return lop; }
            set
            {
                if (value != "")
                    lop = value;
            }
        }
        public string Diachi
        {
            get { return diachi; }
            set
            {
                if (value != "")
                    diachi = value;
            }
        }
        public string Tenngh
        {
            get { return tenngh; }
            set
            {
                if (value != "")
                    tenngh = value;
            }
        }
        public string Qhvngh
        {
            get { return qhvngh; }
            set
            {
                if (value != "")
                    qhvngh = value;
            }
        }
        public string Sdtngh
        {
            get { return sdtngh; }
            set
            {
                if (value != "")
                    sdtngh = value;
            }
        }
        public string Trangthai
        {
            get { return trangthai; }
            set
            {
                if (value != "")
                    trangthai = value;
            }
        }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public hocsinh() { }
        public hocsinh(string mahs, string hoten, string gioitinh, string lop, DateTime ngaysinh,
            string diachi, string tenngh, string qhvngh, string sdtngh, string trangthai)
        {
            this.mahs = mahs;
            this.hoten = hoten;
            this.gioitinh = gioitinh;
            this.lop = lop;
            this.ngaysinh = ngaysinh;
            this.diachi = diachi;
            this.tenngh = tenngh;
            this.qhvngh = qhvngh;
            this.sdtngh = sdtngh;
            this.trangthai = trangthai;
        }
        public void nhaphs()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(38, 01); Console.WriteLine("===>> NHẬP THÔNG TIN CÁ NHÂN CỦA HỌC SINH <<===");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(35, 03); Console.Write("Nhập mã học sinh: "); mahs = Console.ReadLine();
            Console.SetCursorPosition(35, 04); Console.Write("Nhập họ tên học sinh: "); hoten = Console.ReadLine();
            Console.SetCursorPosition(35, 05); Console.Write("Nhập giới tính:"); gioitinh = Console.ReadLine();
            Console.SetCursorPosition(35, 06); Console.Write("Nhập lớp: "); lop = Console.ReadLine();
            Console.SetCursorPosition(35, 07); Console.Write("Nhập ngày tháng năm sinh: "); ngaysinh = DateTime.Parse(Console.ReadLine());
            Console.SetCursorPosition(35, 08); Console.Write("Nhập địa chỉ: "); diachi = Console.ReadLine();
            Console.SetCursorPosition(35, 09); Console.Write("Nhập tên người giám hộ: "); tenngh = Console.ReadLine();
            Console.SetCursorPosition(35, 10); Console.Write("Nhập quan hệ của người giám hộ đối với học sinh: "); qhvngh = Console.ReadLine();
            Console.SetCursorPosition(35, 11); Console.Write("Nhập số điện thoại người giám hộ: "); sdtngh = Console.ReadLine();
            Console.SetCursorPosition(35, 12); Console.Write("Nhập trạng thái của học sinh (còn học hay đã nghỉ): "); trangthai = Console.ReadLine();
        }
        public void hienhs()
        {
            Console.WriteLine("Thong tin hoc sinh");
            Console.WriteLine("Ma hoc sinh: " + mahs);
            Console.WriteLine("Ho ten cua hoc sinh: " + hoten);
            Console.WriteLine("Gioi tinh cua hoc sinh: " + gioitinh);
            Console.WriteLine("Lop: " + lop);
            Console.WriteLine("Ngay thang nam sinh:" + ngaysinh.ToString("dd/MM/yyyy"));
            Console.WriteLine("Dia chi cua hoc sinh: " + diachi);
            Console.WriteLine("Ten nguoi giam ho cua hoc sinh:" + tenngh);
            Console.WriteLine("Quan he cua nguoi giam ho voi hoc sinh: "+qhvngh);
            Console.WriteLine("So dien thoai nguoi giam ho:" + sdtngh);
            Console.WriteLine("Trang thai hoc tap cua hoc sinh: "+trangthai);
        }

    }
    public class QLHS
    {
        private hocsinh[] ds;
        private int sck;
        public void NhapHS()
        {
            MenuGui mng = new MenuGui();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(38, 2); Console.Write(" _________________________");
            Console.SetCursorPosition(38, 3); Console.Write("| Nhập số lượng học sinh: |" ); 
            Console.SetCursorPosition(38, 4); Console.Write("|_________________________|");
            Console.SetCursorPosition(63, 3); sck = int.Parse(Console.ReadLine());
            ds = new hocsinh[sck];
            for (int i = 0; i < sck; ++i)
            {
                Console.Clear();
                ds[i] = new hocsinh();
                ds[i].nhaphs();
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(45, 09); Console.WriteLine("ĐÃ NHẬP XONG");
            Console.SetCursorPosition(45, 10); Console.WriteLine("NHẤN PHÍM BẤT KỲ ĐỂ QUAY LẠI");
            Console.ReadKey();
            Console.Clear();
            mng.THhs();

        }
        public void HienHS()
        {
        }

    }
}
