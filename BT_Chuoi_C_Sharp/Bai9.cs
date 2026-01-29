using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Chuoi_C_Sharp
{
    internal class Bai9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("Bai 9: Nguyen Long Nhat 23115053122126 ||");
            Console.WriteLine("=========================================\n");

            int dem = 0;
            String[] arr = {"Nhat", "", null, "Nguyen", null, "", "nhat"};

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != null && arr[i] != "")
                {
                    dem += 1;
                }
            }

            Console.Write("Mang da cho là: ");
            Console.Write("[");

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == null)
                {
                    Console.Write("null");
                }
                else
                {
                    Console.Write($"\"{arr[i]}\"");
                }

                if (i < arr.Length - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine("]");
            Console.WriteLine("So phan tu khac null va khac rong la: " + dem);
        }
    }
}
