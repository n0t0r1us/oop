namespace Bai2_2
{
    class PhanSo
    {
        public int TuSo;
        public int MauSo;
        public PhanSo()
        {
            TuSo = 0;
            MauSo = 1;
        }
        public PhanSo(int t, int m)
        {
            TuSo = t;
            MauSo = m;
        }
        public PhanSo(PhanSo ps)
        {
            TuSo = ps.TuSo;
            MauSo = ps.MauSo;
        }
        public void Nhap()
        {
            Console.Write("Nhap tu so: ");
            TuSo = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.Write("Nhap mau so: ");
                MauSo = Convert.ToInt32(Console.ReadLine());
            } while (MauSo == 0);
        }
        public void Xuat()
        {
            Console.Write("{0}/{1}\t", TuSo, MauSo);
        }
    }

    //Khai báo lớp Phân số
    public class DSPhanSo
    {
        int size;
        List<PhanSo> dsps;
        public void NhapPS()
        {
            Console.Write("Nhap so luong phan so: ");
            size = Convert.ToInt32(Console.ReadLine());
            dsps = new List<PhanSo>();
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Nhap phan so thu {0}", i + 1);
                PhanSo ps = new PhanSo();
                ps.Nhap();
                dsps.Add(ps);
            }
        }
        public void XuatPS()
        {
            for (int i = 0; i < size; i++)
            {
                dsps[i].Xuat();
            }
            Console.WriteLine();
        }
        public void PSMAX()
        {
            PhanSo max = new PhanSo();
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    float x = (float)dsps[i].TuSo / (float)dsps[i].MauSo;
                    float y = (float)dsps[j].TuSo / (float)dsps[j].MauSo;
                    if (x > y)
                    {
                        max = dsps[i];
                    }
                    else
                        max = dsps[j];
                }
            }
            Console.Write("Phan so lon nhat trong danh sach la: ");
            Console.WriteLine("{0}/{1}", max.TuSo, max.MauSo);
        }
        public void SapXep()
        {
            PhanSo temp = new PhanSo();
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    float x = (float)dsps[i].TuSo / (float)dsps[i].MauSo;
                    float y = (float)dsps[j].TuSo / (float)dsps[j].MauSo;
                    if (x > y)
                    {
                        temp = dsps[i];
                        dsps[i] = dsps[j];
                        dsps[j] = temp;
                    }
                }
            }
            Console.WriteLine("Danh sach phan so theo thu tu tang dan cua gia tri: ");
            for (int i = 0; i < size; i++)
            {
                dsps[i].Xuat();
            }
            Console.WriteLine();
        }
    }
    // End of class DSPhanSo


    // Main program 
    class Program
    {
        static void Main(string[] args)
        {
            DSPhanSo ds = new DSPhanSo();
            ds.NhapPS();
            Console.Write("Danh sach cac phan so vua nhap: \n");
            ds.XuatPS();
            ds.PSMAX();
            ds.SapXep();
        }
    } // End of class Program
}