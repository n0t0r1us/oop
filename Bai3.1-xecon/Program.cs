using System;

namespace QLXe
{
    //cai dat lop co so
    class Xe
    {
        private string bienso;
        private int namsx;
        private int gia;
        public string BienSo
        {
            get { return bienso; }
            set { bienso = value; }
        }
        public int NamSx
        {
            get { return namsx; }
            set { namsx = value; }
        }
        public int Gia
        {
            get { return gia; }
            set { gia = value; }
        }
        //phuong thuc thiet lap
        public Xe()
        {
            BienSo = "";
            NamSx = 0;
            Gia = 0;
        }
        public Xe(string b, int n, int g)
        {
            BienSo = b;
            NamSx = n;
            Gia = g;
        }
        //phuong thuc nhap
        public void Nhap()
        {
            Console.WriteLine("nhap bien so:");
            BienSo = Console.ReadLine();
            Console.WriteLine("nhap nam xan xuat:");
            NamSx = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap gia:");
            Gia = int.Parse(Console.ReadLine());
        }
        //phuong thuc xuat
        public void Xuat()
        {
            Console.WriteLine("Bien So:{0}", BienSo);
            Console.WriteLine("Nam SX:{0}", NamSx);
            Console.WriteLine("Gia:{0}", Gia);
        }
    }
    //cai dat lop xecon thua ke lop xe
    class XeCon : Xe
    {
        private int sochongoi;
        public int SoChoNgoi
        {
            get { return sochongoi; }
            set { sochongoi = value; }
        }
        //cai dat ham thiet lap cho lop xecon
        public XeCon()
            : base()
        {
            SoChoNgoi = 0;
        }
        public XeCon(string m, int n, int g, int s)
            : base(m, n, g)
        {
            SoChoNgoi = s;
        }
        public new void Nhap()
        {
            base.Nhap();
            Console.WriteLine("nhap so cho ngoi:");
            SoChoNgoi = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------");
        }
        public new void Xuat()
        {
            base.Xuat();
            Console.WriteLine("So Cho Ngoi:{0}", SoChoNgoi);
        }
        //phuong thuc tim xe co gia cao nhat
        static public void Max(XeCon[] p, int n)
        {
            int max = 0;
            int vitri = 0;
            for (int i = 0; i < n; i++)
            {
                if (max < p[i].Gia)
                {
                    max = p[i].Gia;
                    vitri = i;
                }
            }
            Console.WriteLine("xe co gia tri cao nhat la:");
            p[vitri].Xuat();
        }
        //phuong thuc tim xe co gia thap nhat
        static public void Min(XeCon[] p, int n)
        {
            int min = 0;
            int vitri = 0;
            for (int i = 0; i < n; i++)
            {
                if (min > p[i].Gia)
                {
                    min = p[i].Gia;
                    vitri = i;
                }
            }
            Console.WriteLine("xe co gia tri thap nhat la:");
            p[vitri].Xuat();
        }
        //phuong thuc tim kiem xe cung tinh
        static public void tim(XeCon[] p, int n)
        {
            string a;
            Console.WriteLine("nhap bien so muon tim :");
            a = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                if (a[0] == p[i].BienSo[0] && a[1] == p[i].BienSo[1])
                {
                    p[i].Xuat();
                }
                else
                {
                    Console.WriteLine("kh co xe nay");
                }
            }
        }
        //phuong thuc sap xep
        static public void sapxep(XeCon[] p, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (p[i].NamSx > p[j].NamSx)
                    {
                        XeCon q = new XeCon();
                        q = p[j];
                        p[j] = p[i];
                        p[i] = q;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                p[i].Xuat();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            XeCon[] p = new XeCon[50];
            Console.WriteLine("nhap so xe con:");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("nhap thong tin xe:");
                p[i] = new XeCon();
                p[i].Nhap();
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("thong tin xe:");
                p[i].Xuat();
            }
            Console.WriteLine("------------------------------------");
            XeCon.Max(p, n);
            Console.WriteLine("------------------------------------");
            XeCon.Min(p, n);
            Console.WriteLine("------------------------------------");
            XeCon.tim(p, n);
            Console.WriteLine("------------------------------------");
            XeCon.sapxep(p, n);
            Console.ReadKey();
        }
    }
}