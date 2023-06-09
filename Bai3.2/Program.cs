﻿    using System;

    namespace QLNhanVien
    {

        class NhanVien

        {
            private string hoten;
            private string ngaysinh;
            private int luong;
            public string HoTen
            {
                get { return hoten; }
                set { hoten = value; }
            }

            public string NgaySinh
            {
                get { return ngaysinh; }
                set { ngaysinh = value; }
            }

            public int Luong
            {
                get { return luong; }
                set { luong = value; }
            }

            public NhanVien()
            {
                HoTen = "";
                NgaySinh = "";
                Luong = 0;
            }

            public NhanVien(string a, string b, int c)
            {
                HoTen = a;
                NgaySinh = b;
                Luong = c;
            }

            public virtual void Nhap()

            {
                Console.WriteLine("Nhap ho ten:");
                HoTen = Console.ReadLine();
                Console.WriteLine("Nhap ngay sinh:");
                NgaySinh = Console.ReadLine();
            }

            public virtual void Xuat()
            {
                Console.WriteLine("HoTen:{0}\tNgaySinh:{1}\tLuong:{2}", HoTen, NgaySinh, Luong);
            }

            public virtual int inluong()
            {
                return 0;
            }

        }
        class NVVanPHong : NhanVien

        {
            private int songaylam;
            public int SoNgayLam
            {
                get { return songaylam; }
                set { songaylam = value; }
            }

            public NVVanPHong()
                : base()
            {
                SoNgayLam = 0;
            }
            public NVVanPHong(string a, string b, int c, int d)
                : base(a, b, c)
            {
                SoNgayLam = d;
            }
            public override void Nhap()
            {
                base.Nhap();
                Console.WriteLine("Nhap so ngay lam viec:");
                SoNgayLam = int.Parse(Console.ReadLine());
            }
            public override int inluong()
            {
                Luong = SoNgayLam * 100000;
                return Luong;
            }
            public override void Xuat()
            {
                base.Xuat();
            }
        }
        class NVSanXuat : NhanVien
        {
            private int luongcb;
            private int sosp;
            public int LuongCB
            {
                set { luongcb = value; }
                get { return luongcb; }
            }
            public int SoSP
            {
                set { sosp = value; }
                get { return sosp; }
            }
            public NVSanXuat()
            {
                LuongCB = 0;
                SoSP = 0;
            }
            public NVSanXuat(string a, string b, int c, int d, int e)
                : base(a, b, c)
            {
                LuongCB = d;
                SoSP = e;
            }
            public override void Nhap()
            {
                base.Nhap();
                Console.WriteLine("Nhap luong co ban:");
                LuongCB = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap so sp:");
                SoSP = int.Parse(Console.ReadLine());
            }
            public override void Xuat()
            {
                base.Xuat();
            }
            public override int inluong()
            {
                Luong = LuongCB + SoSP * 5000;
                return Luong;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                int n;
                int check;
                Console.WriteLine("Nhap so nhan vien:");
                n = int.Parse(Console.ReadLine());
                NhanVien[] p = new NhanVien[n];
                NhanVien n1 = new NVSanXuat();
                // nhap va in thong tin nhan vien
                for (int i = 0; i < n; i++)
                {
                    Console.Write("NVvp(1)....NVsx(2)");
                    check = int.Parse(Console.ReadLine());
                    if (check == 1)
                    {
                        p[i] = new NVVanPHong();
                        p[i].Nhap();
                        p[i].inluong();
                    }
                    if (check == 2)
                    {
                        p[i] = new NVSanXuat();
                        p[i].Nhap();
                        p[i].inluong();
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    p[i].Xuat();
                }
                // sap xep theo luong giam dan

                //tim so lon nhat trong mang
                int d = 0;
                while (d < n)
                {
                    int vtmax = 0;
                    for (int i = 1; i < n; i++)
                    {
                        if (p[vtmax].inluong() <= p[i].inluong())
                        {
                            vtmax = i;
                        }
                    }
                    p[vtmax].Xuat();
                    //xoa so lon nhat trong mang
                    for (int i = vtmax; i < n - 1; i++)
                    {
                        p[i] = p[i + 1];
                    }
                    d++;
                }
                Console.ReadKey();
            }
        }
    }