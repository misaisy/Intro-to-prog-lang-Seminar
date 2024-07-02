// №1
// int n1 = 7;
// int n2 = -3;

// Console.Write("Введите первое число: ");
// int n1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int n2 = Convert.ToInt32(Console.ReadLine());

// if (n1 == n2 * n2)
// {
//     Console.WriteLine("a = " + n1 + ", b = " + n2 + " => да");
// }
// else
// {
//     Console.WriteLine($"a = {n1}, b = {n2} => нет");
// }


//№2
// Console.Write("Введите положительное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number < 0) {Console.WriteLine("Вы ввели некорректное число.");}

// int i = -number;
// while (i <= number)
// {
//     Console.Write(i + " ");
//     i++;
// }

// for (int i = -number; i <= number; i++)
// {
//     Console.Write(i + " ");
// }


//№3
Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int n1 = number / 100;
    int n2 = number % 10;
    int sum = (n1 + n2);
    Console.WriteLine(sum);
}
else {Console.WriteLine("Вы ввели некорректное число.");}
