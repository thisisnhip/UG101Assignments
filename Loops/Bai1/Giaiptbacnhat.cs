internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Giai phuong trinh bac nhat");
        Console.WriteLine("Phuong trinh co dang a * x + b = 0");
        Console.Write("a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        if (a != 0)
        {
            double nghiem = -b / a;
            Console.Write($"Phuong trinh co nghiem {nghiem}");
        }
        else
        {
            if (b == 0)
                {
                    Console.Write("Phuong trinh co vo so nghiem");
                }
            else
                {
                    Console.Write("Phuong trinh vo nghiem");
                }
        }
    }
}