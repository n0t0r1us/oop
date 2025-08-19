using System;
namespace QLhinhve
{
    class HinhVe
    {
        public virtual void Nhap()
        {
        }

        public virtual float DienTich()
        {
            return 0;
        }
    }
    class HinhThang : HinhVe
    {
        private float daylon;
        private float daynho;
        private float chieucao;
        public float DayLon
        {
            set { daylon = value; }
            get { return daylon; }
        }
        public float DayNho
        {
            set { daynho = value; }
            get { return daynho; }
        }
        public float ChieuCao
        {
            set { chieucao = value; }
            get { return chieucao; }
        }
        public HinhThang()
        {
        }

        public HinhThang(float a, float b, float c)
        {
            DayLon = a;
            DayNho = b;
            ChieuCao = c;
        }

        public override float DienTich()
        {
            return (DayLon + DayNho) * ChieuCao / 2;
        }

        public override void Nhap()
        {
            Console.WriteLine("Nhap day lon:");
            DayLon = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap day nho:");
            DayNho = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu cao:");
            ChieuCao = int.Parse(Console.ReadLine());
        }
    }

    class HinhBinhHanh : HinhVe
    {
        private float day;
        private float chieucao;
        public float Day
        {
            set { day = value; }
            get { return day; }
        }

        public float ChieuCao
        {
            set { chieucao = value; }
            get { return chieucao; }
        }

        public HinhBinhHanh()
        {
        }

        public HinhBinhHanh(float a, float b)
        {
            Day = a;
            ChieuCao = b;
        }

        public override float DienTich()
        {
            return Day * ChieuCao;
        }

        public override void Nhap()
        {
            Console.WriteLine("Nhap day:");
            Day = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu cao:");
            ChieuCao = int.Parse(Console.ReadLine());
        }
    }

    class HinhChuNhat : HinhVe
    {
        private float chieudai;
        private float chieurong;
        public float ChieuDai

        {
            set { chieudai = value; }
            get { return chieudai; }
        }

        public float ChieuRong
        {
            set { chieurong = value; }
            get { return chieurong; }
        }

        public HinhChuNhat()
        {
        }

        public HinhChuNhat(float a, float b)
        {
            ChieuDai = a;
            ChieuRong = b;
        }

        public override float DienTich()
        {
            return ChieuDai * ChieuRong;
        }

        public override void Nhap()
        {
            Console.WriteLine("Nhap chieu dai:");
            ChieuDai = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong:");
            ChieuRong = int.Parse(Console.ReadLine());
        }
    }

    class HinhVuong : HinhChuNhat
    {
        private float canh;
        public float Canh
        {
            set { canh = value; }
            get { return canh; }
        }

        public HinhVuong()
        {
        }

        public HinhVuong(float a)
        {
            Canh = a;
        }

        public override float DienTich()

        {
            return Canh * Canh;
        }

        public override void Nhap()

        {
            Console.WriteLine("Nhap canh:");
            Canh = int.Parse(Console.ReadLine());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int check;
            Console.WriteLine("HinhThang(1)\nHinhBinhHang(2)\nHinhChuNhat(3)\nHinhVuong(4)");
            Console.WriteLine("Chon hinh can tinh: ");
            check = int.Parse(Console.ReadLine());
            if (check == 1)
            {
                HinhVe hv = new HinhThang();
                hv.Nhap();
                Console.WriteLine("Dien tich:{0}", hv.DienTich());
            }

            if (check == 2)
            {
                HinhVe hv = new HinhBinhHanh();
                hv.Nhap();
                Console.WriteLine("Dien tich:{0}", hv.DienTich());
            }

            if (check == 3)
            {
                HinhVe hv = new HinhChuNhat();
                hv.Nhap();
                Console.WriteLine("Dien tich:{0}", hv.DienTich());
            }

            if (check == 4)
            {
                HinhVe hv = new HinhVuong();
                hv.Nhap();
                Console.WriteLine("Dien tich:{0}", hv.DienTich());
            }
            Console.ReadKey();
        }
    }
}
