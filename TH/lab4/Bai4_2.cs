using System;

namespace Bai4_2
{
    abstract class Shape
    {
        public abstract string Name { get; set; }
        public abstract double Area();
        public abstract void Input();
        public abstract void Output();
    }

    class Rectangle : Shape
    {
        private double _width, _height;
        public override string Name
        {
            get { return "Chu Nhat"; }
            set { value = "Chu Nhat"; }
        }

        public Rectangle(double _w = 0, double _h = 0)
        {
            _width = _w;
            _height = _h;
        }

        public override void Input()
        {
            Console.Write("Nhap vao chieu rong:");
            _width = double.Parse(Console.ReadLine());
            Console.Write("Nhap vao chieu dai:");
            _height = double.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            Console.Write(Name);
            Console.Write("\tRong:= {0}, Dai:= {1}", _width, _height);
            Console.Write("\tDien tich:= {0}", Area());
        }

        public override double Area()
        {
            return _width * _height;
        }
    }



    class Circle : Shape
    {
        private double _radius;

        public override string Name
        {
            get { return "Tron"; }
            set { value = "Tron"; }
        }

        public Circle(double r = 0)
        {
            if (r < 0) throw new ArgumentOutOfRangeException("Ban kinh phai >=0!", nameof(r));
            _radius = r;
        }

        public override void Input()
        {
            do
            {
                Console.Write("Nhap vao ban kinh:");
                _radius = double.Parse(Console.ReadLine());
            } while (_radius < 0);
        }

        public override void Output()
        {
            Console.Write(Name);
            Console.Write("\tBan kinh:= {0}\tDien tich:= {1}", _radius, Area());

        }

        public override double Area()
        {
            return _radius * _radius * 3.1416;
        }

    }



    class Triangle : Shape
    {
        private double _a, _b, _c;

        public override string Name
        {
            get { return "Tam giac"; }
            set { value = "Tam giac"; }
        }

        public static bool IsTriangle(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a) return true;
            else return false;
        }

        public Triangle(double a = 0, double b = 0, double c = 0)
        {
            if (IsTriangle(a, b, c) == true)
            {
                _a = a;
                _b = b;
                _c = c;

            }
        }

        public override void Input()
        {
            do
            {
                Console.Write("Nhap a:");
                _a = double.Parse(Console.ReadLine());
                Console.Write("Nhap b:");
                _b = double.Parse(Console.ReadLine());
                Console.Write("Nhap c:");
                _c = double.Parse(Console.ReadLine());
                if (IsTriangle(_a, _b, _c) == false)
                    Console.WriteLine("a, b, c không tao thanh tam giac, vui long nhap lai ! ");
            } while (IsTriangle(_a, _b, _c) == false);
        }

        public override void Output()
        {
            Console.Write(Name);
            Console.Write("\ta:= {0}, b:= {1}, c= {2}", _a, _b, _c);
            Console.Write("\tDien tich:= {0}", Area());
        }


        public override double Area()
        {
            double p = (_a + _b + _c) / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }
    }



    class Square : Rectangle
    {

        public Square(double _w = 0) : base(_w, _w)
        {

        }
        public override string Name
        {
            get { return "Vuong"; }
            set { value = "Vuong"; }
        }



    }



    class ListShape
    {
        private int _n;
        private Shape[] s;

        public int N
        {
            get { return _n; }
            set { value = _n; }

        }

        public void Input()
        {
            int loai;
            do
            {
                Console.Write("Nhap so luong hinh ve:");
                _n = int.Parse(Console.ReadLine());
            } while (_n <= 0);

            s = new Shape[_n];

            Console.WriteLine("1: hinh chu nhat, 2: hinh tron, 3: hinh tam giac, 4: hinh vuong ");

            for (int i = 0; i < _n; i++)
            {
                Console.WriteLine("Hinh ve thu {0}", i + 1);
                do
                {
                    Console.Write("Nhap loai hinh ve : ");
                    loai = int.Parse(Console.ReadLine());
                } while ((loai <= 0) || (loai > 4));

                switch (loai)
                {
                    case 1:
                        {
                            s[i] = new Rectangle();
                            s[i].Input();
                            break;
                        }
                    case 2:
                        {
                            s[i] = new Circle();
                            s[i].Input();
                            break;
                        }
                    case 3:
                        {
                            s[i] = new Triangle();
                            s[i].Input();
                            break;
                        }
                    case 4:
                        {
                            s[i] = new Square(4.5);
                            break;
                        }
                }

            }

        }

        public void Output()
        {
            for (int i = 0; i < _n; i++)
            {
                Console.WriteLine("Thong tin hinh thu {0}", i + 1);
                s[i].Output();
                Console.Write("\n");
            }
        }

        public Shape Max()
        {
            Shape max = s[0];
            for (int i = 0; i < _n; i++)
            {
                if (s[i].Area() > max.Area())
                    max = s[i];
            }
            return max;
        }

        public void Sort()
        {
            for (int i = 0; i < _n - 1; i++)
                for (int j = i + 1; j < _n; j++)
                    if (s[i].Area() < s[j].Area())
                    {
                        Shape tam;
                        tam = s[i];
                        s[i] = s[j];
                        s[j] = tam;
                    }
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            ListShape l = new ListShape();
            l.Input();
            l.Output();
            Console.WriteLine("\nHinh {0} co S lon nhat: {1} ", l.Max().Name, l.Max().Area());
            l.Sort();
            Console.WriteLine("\nDanh sach sau khi sap sep giam dan dien tich:");
            l.Output();

        }
    }


}