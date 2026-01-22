using System;
using System.Numerics;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
internal class Program
{
     static void sumAndSub(int num1 ,int num2 ,int num3 ,int num4  ,out int sum , out int mul) {
        sum = num1 + num2 + num3 + num4;
        mul = num1 -num2 - num3 - num4;
    }
    private static void Main(string[] args)
    {
        #region. Write a program in C# Sharp to find the sum of all elements of the  array.
        //int size;
        //bool flag;
        //do
        //{
        //    Console.WriteLine("enter size of array");
        //    flag = int.TryParse(Console.ReadLine(), out size);
        //}
        //while (!flag);
        //Console.Clear();
        //int[] arr = new int[size];
        //int sum = 0;
        //for (int i = 0; i < size; i++)
        //{
        //    Console.WriteLine($"enter elemeny {i + 1}");
        //    do
        //    {
        //        flag = int.TryParse(Console.ReadLine(), out arr[i]);
        //    } while (!flag);
        //    sum += arr[i];
        //}
        //while (!flag) ;
        //Console.Clear();
        //Console.WriteLine($"sum = {sum}");
        #endregion

        #region Write a program in C# Sharp to count a total number of duplicate elements in an array. 
        //int size;
        //bool flag;
        //do
        //{
        //    Console.WriteLine("enter size of array");
        //    flag = int.TryParse(Console.ReadLine(), out size);
        //}
        //while (!flag);
        //Console.Clear();
        //int[] arr = new int[size];

        //for (int i = 0; i < size; i++)
        //{
        //    Console.WriteLine($"enter elemeny {i + 1}");
        //    do
        //        flag = int.TryParse(Console.ReadLine(), out arr[i]);
        //    while (!flag);
        //}
        //bool[] visited = new bool[size];
        //int count = 0;
        //for (int i = 0; i < size - 1; i++)
        //{
        //    bool isduplicate = false;
        //    if (isduplicate == true)
        //        continue;
        //    visited[i] = true;
        //    for (int j = i + 1; j < size; j++)
        //    {
        //        if (arr[i] == arr[j])
        //        {
        //            isduplicate = true;
        //            visited[i] = true;
        //        }
        //    }
        //    if (isduplicate == true)
        //        count++;
        //}
        //Console.WriteLine(count);

        #endregion

        #region  Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
        //Console.WriteLine("enter first");
        //int num1 = int.Parse(Console.ReadLine());
        //Console.WriteLine("enter first");
        //int num2 = int.Parse(Console.ReadLine());
        //Console.WriteLine("enter first");
        //int num3 = int.Parse(Console.ReadLine());
        //Console.WriteLine("enter first");
        //int num4 = int.Parse(Console.ReadLine());
        //int sum, sub;
        //sumAndSub(num1,num2 ,num3,num4,out sum , out sub);
        //Console.WriteLine(sum);
        //Console.WriteLine(sub);
        #endregion
    }
}