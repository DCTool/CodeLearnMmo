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
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập Nội Dung:");
            string content = Console.ReadLine();
            Console.WriteLine("Nội dung vừa nhập là: \n" + content);

            Console.WriteLine("Các biến:");

            int number = 12345;
            Console.WriteLine("number:" ,number);
            float numberOther = 12.1F;
            Console.WriteLine(numberOther);
            bool trueFalse = true;
            Console.WriteLine(trueFalse);
            string textString = "61566562755419|eaQ2pSkv83fOf|NVWKX6RE25EFPHTIBM4VGJPSUUP5O3PR";
            Console.WriteLine(textString);
            string textStringSecond = "61566562755419";
            char c = '\u002B';
            Console.WriteLine(c);

            // convert To String
            string convertToString = number.ToString();
            Console.WriteLine("Convert về string:" + convertToString);

            // convert To Number
            float convertToFloat = float.Parse(textStringSecond);
            Console.WriteLine("Convert về FloatNumber:" + convertToFloat);

            // Cộng chuỗi
            string plusString = textString + textStringSecond;
            Console.WriteLine("Cộng chuỗi :" + plusString);

            // stop console
            Console.ReadKey();


        }
    }
}
