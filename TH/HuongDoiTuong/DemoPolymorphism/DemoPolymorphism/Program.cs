public class HinhVe
{
    public virtual double TinhDienTich()
    {
        return 0;
    }
}
public class HinhTron : HinhVe
{
    public double banKinh;
    public HinhTron(double r = 0)
    {
        banKinh = r;
    }
    public override double TinhDienTich()
    {
        return banKinh * banKinh * Math.PI;
    }
}
public class HinhCN : HinhVe
{
    public double chieuRong;
    public double chieuDai;
    public HinhCN(double d = 0, double r = 0)
    {
        chieuRong = r;
        chieuDai = d;
    }
    public override double TinhDienTich()
    {
        return chieuDai * chieuRong;
    }
     
    public class Program
    {
        public static void Main(string[] args)
        {
            var hinhve = new List<HinhVe>
            {
                new HinhTron(3),
                new HinhCN(3,2),
                new HinhTron(2),
                new HinhCN(3,5)
            };
            Console.WriteLine("Danh sach hinh");
            foreach (var h in hinhve)
            {
                Console.WriteLine("Day la hinh {0} có dien tich {1}",h.GetType(),h.TinhDienTich());
            }

            double maxDienTich = 0;
             for(int i = 0; i < hinhve.Count; i++)
            {
                if (hinhve[i].TinhDienTich()>maxDienTich)
                    maxDienTich = hinhve[i].TinhDienTich();
            }
            Console.WriteLine("Cac hinh co dien tich lon nhat");
            for (int i = 0; i < hinhve.Count; i++)
            {
                if (hinhve[i].TinhDienTich() == maxDienTich)
                    Console.WriteLine("Vi tri {0}  thu {1}", i, hinhve[i].GetType());
            }
        }
    }
}