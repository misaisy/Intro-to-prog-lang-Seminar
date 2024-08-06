// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.
// void Main()
// {
//     int M = ReadInt("Введите число M: ");
//     int N = ReadInt("Введите число N: ");
//     PrintNumbers(M, N);
// }

// void PrintNumbers(int num1, int num2)
// {
//     if (num1 > num2) return;
//     System.Console.Write(num1 + " ");
//     PrintNumbers(num1 + 1, num2);
    
// }

// int ReadInt(string msg)
// {
//     System.Console.Write(msg);
//     return Convert.ToInt32(Console.ReadLine());
// }

// Main();


// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// void Main()
// {
//     int m = ReadInt("Введите число m: ");
//     int n = ReadInt("Введите число n: ");
//     int number = A(m, n);
//     System.Console.WriteLine(number);
// }

// int ReadInt(string msg)
// {
//     System.Console.Write(msg);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int A(int m, int n)
// {
//     if (m == 0)
//         return (n + 1);
//     else if (m > 0 && n == 0)
//         return (A(m - 1, 1));
//     else if (m > 0 && n > 0)
//         return A(m-1,A(m,n-1));
//     else
//         return 0;
// }

// Main();


// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
// void Main()
// {
// int arraySize = ReadInt("Введите размер массива: ");
// int[] array = GenerateArray(arraySize, 0, 10);
// PrintArray(array);
// System.Console.Write("=> ");
// PrintArrayFromEnd(array, array.Length - 1);
// }

// static void PrintArrayFromEnd(int[] array, int index)
// {
//     if (index >= 0)
//     {
//         Console.Write(array[index] + " ");
//         PrintArrayFromEnd(array, index - 1);
//     }
// }

// void PrintArray(int[] arrayForPrint)
// {
// for(int i = 0; i < arrayForPrint.Length; i++)
// System.Console.Write(arrayForPrint[i] + " ");
// }

// int[] GenerateArray(int size, int minValue, int maxValue)
// {
// int[] tempArray = new int[size];
// Random rand = new Random();

// for (int i = 0; i < tempArray.Length; i++)
// tempArray[i] = rand.Next(minValue, maxValue);

// return tempArray;
// }

// int ReadInt(string msg)
// {
//     System.Console.Write(msg);
//     return Convert.ToInt32(Console.ReadLine());
// }

// Main();