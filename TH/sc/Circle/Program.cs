namespace Circle
{
    // Khai báo lớp Circle (hình tròn)
    public class Circle
    {
        // Khai báo các trường dữ liệu (fields)
        private float x, y;// Tọa độ tâm
        private float radius;// Bán kính
        // Khai báo các thuộc tính (properties)
        public float Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public float X
        {
            get { return x; }
            set { x = value; }
        }
        public float Y
        {
            get { return y; }
            set
            {
                y = value;
            }
        }
        // Phương thức nhập
        public void Input()
        {
            // Nhập tọa độ tâm
            Console.Write("Toa do X = ");
            x = float.Parse(Console.ReadLine());
            Console.Write("Toa do Y = ");
            y = float.Parse(Console.ReadLine());
            // Nhập bán kính
            do
            {
                Console.Write("Ban kinh = ");
                radius = float.Parse(Console.ReadLine());
            } while (radius < 0);
        }
        // Hàm tính diện tích hình tròn
        public double Area()
        {
            return radius * radius * Math.PI;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo đối tượng hình tròn, nhập và in ra diện tích của nó
            Circle c1 = new Circle();
            c1.Input();
            double s = c1.Area();
            Console.WriteLine("Dien tich = {0:0.##}", s);
        }
    }
}