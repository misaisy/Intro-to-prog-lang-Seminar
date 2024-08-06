// Задача 2: Задайте массив заполненный случайными трёхзначными числами.
//           Напишите программу, которая покажет количество чётных чисел в массиве.

// void Main()
// {
// int arraySize = ReadInt("Введите размер массива: ");
// int[] array = GenerateArray(arraySize, 100, 1000);
// PrintArray(array);
// CountOfEvenNumbers(array);
// }

// void PrintArray(int[] arrayForPrint)
// {
// System.Console.Write("[ ");
// for(int i = 0; i < arrayForPrint.Length; i++)
// System.Console.Write(arrayForPrint[i] + " ");
// System.Console.Write("]");
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
// System.Console.Write(msg);
// return Convert.ToInt32(Console.ReadLine());
// }

// void CountOfEvenNumbers(int[] array)
// {
//     System.Console.Write(" => ");
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//         {
//             count++;
//         }
//     }
//     System.Console.Write(count);
// }

// Main();


//Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

// void Main()
// {
// int arraySize = ReadInt("Введите размер массива: ");
// int[] array = GenerateArray(arraySize, 0, 10);
// PrintArray(array);
// ReverseArray(array);
// PrintArray(array);
// }

// void PrintArray(int[] arrayForPrint)
// {
// System.Console.Write("[ ");
// for(int i = 0; i < arrayForPrint.Length; i++)
// System.Console.Write(arrayForPrint[i] + " ");
// System.Console.Write("] ");
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
// System.Console.Write(msg);
// return Convert.ToInt32(Console.ReadLine()); // 13
// }

// void ReverseArray(int[] array)
// {
//     System.Console.Write("=> ");
//     for (int i = 0; i < array.Length-1-i; i++)
//     {
//         int t = array[i]; 
//         array[i] = array[array.Length-1-i];
//         array[array.Length-1-i] = t;
//     }
// }

// Main();


//Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли.
//          Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

// void Main()
// {
//     int number = 0;

//     for (int i = 0; i > i-1; i++)
//     {
//         System.Console.WriteLine("Введите число: ");
//         string StringCheck = Console.ReadLine();
//         if (Check == "q")
//         {
//             break;
//         }
//         string[] numbers = StringCheck.Split();
//         int[] numb = new int[numbers.Length];
//         for (int j = 0; j < numbers.Length; j++)
//         {
//             numb[j] = Convert.ToInt32(numbers[j]);
//             System.Console.WriteLine(numb[j]);
//         }
//         // int number = Convert.ToInt32(Console.ReadLine());
//         // System.Console.Write(number + "");
//     }
// }

// void CheckForQ(string Check)
// {
//     if (Check == "q")
//     {
//         break;
//     }
// }

// void CheckForEven(string Check)
// {
//     string[] numbers = Check.Split();
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         System.Console.WriteLine(numbers[i]);
//     }
// }
// Main();