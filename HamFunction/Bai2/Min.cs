//nhap mang int tu ban phim -> tim min cua mang -> in ra 
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap do dai cua mang");
        int size = int.Parse(Console.ReadLine());
        int[] myList = new int[size];

        System.Console.WriteLine("Nhap cac phan tu cua mang");
        for (var i = 0; i < size; i++)
        {
            System.Console.WriteLine($"Phan tu thu {i}");
            myList[i] = Convert.ToInt32(Console.ReadLine());
        }
        //in mảng ra
        for (var i = 0; i < size; i++)
        {
            Console.Write(myList[i] + "\t");
        }
        Console.Write("\n");
        Console.WriteLine($"Gia tri nho nhat cua mang: {Min(myList)}");
    }

    private static int Min(int[] arr) //input la mang int[] arr
    {
        int min = arr[0];
        for (var i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        return min;
    }
}