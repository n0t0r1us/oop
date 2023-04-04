using System;

namespace Bai2_1
{
    //Khai báo lớp Phân số
    public class PhanSo
    {
        private int _tuSo = 0, _mauSo = 1;

        public int TuSo
        {
            get { return _tuSo; }
            set { _tuSo = value; }
        }
        public int MauSo
        {
            get { return _mauSo; }
        }
        public PhanSo(int tuSo = 0, int mauSo = 1)
        {
            if (mauSo == 0)
                throw new ArgumentException("Mau so phai khac 0.", nameof(mauSo));
            this._tuSo = tuSo;
            this._mauSo = mauSo;
        }
        public PhanSo(PhanSo p)
        {
            _tuSo = p._tuSo;
            _mauSo = p._mauSo;

        }
        public void Nhap()
        {
            Console.Write("Tu so =");
            _tuSo = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.Write("Mau So =");
                _mauSo = Convert.ToInt32(Console.ReadLine());
                if (_mauSo == 0) Console.Write("Mau so phai != 0");
            } while (_mauSo == 0);
        }
        public void Xuat()
        {
            Console.WriteLine("{0}/{1}", _tuSo, _mauSo);
        }
        public void ToiGian()
        {
            int ucln = 1;
            for (int i = Math.Min(Math.Abs(_tuSo), Math.Abs(_mauSo)); i > 1; i--)
                if (_mauSo % i == 0 && _tuSo % i == 0)
                {
                    ucln = i;
                    break;
                }
            _tuSo /= ucln;
            _mauSo /= ucln;
        }
        public double GiaTri()
        {
            return Convert.ToDouble(_tuSo) / _mauSo;
        }
        public void Cong(PhanSo p)
        {
            _tuSo = _tuSo * p._mauSo + _mauSo * p._tuSo;
            _mauSo = _mauSo * p._mauSo;
        }
        public void Tru(PhanSo p)
        {
            if (this._tuSo != 0)
            {
                _tuSo = _tuSo * p._mauSo - _mauSo * p._tuSo;
                _mauSo = _mauSo * p._mauSo;
            }
            else
            {
                _tuSo = -p._tuSo;
                _mauSo = p._mauSo;
            }
        }
    } // End of class PhanSo


    // Main program 
    class Program
    {
        static void Main(string[] args)
        {
            PhanSo p1 = new PhanSo();
            p1.Nhap();
            p1.Xuat();
            p1.ToiGian();
            Console.WriteLine("Phan so toi gian:");
            p1.Xuat();
            //nhap phan số 2
            PhanSo p2 = new PhanSo();
            Console.WriteLine("Nhap phan so thu hai:");
            p2.Nhap();
            p2.Xuat();
            p2.ToiGian();
            Console.WriteLine("Phan so thu hai toi gian:");
            p2.Xuat();
            //Tổng 2 số
            p1.Cong(p2);
            Console.WriteLine("Tong 2 phan so:");
            p1.ToiGian();
            p1.Xuat();
            //Hiệu 2 số
            p1.Tru(p2);
            Console.WriteLine("Hieu 2 phan so:");
            p1.ToiGian();
            p1.Xuat();
        }
    } // End of class Program
}