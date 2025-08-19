using QLSinhVien;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLSinhVien
{
    class sinhvien
    {
        private string maSV;
        private string hoTen;
        private float diemTB;
        public string MaSV { get => maSV; set => maSV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public float DiemTB
        {
            get
            {
                return diemTB;
            }
            set
            {
                if (value < 0 || value > 10)
                    Console.WriteLine("Nhập điểm trong khoảng từ 0 đến 10");
                else
                    diemTB = value;
            }
        }

        public void NhapTT()
        {
            Console.Write("Nhap Ma SV:");
            maSV = Console.ReadLine();
            Console.Write("Nhap Ho Ten:");
            hoTen = Console.ReadLine();
            Console.Write("Nhap Diem TB:");
            diemTB = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("");
        }
    }
}
    class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap vao n sinh vien:");
        int n = Convert.ToInt32(Console.ReadLine());
        sinhvien[] a = new sinhvien[n];
        while (n < 1 || n > 100)
        {
            Console.Write("So luong sinh vien phai nam trong khoang tu 1 den 100. Vui long nhap lai: ");
            n = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Nhap Thong Tin SV THU " + (i + 1));
            a[i] = new sinhvien();
            a[i].NhapTT();
        }
        sinhvien tb;
    
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (a[i].DiemTB < a[j].DiemTB)

                {
                    tb = a[i];
                    a[i] = a[j];
                    a[j] = tb;
                }
            }
        }
        Console.WriteLine("\n Sap xep SV theo Diem TB Giam dan:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\n MaSV: {0} | Ho Ten: {1} |Diem TB: {2}", a[i].MaSV, a[i].HoTen, a[i].DiemTB);
        }
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("\n Cac SV co diem TB cao nhat :");
        for (int i = 0; i<3; i++)
        {
            Console.WriteLine("\n MaSV: {0} | Ho Ten: {1} |Diem TB: {2}", a[i].MaSV, a[i].HoTen, a[i].DiemTB);
        }
        Console.ReadKey();
    }
}
