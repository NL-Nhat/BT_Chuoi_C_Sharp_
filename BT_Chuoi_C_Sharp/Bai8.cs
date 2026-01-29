using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Chuoi_C_Sharp
{
    internal class Bai8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("Bai 8: Nguyen Long Nhat 23115053122126 ||");
            Console.WriteLine("=========================================\n");

            String cau, tuMax = "";

            Console.Write("Nhap cau: ");
            cau = Console.ReadLine().Trim();

            if (string.IsNullOrEmpty(cau))
            {
                Console.WriteLine("Cau rong.");
                return;
            }

            String tam = "";

            for (int i = 0; i < cau.Length; i++)
            {

                if (cau[i] != ' ')
                {
                    tam += cau[i];
                }
                else
                {
                    if (tam != "")
                    {
                        if(tam.Length > tuMax.Length)
                        {
                            tuMax = tam;
                        }
                        tam = "";
                    }
                }

                if (i == cau.Length - 1)
                {
                    if (tam.Length > tuMax.Length)
                    {
                        tuMax = tam;
                    }
                    tam = "";
                }
            }

            Console.WriteLine("Cau da nhap: " + cau);
            Console.WriteLine("Tu dai nhat la: " + tuMax);
        }
    }
}
