/*
Viết chương trình nhập từ bàn phím hai số nguyên a, b và một ký tự ch.
Nếu:
- ch là "+" thì thực hiện phép tính a + b và in kết quả lên màn hình.
- ch là "–" thì thực hiện phép tính a - b và in kết quả lên màn hình.
- ch là "*" thì thực hiện phép tính a * b và in kết quả lên màn hình.
- ch là "/" thì thực hiện phép tính a / b và in kết quả lên màn hình. 
Lưu ý kiểm tra điều kiện của phép chia. Nếu b == 0 thì in ra thông báo "Error!"
*/

using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            char phepToan;
            double ketQua = 0;

            // Input: Không thay đổi phần này
            Console.Write("Nhap a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhap phep toan (+,-,*,/): ");
            phepToan = char.Parse(Console.ReadLine());

            /* Viết code xử lý của bạn ở đây
               Dựa vào a,b và phép toán nhập vào hãy tính giá trị biểu thức
               và in giá trị biểu thức lên màn hình.
              
            */
            if (phepToan == '+')
            {
                ketQua = a + b;
                Console.WriteLine("Ket qua phep tinh cong:{0}", ketQua);
            }
            else if (phepToan == '-')
            {
                ketQua = a - b;
                Console.WriteLine("Ket qua phep tinh tru:{0}", ketQua);
            }
            else if (phepToan == '*')
            {
                ketQua = a * b;
                Console.WriteLine(" Ket qua phep tinh nhan:{0}", ketQua);
            }
            else if (phepToan == '/')
            {
                if (b == 0)
                    Console.WriteLine("Loi");
                else
                {
                    ketQua = a / b;
                    Console.WriteLine("Ket qua phep tinh chia:{0}", ketQua);
                }
            }
        }
    }
}

          
          