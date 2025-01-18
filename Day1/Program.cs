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



        again:
            Console.OutputEncoding = Encoding.UTF8;


            Console.WriteLine("Bài 1:");
            Console.WriteLine("Nhập vào số bé");
            string inputNumberSmall = Console.ReadLine();
            int numberSmall = int.Parse(inputNumberSmall);
            Console.WriteLine("Nhập vào số lớn");
            string inputNumberTall = Console.ReadLine();
            int numberTall = int.Parse(inputNumberTall);
            if (numberSmall >= numberTall)
            {
                Console.WriteLine("Số bé không thể lớn hơn hoặc bằng số lớn !");
                goto again;
            }
            int tong = 0;
            Console.WriteLine("Các số từ số bé đến số lớn là:");
            for (int i = numberSmall; i <= numberTall; i++)
            {
                Console.WriteLine(i);
                tong += i;
            }
            Console.WriteLine("Tổng của các số là: " + tong);


            Console.WriteLine("Bài 2:");

            Console.WriteLine("Nhập vào số lượng phần tử bạn muốn có trong mảng:");
            string inputQuantity = Console.ReadLine();
            int quantity = int.Parse(inputQuantity);

            int[] obj = new int[quantity];
            int tongObj = 0;
            for (int i = 1; i <= quantity; i++)
            {
                Console.WriteLine("Nhập vào giá trị phần tử thứ: " + i);
                string inputIndex = Console.ReadLine();
                int indexObj = int.Parse(inputIndex);
                tongObj += indexObj;


            }
            Console.WriteLine("Tổng của các phần tử là:" + tongObj);



            Console.ReadKey();

        }

    }


}


