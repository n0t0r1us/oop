using System;

class Stack
{
    protected static readonly int Max = 1000;
    protected int top;
    protected int[] data = new int[Max];
    
    public Stack()
    {
        top = -1;
    }
    
    public bool Push(int value)
    {
        
        if(top >= Max)
        {
            Console.WriteLine("Stack overflow.");
            return false;
        }
        else
        

        {
            data[++top] = value;
            return true;
        }
    }
    public int Pop()
    {
        if(top < 0)
        {
            Console.WriteLine("Stack empty.");
            return -1;
        }
        else
        {
            int value = data[top--];
            return value;
        }
    }
    public virtual void Print(){}
}
class PrimeStack: Stack
{
    public PrimeStack():base(){}
    public override void Print()
    {
        int i;
        for(i=top; i > 0; i--)
            Console.Write("{0}*", data[i]);
        Console.WriteLine("{0}", data[i]);
    }
}
class HexaStack:Stack
{
    public HexaStack():base(){}
    public override void Print()
    {
        string HexaDigits = "0123456789ABCDEF";
        for(int i=top; i >= 0; i--)
            Console.Write(HexaDigits[data[i]]);
    }
}
class Program
{
    public static PrimeStack PhanTichThuaSo(int n)
    {
        PrimeStack stack = new PrimeStack();
        for(int i=2; i <= n; i++)
        {
            while(n % i == 0)
            {
                stack.Push(i);
                n /= i;
            }
        }
        return stack;
    }
public static HexaStack Dec2Hex(int n)
{
    HexaStack stack = new HexaStack();
    while(n > 0)
    {
        int soDu = n % 16;
        stack.Push(soDu);
        n /= 16;
    }
    return stack;
}
static void Main(string[] args)
{
    int n;
    do{
        Console.Write("n = ");
        n = int.Parse(Console.ReadLine());
    }while(n < 2);
    
    PrimeStack stack1 = PhanTichThuaSo(n);
    Console.Write("{0} = ", n);
    stack1.Print();
    
    HexaStack stack2 = Dec2Hex(n);
    Console.Write("So {0} bieu dien trong he 16 la ", n);
    stack2.Print();
    }
}