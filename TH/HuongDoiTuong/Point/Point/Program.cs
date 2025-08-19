using System;
public class Point
{
    // phuong thuc thuoc tinh 
    private double _x, _y;
    public double PI = 3.141416;
    public double X
    {
        get { return _x; }
        set { _x = value; }

    }
    public double Y
    {
        get { return _y; }
        set { _y = value; }

    }
    // constructor
    public Point(double m = 0, double n = 0)
    {
        _x = m;
        _y = n;
    }
    // THIET LAP SAO CHEP
    public Point(Point p)
    {
        _x = p._x;
        _y = p._y;

    }
    // Thiet lsp point (nhap va xuat point )

    public void ThietLap()
    {
        Console.WriteLine("Nhap hoanh do :");
        X = double.Parse(Console.ReadLine());
        Console.WriteLine("Nhap tung do :");
        Y = double.Parse(Console.ReadLine());

    }
    // Xuat point 
    public void Xuat()
    {
        Console.WriteLine("({0},{1})");
    }
    public override string ToString()
    {
        return $"({X},{Y})";
    }
}
public class Circle
{
    public double PI = 3.141416;
    private Point Point_center;
    private double _radius;

    public Point PointCenter
    {
        get { return Point_center; }

    }

    public Point Point_Center { get; }

    public double Radius
    {
        get { return _radius; }
        set { _radius = value; }
    }

    public void ThietLap()
    {
        Console.WriteLine("Nhap Toa Do :");
        PointCenter.ThietLap();
        do
        {
            Console.WriteLine("Nhap ban kinh :");
            Radius = double.Parse(Console.ReadLine());
            if (Radius < 0)
                Console.WriteLine("Ban kinh khong hop le !");

        } while (Radius < 0);
    }

    public double DienTich()
    {
        return PI * Radius * Radius;
    }

    // khai bao tam hinh tron 
    public Circle()
    {
        Point A = new Point(0, 0);
        Point_Center = A;
        Radius = 0;
    }
}
class Program
{
    static void main()
    {
        Circle[] c;
        int n;
        do
        {
            Console.WriteLine("Nhap so luong hinh tron :");
            n = int.Parse(Console.ReadLine());

        } while (n < 3 || n > 100);
        c = new Circle[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Nhap hinh thu " + (i + 1));
            c[i] = new Circle();
            c[i].ThietLap();
        }
        for (int i = 0; i < n; i++)

            Console.WriteLine(" Hinh tron thu " + (i + 1) + "co toa do" + c[i].PointCenter.ToString() + "co ban kinh = " + c[i].Radius + "dien tich la :" + c[i].DienTich());
        //tim dien tich lon nhat cua hinh tron 
        double Smax = c[0].DienTich();
        int tam = 0;
        for (int i = 0; i < n; i++)
            if (tam < c[i].DienTich())
            {
                Smax = c[i].DienTich();
                tam = i + 1;
            }
        Console.WriteLine("Hinh tron co dien tich lon nhat la hinh thu " + tam);
        // sap xep mang hinh tron theo thu tu giam dan cua dien tich va in ra danh sach 
        Circle bientam = new Circle();
        for (int i = 0; i < n - 1; i++)
            for (int j = i + 1; j < n; j++)
            {
                bientam = c[i];
                c[i] = c[j];
                c[j] = bientam;
            }
        for (int i = 0; i < n; i++)
            Console.WriteLine("Hinh tron tu " + (i + 1) + "Co toa do " + c[i].PointCenter.ToString() + "Co ban kinh bang " + c[i].Radius + "co dien tich la " + c[i].DienTich());
    }
}
