// Напишите программу, которая на вход принимает число и
// выдаёт, является ли число чётным
// Решение с помощью метода TryParse
Console.Clear();
Console.Write("Введите число: ");
bool res = int.TryParse(Console.ReadLine(), out int num);
if ( res == true) {
    if ( num % 2 == 0) Console.Write($"Вы ввели число {num} оно является чётным");
    else Console.Write($"Вы ввели число {num} оно не является чётным");}
else Console.Write("Вы ввели не число");
