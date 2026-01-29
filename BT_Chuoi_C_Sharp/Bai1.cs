using System;

namespace BT_Chuoi_C_Sharp
{
    internal class Bai1
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chuoi: ");
            string text = Console.ReadLine();

            if(text == null || text.Equals(""))
            {
                Console.WriteLine("Loi: Chuoi rong.");
                return;
            }

            text = text.Trim();

            string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            // Viết hoa chữ cái đầu mỗi từ
            for (int i = 0; i < words.Length; i++)
            {
                string w = words[i];
                words[i] = char.ToUpper(w[0]) + w.Substring(1).ToLower();
            }

            // Ghép lại thành chuỗi chuẩn hóa
            text = string.Join(" ", words);

            Console.WriteLine("Chuoi sau khi chuan hoa: " + text);
        }

    }
}
