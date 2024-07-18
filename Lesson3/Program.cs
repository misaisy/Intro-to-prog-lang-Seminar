// string[] names = {"Иван", "Кристина", "Денис"};
// names[0] = "Георгий";
// Console.WriteLine(names[0]);

// int[] nums1 = { 1, 5, 6, 7, 23, 3 };

// int size = 7;
// int[] nums2 = new int[size];

// for (int i = 0; i < nums2.Length; i++)
// {
//     Console.Write($"Введите {i+1}-й элемент массива: ");
//     nums2[i] = Convert.ToInt32(Console.ReadLine());
// }

// for (int i = 0; i < nums2.Length; i++)
//     Console.Write(nums2[i] + " ");

// int[] nums3 = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

// int[] nums4 = new int[5];
// Random rand = new Random();

// for (int i = 0; i i < nums4.Length; i++)
// {
//     nums4[i] = rand.Next(0, 10);
// }

// №1
// Console.Write("Введите размер массива: ");
// int arraySize = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[arraySize];
// Random rand = new Random();

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(10, 100);
//     Console.Write(array[i] + " ");
// } 

// Console.WriteLine();
// Console.Write("Введите значение: ");
// int findNumber = Convert.ToInt32(Console.ReadLine());

// bool numberIsFinded = false;

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] == findNumber)
//     {
//         numberIsFinded = true;
//         break;
//     }
// }
// if (numberIsFinded)
// {
//     Console.WriteLine("Да!");
// }
// else
// {
//     Console.WriteLine("Нет!");
// }


// №2
// using System.Runtime.ConstrainedExecution;

// int[] array = new int[10];
// Random rand = new Random();

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(-10, 11);
//     Console.Write(array[i] + "\t");
// } 

// System.Console.WriteLine();

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] < 0)
//     {
//         array[i] *= -1;
//     }
// }

// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + "\t");
// }


// №3
// Random rand = new Random();

// int[] array = new int[rand.Next(5,16)];

// for (int i = 0; i < array.Length; i++)
// {
//     array [i] = rand.Next(-10,11);
//     Console.Write(array[i] + " ");
// } 
// System.Console.WriteLine();
// int[] multPairs = new int[array.Length / 2];

// for (int i = 0; i < array.Length / 2; i++)
// {
//     multPairs[i] = array[i] * array[array.Length -1 - i];
// }

// for (int i = 0; i < multPairs.Length; i++)
// {
//     Console.Write(multPairs[i] + " ");
// } 


// Просто вариант решения одной из задачи с вещественными числами
// double[] numbers = new double[5];
// Random rand = new Random();

// for (int i = 0; i < numbers.Length; i++)
// numbers[i] = Math.Round(rand.Next(0, 10) + rand.NextDouble(), 2);

// for (int i = 0; i < numbers.Length; i++)
// System.Console.Write(numbers[i] + " ");o