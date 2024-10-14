
internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.Write("Nhap 0 hoac 1 (0 de tinh do C, 1 de tinh do F): ");
        int nhap = int.Parse(Console.ReadLine());
        switch (nhap)
        {
            case 0:
                InputC();
                break;
            case 1:
                InputF();
                break;
            default:
                break;
        }
    }
    private static double CtoF(double C)
    {
        double F  = (9.0 / 5) * C + 32;
        return F;
    }
    public static double FtoC(double F)
    {
        double C  = (5.0 / 9) * (F - 32);
        return C;
    }
    private static void InputC()
    {
        System.Console.Write("Nhap vao gia tri do C: ");
        float resultC = float.Parse(Console.ReadLine());
        Console.WriteLine($"Gia tri do F la: {CtoF(resultC)}");
    }
    private static void InputF()
    {
        System.Console.Write("Nhap vao gia tri do F: ");
        float resultF = float.Parse(Console.ReadLine());
        Console.WriteLine($"Gia tri do C la: {FtoC(resultF)}");

    }
}
