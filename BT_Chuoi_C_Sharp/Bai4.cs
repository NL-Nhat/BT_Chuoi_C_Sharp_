//using System;
//using System.Collections.Generic;

//namespace BT_Chuoi_C_Sharp
//{
//    internal class Bai4
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("=========================================");
//            Console.WriteLine("Bai 4: Nguyen Long Nhat 23115053122126 ||");
//            Console.WriteLine("=========================================\n");

//            List<int> arr = new List<int>();
//            int n;
//            int sum = 0;

//            Console.Write("Nhap so phan tu: ");
//            while (!int.TryParse(Console.ReadLine(), out n))
//            {
//                Console.Write("Khong phai so, vui long nhap lai: ");
//            }

//            for (int i = 0; i < n; i++)
//            {
//                int so;
//                Console.Write($"Nhap so thu {i + 1}: ");
//                while (!int.TryParse(Console.ReadLine(), out so))
//                {
//                    Console.Write("Khong phai so, vui long nhap lai: ");
//                }
//                arr.Add(so);
//            }

//            if(arr.Count == 0)
//            {
//                Console.WriteLine("Danh sach rong.");
//                return;
//            }

//            foreach (int x in arr)
//            {
//                sum += x;
//            }

//            Console.WriteLine("Cac so da nhap: " + string.Join(" ", arr));
//            Console.WriteLine("Tong cac phan tu: " + sum);
//        }
//    }
//}
