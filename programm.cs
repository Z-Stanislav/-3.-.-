// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


// Console.WriteLine("Введите число: ");                               // просим ввести число
// string num = Console.ReadLine();                                    // переменная string c именем "num"
// int simbol = num.Length;                                            // выясняем кол-во символов

// if (simbol == 5)                                                    // условие "если" кол-во символов равно 5
// {
//     if (num[0] == num[4] && num[1] == num[3])                       // если оба условия являются истинными, только тогда && возвращает true, иначе false
//     {                                                               // если первый и пятый символ, а так же втлрой и четвертый символ равны
//         Console.WriteLine($"{num} - палиндром");                    // то выводим число + "палиндром"
//     }
//     else                                                            // условие "и или"
//     {
//         Console.WriteLine($"{num} - не палиндром");                 // если условие false, то выводим "не палиндром"
//     }
// }
// else                                                                // условие "и или"
// {
//     Console.WriteLine($"{num} - не является пятизначным числом");   // если символов меньш или больше пяти, то выводим "не является пятизначным числом"
// }

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Таблица кубов: ");
// for (int i = 1; i <= n; i++)
// {
//     int cube = i * i * i;
//     Console.Write($"{cube}, ");
// }
