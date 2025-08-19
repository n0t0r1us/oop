/*
Một loại vi trùng cứ sau mỗi giờ lại nhân đôi. Hỏi ban đầu có n con vi trùng thì sau h giờ số lượng là bao nhiêu?

Input:
- Số lượng vi trùng ban đầu (con)
- Khoảng thời gian (giờ).

Output: Số lượng vi trùng sau khoảng thời gian đã cho.
*/
using System;

namespace Vitrung
{
    class Program
    {
        static int Main()
        {
            int h;
            long n;
            int i = 1;
            Console.Write("Nhap so vi trung ban dau:");
            n = long.Parse(Console.ReadLine());
            Console.Write("Nhap so gio:");
            h = int.Parse(Console.ReadLine());
            while (i <= h)
            {
                n = n * 2;
                i++;
            }
            Console.Write("So luong vi trung sau {0} gio la:{1}", h, n);
            return 0;
        }
    }
}