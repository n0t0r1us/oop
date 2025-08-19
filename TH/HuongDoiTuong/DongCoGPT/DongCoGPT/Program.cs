using System;
using System.Collections.Generic;

class DongCo
{
    private int _namSX;

    public int namSX
    {
        get { return _namSX; }
    }

    public DongCo(int namSX)
    {
        if (namSX < 1900 || namSX > DateTime.Now.Year)
        {
            throw new ArgumentException("Invalid year");
        }
        _namSX = namSX;
    }
}

class Xe
{
    private DongCo _dongCo;
    private string _bienSo;

    public string bienSo
    {
        get { return _bienSo; }
    }

    public Xe(DongCo dongCo, string bienSo)
    {
        _dongCo = dongCo;
        _bienSo = bienSo;
    }

    public int GetNamSX()
    {
        return _dongCo.namSX;
    }

    public void Nhap()
    {
        Console.Write("Nhap bien so: ");
        _bienSo = Console.ReadLine();
        Console.Write("Nhap nam san xuat: ");
        int namSX = int.Parse(Console.ReadLine());
        _dongCo = new DongCo(namSX);
    }

    public void Xuat()
    {
        Console.WriteLine("Bien so: " + _bienSo);
        Console.WriteLine("Nam san xuat: " + _dongCo.namSX);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap so luong xe: ");
        int n = int.Parse(Console.ReadLine());

        List<Xe> listXe = new List<Xe>();

        for (int i = 0; i < n; i++)
        {
            Xe xe = new Xe(new DongCo(0), "");
            xe.Nhap();
            listXe.Add(xe);
        }

        Console.WriteLine("Danh sach xe:");
        foreach (Xe xe in listXe)
        {
            xe.Xuat();
        }

        int minNamSX = int.MaxValue;
        List<Xe> listXeMinNamSX = new List<Xe>();

        foreach (Xe xe in listXe)
        {
            int namSX = xe.GetNamSX();
            if (namSX < minNamSX)
            {
                minNamSX = namSX;
                listXeMinNamSX.Clear();
                listXeMinNamSX.Add(xe);
            }
            else if (namSX == minNamSX)
            {
                listXeMinNamSX.Add(xe);
            }
        }

        Console.WriteLine("Xe co nam san xuat cu nhat:");
        foreach (Xe xe in listXeMinNamSX)
        {
            xe.Xuat();
        }

        listXe.Sort(delegate (Xe x, Xe y)
        {
            return x.GetNamSX().CompareTo(y.GetNamSX());
        });

        Console.WriteLine("Danh sach xe da sap xep theo nam san xuat:");
        foreach (Xe xe in listXe)
        {
            xe.Xuat();
        }

        Console.WriteLine("Cac xe co bien so bat dau bang '79':");
        foreach (Xe xe in listXe)
        {
            if (xe.bienSo.StartsWith("79"))
            {
                xe.Xuat();
            }
        }
    }
}