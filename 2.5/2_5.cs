using System;

namespace Bai2_5
{
    class Program
    {
        class Stack
        {
            private static readonly int max = 1000;
            private int _top;
            private int[] stack = new int[max];



            public Stack()
            {
                _top = -1;
            }
            public void Push(int data)
            {
                if (_top >= max)
                    Console.WriteLine("Ngan xep day! Khong them duoc!");
                else
                {
                    _top++;
                    stack[_top] = data;
                }
            }
            public int Pop()
            {
                if (_top >= 0)
                {
                    int data = stack[_top];
                    _top--;
                    return data;
                }
                else return -1;
            }

            public void Print()
            {
                if (_top < 0)
                    Console.WriteLine("Ngan xep rong!");
                else
                    for (int i = _top; i > 0; i--)
                        Console.Write("{0}*", stack[i]);
                Console.Write("{0}", stack[0]);
            }

            public void PrintHex()
            {
                string csHex = "0123456789ABCDEF";
                for (int i = _top; i >= 0; i--)
                    Console.Write(csHex[stack[i]]);
            }
        }
        static void Main(string[] args)
        {
            int n, n0;

            // Khởi tạo
            Stack s = new Stack();

            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());
            n0 = n; // n0 luu gtr n 

            // phan tich n ra thua so ngto
            for (int i = 2; i <= n; i++)
            {
                // n%i, dua n vao ngan xep, giam n = n/i
                while (n % i == 0)
                {
                    s.Push(i);
                    n /= i;
                }
            }
            //In ptu ngan xep
            Console.WriteLine("So {0} phan tich ra thua so nguyen to:", n0);
            s.Print();
            n = n0; //tra ve n ban dau
            Stack Stack2 = new Stack(); // tao ngan xep rong
            // doi he 16
            while (n > 0)
            {
                int soDu = n % 16;
                Stack2.Push(soDu);
                n = n / 16;
            }
            // In nguoc ngan xep lai
            Console.WriteLine("\nSo {0} doi sang he 16 la", n0);
            Stack2.PrintHex();

            // doi sang he 2 phan
            n = n0;
            Stack Stack3 = new Stack();

            int nhiphan;
            string result = string.Empty;
            while (n > 0)
            {
                nhiphan = n % 2;
                n /= 2;
                result = nhiphan.ToString() + result;
            }
            Console.WriteLine("\nhe nhi phan la:  {0}", result);
        }
    }
}