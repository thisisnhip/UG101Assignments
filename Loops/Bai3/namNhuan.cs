internal class Program
{
    private static void Main(string[] args)
    {
            int year;
            bool namNhuan = false;
            Console.Write("Nhap nam: ");
            year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        namNhuan = true;
                    }
                }
                else
                {
                    namNhuan = true;
                }
            }

            if (namNhuan)
            {
                Console.WriteLine($"{year} la nam nhuan");
            }
            else
            {
                Console.WriteLine($"{year} khong phai nam nhuan");
            }
    }
}