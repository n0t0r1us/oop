using System;

namespace Bai2_4
{
    public static class Constants
    {
        public const double PI = 3.1416;
    }
    //Khai báo lớp hình tròn
    class Circle
    {
        private double _r;
        public double R
        {
            get { return _r; }
            set { value = _r; }
        }
        public Circle(double r)
        {
            _r = r;
        }
        public Circle(Circle c)
        {
            _r = c._r;
        }
        // Tinh dien tich hinh tron
        public double Area()
        {
            return _r * _r * Constants.PI;
        }
    } // End of Circle class


    // Main program 
    class Program
    {
        static void Main()
        {
            int number;
            Console.WriteLine("Nhap ban kinh: ");
            number = int.Parse(Console.ReadLine());
            //Tao dt
            Circle c = new Circle(number);
            Console.WriteLine("Dien tich hinh tron = {0}", c.Area());
            Circle c1 = new Circle(c);
        }
    } // End of class Program
}