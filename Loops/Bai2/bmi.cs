internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Nhap chieu cao (don vi met): ");
        float height = float.Parse(Console.ReadLine());
        Console.Write("Nhap can nang (don vi kg): ");
        float weight = float.Parse(Console.ReadLine());
        double bmi = weight / Math.Pow(height,2); //Math.Pow: bình phương 
        bmi = Math.Round(bmi,1);
        Console.WriteLine($"Chi so BMI = {bmi}");
        if (bmi < 18)
            Console.WriteLine("Quá gầy");
        else if (bmi < 25.0)
            Console.WriteLine("Bình thường");
        else if (bmi < 30.0)
            Console.WriteLine("Thừa cân");
        else
            Console.WriteLine("Béo phì");
    }
}