/*
Bài kiểm tra giữa kỳ.
Họ và tên:
MSSV:
*/

using System;

// Viết code của bạn ở đây
namespace Quanlyxe
{
    class Dongco
    {
        private int _namSX;


        public int getNamSX
        {
            get return namSX;
        }


        public Dongco(int Namsx = 2020)
        {
            try
            {

                Console.Write("Namsanxuat: ");
                _namSX = int.Parse(Console.ReadLine());

            }
            catch (Exception e)
            {
                Console.WriteLine("Nhap sai nam: ");
            }
        }


    }
    class Xe
    {
        Dongco _dongco;
        string _bienso;

        public string Bienso
        {
            get { return _bienso; }
        }
        public int NamSX()
        {
            return _dongco.getNamSX;
        }

        public Xe(string bienso)
        {
            _bienso = bienso;
            _dongco = new Dongco();
        }

        public void Nhap()
        {
            Console.Write("Bien so: ");
            _bienso = Console.ReadLine();
        }
        public void Xuat()
        {
            Console.WriteLine("Bien so: {0}, nam san xuat: {1}", _bienso, _dongco.getNamSX);

        }
        static public void Timkiem(Xe[] p, int n)
        {
            string z;
            Console.WriteLine("Nhap 2 cho so xe muon tim kiem: ");
            z = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                if (z[0] == p[i].Bienso[0] && z[1] == p[i].Bienso[1])
                { p[i].Xuat(); }
            }
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap so luong xe: ");
                n = Convert.ToInt32(Console.ReadLine());

            } while (n < 0 || n > 50);

            Xe[] p = new Xe[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Nhap thong tin xe {0}", i + 1);
                p[i] = new Xe("79A");
                p[i].Nhap();
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Xe thu {0}", i + 1);
                p[i].Xuat();
            }
            Console.WriteLine();
            Xe.Timkiem(p, n);

        }
    }
}
