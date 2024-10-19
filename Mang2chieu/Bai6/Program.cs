//tìm phần tử lớn nhất trong mảng 2 chiều
using System;

namespace TimPhanTuLonNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo mảng hai chiều
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            // Tìm phần tử lớn nhất
            int max = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                }
            }

            // In ra kết quả
            Console.WriteLine("Phần tử lớn nhất trong mảng là: " + max);
        }
    }
}