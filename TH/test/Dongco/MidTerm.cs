/*
Bài kiểm tra giữa kỳ.
Họ và tên: Nguyễn Thành Đạt
MSSV: 61130137
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXe
{
    class DongCo
    {
        private int _namSX;
        public int NamSx
        {
            get{ return _namSX;}
            set{ _namSX = value;}
        }
        public DongCo()
        {
            NamSx=0;
        }
        public DongCo(int n)
        {
            NamSx = n;
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap nam san xuat:");
            NamSx = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("Nam san xuat:{0}", NamSx);
        }
    }
    class XeHoi
    {
        private string _bienSo;
        private int _namSX;
        public int NamSx
        {
            get{ return _namSX;}
            set{ _namSX = value;}
        }
        public string BienSo
        {
            get{return _bienSo;}
            set{_bienSo=value;}
        }
        public XeHoi()
        {
            BienSo="";
            NamSx=0;
        }
        public XeHoi(string b, int n)
        {
            BienSo = b;
            NamSx = n;
        }
        public new void Nhap()
        {
            Console.WriteLine("Nhap nam san xuat:");
            NamSx = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap bien so xe:");
            BienSo = Console.ReadLine();
            Console.WriteLine("------------------------");
        }
        public new void Xuat()
        {
            Console.WriteLine("Nam san xuat:{0}", NamSx);
            Console.WriteLine("Bien so:{0}",BienSo);
        }
        static public void tim(XeHoi[] p, int n)
        {
            string a;
            Console.WriteLine("Nhap bien so muon tim:");
            a= Console.ReadLine();
            for(int i=0; i<n;i++)
            {
                if(a[0]==p[i].BienSo[0]&&a[1]==p[i].BienSo[1])
                {
                    p[i].Xuat();
                }
                else
                {
                    Console.WriteLine("Khong co xe nay.");
                }
            }
            for(int i=0;i<n;i++)
            {
                p[i].Xuat();
            }
        }
         static public void SapXep(XeHoi[] p, int n)
        {
            for(int i=0; i<n-1;i++)
            {
                for(int j=i+1; j<n;j++)
                {
                    if(p[i].NamSx>p[j].NamSx)
                    {
                        XeHoi q = new XeHoi();
                        q=p[j];
                        p[j]=p[i];
                        p[i]=q;
                    }
                }
            }
        }
        static public void Xecunhat(XeHoi[] p, int n)
        {
            int vtmin =0;
             for(int i=0; i<n;i++)
            {
                if(p[vtmin].NamSx<=p[i].NamSx)
                {
                    vtmin = i;
                }
            }
            for(int i=0; i<n;i++)
            {
                if(p[i].NamSx==p[vtmin].NamSx)
                {
                    p[i].Xuat();
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            XeHoi[] p = new XeHoi[50];
            do
            {
                Console.WriteLine("Nhap so xe hoi:");
                n= int.Parse(Console.ReadLine());
                if(n<3||n>100)
                {
                    Console.WriteLine("So xe khong hop le(3<=n<=100). Xin nhap lai.");
                }
            }while(n<3||n>100);
            for(int i=0; i<n;i++)
            {
                Console.WriteLine("Nhap thon tin xe:");
                p[i]= new XeHoi();
                p[i].Nhap();
            }
            for(int i=0; i<n;i++)
            {
                Console.WriteLine("Thong tin xe {0}:",i);
                p[i].Xuat();
            }
            
            Console.WriteLine("-------------");
            XeHoi.tim(p,n);
            Console.WriteLine("-------------");
            XeHoi.SapXep(p,n);
            Console.WriteLine("-------------");
            XeHoi.Xecunhat(p,n);
        }
        
    }
}
