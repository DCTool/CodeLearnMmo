using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Program
    {

        static int hamtinhtong()
        {
            int A = 1;
            int B = 2;
            int TONG = A + B;
            return TONG;  // lặp tức kết thúc hàm luôn

        }
        static int hamtinhtong45()
        {
            int A = 4;
            int B = 5;
            int TONG = A + B;
            return TONG;  // lặp tức kết thúc hàm luôn

        }
        static void hamtinhtong22()
        {
            int A = 1;
            int B = 2;
            int TONG = A + B;
            Console.WriteLine(TONG);

        }
        static int hamtinhtong2(int A, int B)
        {

            int TONG = A + B;
            return TONG;  // lặp tức kết thúc hàm luôn

        }
        static int hamtinhieu(int A, int B)
        {

            int hieu = A - B;
            return hieu;  // lặp tức kết thúc hàm luôn

        }
        static int hamtinhall(int a, int b, out int hieu, out int tich)
        {
            hieu = 0;
            tich = 0;


            int tong = a + b;
            hieu = a - b;
            tich = a * b;

            return tong;

        }
        static int hamtich(int A, int B)
        {





            int tich = A * B;
            return tich;  // lặp tức kết thúc hàm luôn

        }
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;


            string token = "(function(){window.__accessToken=\"EAABsbCS1iHgBOz5wvFk1UZAQFoG5lt6HoeuVaYHPXVGSHtUhpHF0KaipFfz6Ac6qT76C2KixyzkCukjx8Fk6fY4q9WJ3yOae8xKjrZAqjYaXRefDCVpmJgATELjSiv6iKqQbFWbVERLVKaguHdLfjBbwxn8ZAdRaYbNB4MVShfpnH27wb4c6WF57tuIXpRhT7lYYGGyuAZDZD\";";
            string[] tokenSplit = token.Split(new string[] { "window.__accessToken=\"" }, StringSplitOptions.None);
            Console.WriteLine(tokenSplit);
            //for (int i = 0; i < tokenConvert.Length; i++)
            //{
            //    Console.WriteLine(i);
            //}
            Console.WriteLine("String:" + tokenSplit[0]);
            Console.WriteLine("String:" + tokenSplit[1]);

            string[] tokenConvert = tokenSplit[1].Split('"');
            Console.WriteLine("Token via:" + tokenConvert[0]);    

            Console.ReadKey();

        }

    }


}


