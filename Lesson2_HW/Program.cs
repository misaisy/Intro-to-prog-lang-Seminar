// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number % 7 == 0 && number % 23 == 0) {Console.WriteLine($"Число {number} одновременно кратно 7 и 23");}
// else {Console.WriteLine($"Число {number} не кратно 7 и 23 одновременно");}


// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
// Console.Write("Введите значение координаты X не равное нулю: ");
// int X = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите значение координаты Y не равное нулю: ");
// int Y = Convert.ToInt32(Console.ReadLine());

// if (X > 0 && Y > 0) {Console.WriteLine($"Номер координатной плоскости точки {X},{Y} - 1");}
// else if (X < 0 && Y > 0) {Console.WriteLine($"Номер координатной плоскости точки {X},{Y} - 2");}
// else if (X < 0 && Y < 0) {Console.WriteLine($"Номер координатной плоскости точки {X},{Y} - 3");}
// else if (X > 0 && Y < 0) {Console.WriteLine($"Номер координатной плоскости точки {X},{Y} - 4");}
// else {Console.WriteLine("Задание значение отличное от нуля.");}


// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
// Console.Write("Введите целое число из отрезка [10, 99]: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number >= 10 && number <= 99)
// {
//     if (number % 10 > number / 10) {Console.WriteLine("Наибольшая цифра числа " + number + " - " + number % 10);}
//     else if (number / 10 > number % 10) {Console.WriteLine("Наибольшая цифра числа " + number + " - " + number / 10);}
//     else {Console.WriteLine("Цифры в числе " + number + " равны");}
// }
// else {Console.WriteLine("Вы ввели некорректное число.");}


// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
// В обратном порядке:
// Console.Write("Введите натуральное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 0)
// {
//     while (number > 0)
//     {
//         if (number < 10) {Console.Write(number);}
//         else
//         {
//             Console.Write(number % 10 + ", ");
//         }
//         number /= 10;
//     }
// }
// else {Console.WriteLine("Вы ввели некорректное число.");}