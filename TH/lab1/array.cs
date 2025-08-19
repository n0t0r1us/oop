using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mang_1_chieu
{
    class Program
    {
        static void nhap(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "]=");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        static void xuat(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + "    ");
        }

        static int max(int[] a, int n)
        {
            int max = a[0];
            for (int i = 0; i < n; i++)
                if (max < a[i])
                    max = a[i];
            return max;
        }

        static bool Sortcheck(int[] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                if (a[i] > a[i + 1])
                    return false;
            }
            return true;
        }

        static void Sort(int[] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                    if (a[i] > a[j])
                    {
                        int t = a[i];
                        a[i] = a[j];
                        a[j] = t;
                    }
        }

        static void TachMang(int[] a, int n, int[] le, int nle, int[] chan, int nchan)
        {
            nle = 0;
            nchan = 0;
            for (int i = 0; i < n; i++)
                if (a[i] % 2 == 0)
                {
                    chan[nchan] = a[i];
                    nchan++;
                }
                else
                {
                    le[nle++] = a[i];
                }
        }

        static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu cua mang:");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[100];
            //Câu a
            nhap(a, n);
            //Câu b
            Console.Write("Hien thi mang:");
            xuat(a, n);
            //Câu c
            Console.Write("\nPhan tu lon nhat trong mang la:{0}", max(a, n));
            //Câu d
            if (Sortcheck(a,n)) Console.Write("\nMang tang dan");
            else Console.Write("\nMang khong tang dan");
            //Câu e
            Sort(a, n);
            Console.Write("\n---Mang sau khi sap xep-----");
            xuat(a, n);
            //Câu f
            Console.Write("\n---Tach mang-----");
            int nle = int.Parse(Console.ReadLine());
            int nchan = int.Parse(Console.ReadLine());
            int[] le = new int[100];
            int[] chan = new int[100];
            TachMang(a, n, le, nle, chan, nchan);
            Console.Write("\nMang le:\n");
            xuat(le, nle);
            Console.Write("\nMang chan:\n");
            xuat(chan, nchan);
            Console.ReadKey();
        }
    }
}