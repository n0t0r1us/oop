using System;

namespace Stack
{
    public class NganXep
    {
        private int max;    // số phần tử đối đa
        private int top;    // chỉ số của phần tử trên cùng
        private int[] stack;    // mảng chứa các phần tử

        // Thiết lập: khởi tạo ngăn xếp rỗng
        public NganXep(int max)
        {
            this.max = max;
            top = -1;
            stack = new int[max];
        }

        // Thêm phần tử vào ngăn xếp
        public void Push(int data)
        {
            if (top == max - 1)
            {
                Console.WriteLine("Ngan xep day!");
            }
            else
            {
                top++;
                stack[top] = data;
            }
        }

        // Lấy ra phần tử trên cùng và xóa khỏi ngăn xếp
        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Ngan xep rong!");
                return -1;
            }
            else
            {
                int data = stack[top];
                top--;
                return data;
            }
        }

        // In ra phần tử trên cùng
        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Ngan xep rong!");
                return -1;
            }
            else
            {
                return stack[top];
            }
        }

        // Kiểm tra ngăn xếp có rỗng hay không
        public bool IsEmpty()
        {
            return top == -1;
        }

        // In ra danh sách phần tử trong ngăn xếp
        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Ngan xep rong!");
            }
            else
            {
                Console.WriteLine("Cac phan tu trong ngan xep:");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
    }

    internal class Program
    {
        // Kiểm tra số nguyên có phải là số nguyên tố hay không
        static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        // Phân tích số nguyên thành các thừa số nguyên tố và đẩy vào ngăn xếp
        static void Decompose(NganXep stack, int n)
        {
            for (int i = 2; i <= n; i++)
            {
                while (n % i == 0 && IsPrime(i))
                {
                    stack.Push(i);
                    n /= i;
                }
            }
        }
    
        class   Program
        {
            static void Main(string[] args)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8; // cấu hình console xuất UTF-8 để có thể in được tiếng Việt không dấu
                Console.WriteLine("Chương trình phân tích số nguyên thành thừa số nguyên tố và đổi số nguyên sang hệ nhị phân, hệ thập lục phân.");
                Console.Write("Nhập số nguyên dương cần phân tích và đổi hệ: ");
                int n = Convert.ToInt32(Console.ReadLine());

                // Khởi tạo ngăn xếp với số phần tử đối đa là 20
                Stack<int> myStack = new Stack<int>(20);

                // Phân tích số thành thừa số nguyên tố và đẩy các thừa số vào ngăn xếp
                Console.Write("Các thừa số nguyên tố của {0} theo thứ tự ngược lại là: ", n);
                for (int i = 2; i <= n; i++)
                {
                    while (n % i == 0)
                    {
                        myStack.Push(i);
                        n /= i;
                    }
                }
                while (myStack.Count > 0)
                {
                    Console.Write("{0} ", myStack.Pop());
                }
                Console.WriteLine();

                // Đổi số nguyên sang hệ nhị phân và đẩy các số dư vào ngăn xếp
                Console.Write("Số {0} trong hệ nhị phân là: ", n);
                while (n > 0)
                {
                    myStack.Push(n % 2);
                    n /= 2;
                }
                while (myStack.Count > 0)
                {
                    Console.Write("{0}", myStack.Pop());
                }
                Console.WriteLine();

                // Đổi số nguyên sang hệ thập lục phân và đẩy các số dư vào ngăn xếp
                Console.Write("Số {0} trong hệ thập lục phân là: ", n);
                while (n > 0)
                {
                    int remainder = n % 16;
                    if (remainder < 10)
                    {
                        myStack.Push(remainder);
                    }
                    else
                    {
                        myStack.Push((char)('A' + remainder - 10));
                    }
                    n /= 16;
                }
                while (myStack.Count > 0)
                {
                    Console.Write("{0}", myStack.Pop());
                }
                Console.WriteLine();
            }
        }
    }
}