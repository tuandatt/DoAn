using System;
using System.Collections.Generic;
using System.Text;

namespace DO_AN.ENT.Diem
{
    class diemtp
    {
        private string mamh;
        private double dtoan, dvan, dngoaingu, dlsu, ddialy, dgdcd, dvatly, dhoahoc, dsinhhoc, dtheduc, dgdqp, dtin, dcnghe;

        public string Mamh
        {

            get { return mamh; }
            set
            {
                if (value != "")
                    mamh = value;
            }
        }
        public double Dtoan
        {
            get { return dtoan; }
            set
            {
                if (value >= 0 && value <= 10)
                    dtoan = value;
            }
        }
        public double Dvan
        {
            get { return dvan; }
            set
            {
                if (value >= 0 && value <= 10)
                    dvan = value;
            }
        }
        public double Dngoaingu
        {
            get { return dngoaingu; }
            set
            {
                if (value >= 0 && value <= 10)
                    dngoaingu = value;
            }
        }
        public double Dlsu
        {
            get { return dlsu; }
            set
            {
                if (value >= 0 && value <= 10)
                    dlsu = value;
            }
        }
        public double Ddialy
        {
            get { return ddialy; }
            set
            {
                if (value >= 0 && value <= 10)
                    ddialy = value;
            }
        }
        public double Dgdcd
        {
            get { return dgdcd; }
            set
            {
                if (value >= 0 && value <= 10)
                    dgdcd = value;
            }
        }
        public double Dvatly
        {
            get { return dvatly; }
            set
            {
                if (value >= 0 && value <= 10)
                    dvatly = value;
            }
        }
        public double Dhoahoc
        {
            get { return dhoahoc; }
            set
            {
                if (value >= 0 && value <= 10)
                    dhoahoc = value;
            }
        }
        public double Dsinhhoc
        {
            get { return dsinhhoc; }
            set
            {
                if (value >= 0 && value <= 10)
                    dsinhhoc = value;
            }
        }
        public double Dtheduc
        {
            get { return dtheduc; }
            set
            {
                if (value >= 0 && value <= 10)
                    dtheduc = value;
            }
        }
        public double Dgdqp
        {
            get { return dgdqp; }
            set
            {
                if (value >= 0 && value <= 10)
                    dgdqp = value;
            }
        }
        public double Dtin
        {
            get { return dtin; }
            set
            {
                if (value >= 0 && value <= 10)
                    dtin = value;
            }
        }
        public double Dcnghe
        {
            get { return dcnghe; }
            set
            {
                if (value >= 0 && value <= 10)
                    dcnghe = value;
            }
        }
        public diemtp() { }
        public diemtp(string mamh, double dtoan, double dvan, double dngoaingu, double dlsu, double ddialy,
            double dgdcd, double dvatly, double dhoahoc, double dsinhhoc, double dtheduc, double
            dgdqp, double dtin, double dcnghe)
        {
            this.mamh = mamh;
            this.dtoan = dtoan;
            this.dvan = dvan;
            this.dngoaingu = dngoaingu;
            this.dlsu = dlsu;
            this.ddialy = ddialy;
            this.dgdcd = dgdcd;
            this.dvatly = dvatly;
            this.dhoahoc = dhoahoc;
            this.dsinhhoc = dsinhhoc;
            this.dtheduc = dtheduc;
            this.dgdqp = dgdqp;
            this.dtin = dtin;
            this.dcnghe = dcnghe;
        }
        public void nhapdiem()
        {
            hocsinh hs = new hocsinh();
            Console.Write("nhap ma hoc sinh: ");
            hs.Mahs = Console.ReadLine();
            Console.Write("nhap diem toan: ");
            dtoan =double.Parse(Console.ReadLine());
            Console.Write("nhap diem van: ");
            dvan = double.Parse(Console.ReadLine());
            Console.Write("nhap diem ngoai ngu: ");
            dngoaingu = double.Parse(Console.ReadLine());
            Console.Write("nhap diem lich su: ");
            dlsu = double.Parse(Console.ReadLine());
            Console.Write("nhap diem dia ly: ");
            ddialy = double.Parse(Console.ReadLine());
            Console.Write("nhap diem giao duc cong dan: ");
            dgdcd = double.Parse(Console.ReadLine());
            Console.Write("nhap diem vat ly: ");
            dvatly = double.Parse(Console.ReadLine());
            Console.Write("nhap diem hoa hoc: ");
            dhoahoc = double.Parse(Console.ReadLine());
            Console.Write("nhap diem sinh hoc: ");
            dsinhhoc = double.Parse(Console.ReadLine());
            Console.Write("nhap diem the duc: ");
            dtheduc = double.Parse(Console.ReadLine());
            Console.Write("nhap diem giao duc quoc phong: ");
            dgdqp = double.Parse(Console.ReadLine());
            Console.Write("nhap doem tin hoc: ");
            dtin = double.Parse(Console.ReadLine());
            Console.Write("nhap diem cong nghe: ");
            dcnghe = double.Parse(Console.ReadLine());
        }
    }
}
