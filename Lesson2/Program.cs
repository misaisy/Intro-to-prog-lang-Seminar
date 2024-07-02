//№1
// Console.Write("Введите трёхзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 99 && number < 1000)
// {
//     int result = number / 100 * 10 + number % 10;
//     Console.WriteLine(result);
// }
// else {Console.WriteLine("Вы ввели некорректное число.");}


//№2
// Console.Write("Введите трёхзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 99 && number < 1000)
// {
//     int digit = number / 10 % 10;
//     int result = 1;
//     for (int power = number % 10; power > 0; power--)
//     {
//         result *= digit;
//     }    
//     Console.WriteLine(result);
// }
// else {Console.WriteLine("Вы ввели некорректное число.");}


//№3
// Console.Write("Введите первое число: ");
// int n1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int n2 = Convert.ToInt32(Console.ReadLine());

// if (n1 % n2 == 0) {Console.WriteLine("Да");}
// else {Console.WriteLine("Нет, " + n1 % n2);}


//№4
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 99)
// {
//     Console.WriteLine(number % 1000 / 100);
// }
// else {Console.WriteLine("Третьей цифры нет.");}

// if (number > 99)
// {
//     while (number > 999)
//         number /= 10;
//     Console.WriteLine(number % 10);
// }
// else {Console.WriteLine("Третьей цифры нет.");}