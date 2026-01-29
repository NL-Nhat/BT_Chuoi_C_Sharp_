//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BT_Chuoi_C_Sharp
//{
//    internal class Bai7
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("=========================================");
//            Console.WriteLine("Bai 7: Nguyen Long Nhat 23115053122126 ||");
//            Console.WriteLine("=========================================\n");

//            List<String> arr = new List<String>();
//            String name;

//            Console.Write("Nhap ten: ");
//            name = Console.ReadLine().Trim();

//            if (string.IsNullOrEmpty(name))
//            {
//                Console.WriteLine("Ten rong.");
//                return;
//            }
            
//            String tam = "";

//            for(int i = 0; i < name.Length; i++)
//            {
                
//                if (name[i] != ' ')
//                {
//                    tam += name[i];
//                }
//                else
//                {
//                    if(tam != "")
//                    {
//                        arr.Add(tam);
//                        tam = "";
//                    }
//                }

//                if(i == name.Length - 1)
//                {
//                    arr.Add(tam);
//                }
//            }

//            if (arr.Count == 0)
//            {
//                Console.WriteLine("Danh sach rong.");
//                return;
//            }

//            foreach (String x in arr)
//            {
//                Console.WriteLine(x);
//            }
//        }
//    }
//}
