// Задача 1.
// void Main()
// {
//     int number = ReadInt("Введите число: ");
//     PrintNumber(number);
// }

// void PrintNumber(int N)
// {
//     if (N < 1) return;
//     PrintNumber(N - 1);
//     System.Console.Write(N + " ");
// }

// int ReadInt(string msg)
// {
//     System.Console.Write(msg);
//     return Convert.ToInt32(Console.ReadLine());
// }

// Main();


// Задача 2.
// void Main()
// {
// int number = ReadInt("Введите число: ");
// System.Console.WriteLine(SumDigitsOfNumber(number));
// }

// int SumDigitsOfNumber(int N)
// {
// if(N < 1) return 0;
// return N % 10 + SumDigitsOfNumber(N / 10);
// }

// int ReadInt(string msg)
// {
// System.Console.Write(msg);
// return Convert.ToInt32(Console.ReadLine());
// }

// Main();


// Задача 3.
// void Main()
// {
//     Console.Write("Введите текст: ");
//     string? intputText = Console.ReadLine();
//     PrintConsonants(intputText);
// }

// void PrintConsonants(string? str)
// {
//     if (str.Length < 1) return;

//     if (isConsonant(str[0]))
//         Console.Write(str[0] + " ");
    
//     PrintConsonants(str[1..]);
// }

// bool isConsonant(char c)
// {
//     return "qwrtpsdfghjklzxcvbnm".Contains(c);
// }

// Main();