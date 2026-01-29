//using System;

//namespace BT_Chuoi_C_Sharp
//{
//    internal class Bai2
//    {
//        static void Main(string[] args)
//        {
//            List<string> arr = new List<string>();
            
//            int i = 1;

//            while(i == 1)
//            {

//                Console.WriteLine("Nhap 1 de nhap them so.");
//                Console.WriteLine("Nhap 0 de ket thuc.");

//                int n;
//                Console.Write("Nhap so: ");

//                switch(n = Convert.ToInt32(Console.ReadLine()))
//                {
//                    case 1:
//                        Console.Write("Nhap so can them: ");
//                        int so = Convert.ToInt32(Console.ReadLine());
//                        arr.Add(so.ToString());
//                        break;
//                    case 0:
//                        i = 0;
//                        break;
//                    default:
//                        Console.WriteLine("Loi: Vui long nhap 0 hoac 1.");
//                        break;
//                }
//            }

//            Console.Write("Cac so da nhap: ");
//            for (int a = 0; i < arr.Count; i++)
//            {
//                Console.Write(arr[i] + " ");
//            }

//            Console.WriteLine("\nSo luong phan tu: " + arr.Count);
//        }
//    }
//}
