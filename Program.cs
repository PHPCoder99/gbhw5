using System;

namespace gbhw5
{
    class Program
    {
        // 1, 2, 3...
        // static int ReadInt(string prompt){
        //     Console.WriteLine(prompt);
        //     return Convert.ToInt32(Console.ReadLine());
        // }

        // static int[] GenerateArray(int size){
        //     int[] result = new int[size];
        //     Random rand = new Random();
        //     for(int i = 0; i < size; i++){
        //         result[i] = rand.Next(100, 1000);
        //     }
        //     return result;
        // }

        // static void WriteArray(int[] array){
        //     Console.WriteLine(string.Join(", ", array));
        // }
        
        // 1...
        // static int CountEven(int[] array){
        //     int result = 0;
        //     for (int i = 0; i < array.Length; i++)
        //     {
        //         if (array[i] % 2 == 0)
        //         {
        //             result++;
        //         }
        //     }
        //     return result;
        // }

        // 2...
        // static int SumOddIdx(int[] array){
        //     int result = 0;
        //     for (int i = 1; i < array.Length; i+=2){
        //         result += array[i];
        //     }
        //     return result;
        // }

        // 3...
        // static int FindMax(int[] array){
        //     int max = array[0];
        //     for (int i = 1; i < array.Length; i++){
        //         if (array[i] > max){
        //             max = array[i];
        //         }
        //     }
        //     return max;
        // }

        // static int FindMin(int[] array){
        //     int min = array[0];
        //     for (int i = 1; i < array.Length; i++){
        //         if (array[i] < min){
        //             min = array[i];
        //         }
        //     }
        //     return min;
        // }

        static void Main(string[] args)
        {
            // 1...
            // int[] array1 = GenerateArray(ReadInt("Введите число: "));
            // WriteArray(array1);
            // Console.WriteLine(CountEven(array1));
            
            // 2...
            // int[] array2 = GenerateArray(ReadInt("Введите число: "));
            // WriteArray(array2);
            // Console.WriteLine(SumOddIdx(array2));

            // 3...
            // int[] array3 = GenerateArray(ReadInt("Введите число: "));
            // WriteArray(array3);
            // System.Console.WriteLine(FindMax(array3)-FindMin(array3));
        }
    }
}
