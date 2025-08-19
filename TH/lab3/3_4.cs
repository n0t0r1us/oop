using System;
namespace Bai3_4
{
    class Printer
    {
        public string _nhaSX { get; set; }
        public double _gia { get; set; }
        
        public Printer()
        {
            _nhaSX = "";
            _gia = 0;
        }
        public Printer(string nhasx, double gia)
        {
            _nhaSX = nhasx;
            _gia = gia;
        }
        
        public void Nhap()
        {
            Console.Write("Nhap ten nha sx:");
            _nhaSX = Console.ReadLine();
            Console.Write("Nhap gia:");
            _gia = double.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("Nha san xuat" + _nhaSX);
            Console.WriteLine("Gia tien:{0}", _gia);
        }
        public Printer(Printer p)
        {
            _nhaSX = p._nhaSX;
            _gia = p._gia;
        }
    }
    class LaserPrinter : Printer
    {
        protected string _dpi { get; set; }
        
        public LaserPrinter() : base()
        {
            _dpi = "";
        }
        
        public LaserPrinter(string nhaSX, double gia, string dpi) : base(nhaSX, gia)
        {
            _dpi = dpi;
        }
        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap do phan giai:");
            _dpi = Console.ReadLine();
        }
        public new void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Do phan giai:" + _dpi);
        }
        public LaserPrinter(LaserPrinter p) : base((Printer)p)
        {
            _dpi = p._dpi;
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("So luong may in laser:");
                int n = int.Parse(Console.ReadLine());
                LaserPrinter[] laser = new LaserPrinter[n];
                
                Console.WriteLine(" Nhap thong so may in ");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Nhap thong so may in {0} ", i + 1);
                    laser[i] = new LaserPrinter();
                    laser[i].Nhap();
                }
                
                Console.WriteLine(" Thong so may in ");
                for (int i =0; i < n; i++)
                {
                    Console.WriteLine("Thong so may in {0} ", i + 1);
                    laser[i].Xuat();
                }
                
                LaserPrinter max = new LaserPrinter(laser[0]);
                LaserPrinter min = new LaserPrinter(laser[0]);
                for (int i = 1; i < n; i++)
                {
                    if (laser[i]._gia > max._gia)
                    {
                        max = laser[i];
                    }
                    if (laser[i]._gia < min._gia)
                    {
                        min = laser[i];
                    }
                }
                Console.WriteLine(" Thong so may in co gia lon nhat ");
                max.Xuat();
                Console.WriteLine(" Thong so may in co gia nho nhat ");
                min.Xuat();
                
                Console.Write(" Loc theo hang san xuat ");
                Console.Write("Nhap vao hang san xuat can loc:");
                string hang = Console.ReadLine();
                
                Console.WriteLine(" Thong tin may in sau khi loc ");
                for (int i = 0; i < n; i++)
                {
                    if (hang.Equals(laser[i]._nhaSX) == true)
                    {
                        laser[i].Xuat();
                    }
                }
                
                LaserPrinter tam = new LaserPrinter(laser[0]);
                
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 1 + 1; j < n; i++)
                    {
                        if (laser[i]._gia > laser[j]._gia)
                        {
                            tam = laser[i];
                            laser[i] = laser[j];
                            laser[j] = tam;
                        }
                    }
                }
                Console.WriteLine(" Thong so may in sau khi sap xep ");
                for (int i = 0; i < n; i++)
                {
                    laser[i].Xuat();
                }
            }
        }
    }
}