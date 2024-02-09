// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// Console.WriteLine("Введите число");
// int number = int.Parse(Console.ReadLine());
// if (number % 7 == 0 && number % 23 == 0) {Console.WriteLine($"a = {number} => да");}
// else {Console.WriteLine($"a = {number} => нет");}

//Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
// Console.WriteLine("Введите координату X не равную нулю");
// double X = double.Parse(Console.ReadLine());
// Console.WriteLine("Введите координату Y не равную нулю");
// double Y = double.Parse(Console.ReadLine());

// if (X == 0 || Y == 0) {Console.WriteLine("Точки не должны быть равны нулю");}
// else if (X > 0 && Y > 0) {Console.WriteLine($"{X}, {Y} => 1");}
// else if (X < 0 && Y > 0) {Console.WriteLine($"{X}, {Y} => 2");}
// else if (X < 0 && Y < 0) {Console.WriteLine($"{X}, {Y} => 3");}
// else {Console.WriteLine($"{X}, {Y} => 4");}

// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
// Console.WriteLine("Введите целое число из отрезка [10, 99]");
// int number = int.Parse(Console.ReadLine());

// if (number < 10 || number > 99) {Console.WriteLine("Число не попадаёт в данный диапозон");}
// else 
// {
//     if (number % 10 > number / 10) {Console.WriteLine($"{number} => {number % 10}");}
//     else {Console.WriteLine($"{number} => {number / 10}");}
// }

// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
// Console.WriteLine("Введите натуральное число N");
// int N = int.Parse(Console.ReadLine());

// if (N < 1) {Console.WriteLine("Число не натуральное");}
// else
// {
//     Console.Write($"{N} => ");
//     string str = N.ToString();
//     for(int i = 0; i <= str.Length - 1; i++)
//     {
//         Console.Write(str[i]);
//         if (i < str.Length - 1)
//         {
//             Console.Write(",");
//         }
//     }
// }