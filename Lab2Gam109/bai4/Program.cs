using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap2_bai4
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<int> numberList = new List<int>();
            numberList.Add(10);
            numberList.Add(20);
            numberList.Add(7);
            numberList.Add(13);
            numberList.Add(23);
            numberList.Add(30);

            // Yêu cầu 1: Hiển thị danh sách các số nguyên
            Console.WriteLine("Danh sách các số nguyên:");
            foreach (int number in numberList)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            // Yêu cầu 2: Tính tổng các số nguyên trong danh sách
            int totalSum = numberList.Sum();
            Console.WriteLine("Tổng các số nguyên trong danh sách: " + totalSum);

            // Yêu cầu 3: Tính tổng các số nguyên tố có trong danh sách
            int result = 0;
            foreach (int number in numberList)
            {
                if (check(number))
                {
                    result += number;
                }
            }
            Console.WriteLine("Tổng các số nguyên tố trong danh sách: " + result);

            // Tính tổng các số chẵn ở vị trí lẻ trong danh sách
            int evenSumAtOddPositions = 0;
            for (int i = 0; i < numberList.Count; i++)
            {
                // Kiểm tra nếu vị trí là lẻ và giá trị là số chẵn
                if (i % 2 != 0 && numberList[i] % 2 == 0)
                {
                    evenSumAtOddPositions += numberList[i];
                }
            }
            Console.WriteLine("Tổng các số chẵn ở vị trí lẻ trong danh sách: " + evenSumAtOddPositions);

            Console.ReadLine();
        }

        // Hàm kiểm tra số nguyên tố
        public static Boolean check(int num)
        {
            // Nếu số nhỏ hơn hoặc bằng 1 thì không phải số nguyên tố
            if (num <= 1) return false;

            // Kiểm tra từ 2 đến num-1
            for (int i = 2; i < num; i++)
            {
                // Nếu tìm thấy ước số thì không phải số nguyên tố
                if (num % i == 0) return false;
            }

            // In ra số nguyên tố
            Console.WriteLine(num + " là số nguyên tố.");
            return true;
        }
    }
}
