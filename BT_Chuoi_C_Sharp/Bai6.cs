using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Chuoi_C_Sharp
{
    internal class Bai6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("Bai 6: Nguyen Long Nhat 23115053122126 ||");
            Console.WriteLine("=========================================\n");

            List<int> arr = new List<int>();
            int n;
            int dem = 0;

            Console.Write("Nhap so phan tu: ");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Khong phai so, vui long nhap lai: ");
            }

            for (int i = 0; i < n; i++)
            {
                int so;
                Console.Write($"Nhap so thu {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out so))
                {
                    Console.Write("Khong phai so, vui long nhap lai: ");
                }
                arr.Add(so);
            }

            if (arr.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] % 2 == 0)
                    dem += 1;
            }

            Console.WriteLine("Cac so da nhap: " + string.Join(" ", arr));
            Console.WriteLine("So phan tu chan la: " + dem);
        }
    }
}
