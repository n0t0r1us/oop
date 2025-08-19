using System;

namespace Bai2_3
{
    //Khai báo lớp Point
    public class Point
    {
    private int _x;
        private int _y;

        public int _Hoanhdo
        {
            get { return _x; }
            set { _x = value; }
        }
        public int _Tauso
        {
            get { return _y; }
            set { _y = value; }
        }
        public Point(int t = 0, int m = 1)
        {
            _x = t;
            _y = m;
        }
        public void Nhap()
        {
            Console.Write("x = ");
            _x = int.Parse(Console.ReadLine());
           
            Console.Write("y = ");
            _y = int.Parse(Console.ReadLine());
            
        }

        public void Xuat()
        {
            Console.Write("({0}/{1}) ", _x, _y);
        }
    } // End of Point
    
    
    // Main program 
    class Program
    {
        static void Main()
        {
             int number;
            Point p = new Point();
            Console.Write("Nhap so luong: ");
            number = int.Parse(Console.ReadLine());
            Point[] pslist = new Point[number];
            for (int i = 0; i < number; i++)
            {
                pslist[i] = new Point();
                Console.WriteLine("Nhap toa do thu {0} ", i + 1);
                pslist[i].Nhap();
            }
            Console.WriteLine("Danh sach toa do :");
            for (int i = 0; i < number; i++)
                pslist[i].Xuat();
        }
    } // End of class Program
}