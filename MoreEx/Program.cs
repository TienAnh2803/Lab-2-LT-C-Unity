using System;
using System.Collections.Generic;
class Program
{
    public static Boolean checkPrime(int num)
    {

        if (num < 1) return false;
        if (num == 2) return true;

        for (int i = 2; i < Math.Sqrt(num) + 1; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    static void Main()
    {
        List<int> numberList = new List<int>();
        numberList.Add(10);
        numberList.Add(20);
        numberList.Add(38);
        numberList.Add(40);
        numberList.Add(23);


        int result  = 0;
        foreach (int i in numberList)
        {
            if (checkPrime(i)) result += i;
        }
        Console.WriteLine(result);
        // Yêu cầu 1. Hiển thị danh sách các số nguyên
        // Yêu cầu 2. Tính tổng các số nguyên trong danh sách
        // Yêu cầu 3.
        //Tính tổng các số nguyên tố trong danh sách trong danh sách
        // Yêu cầu 4. Tình tổng các số chần ở vị trí lẻ trong danh sách
    }
}