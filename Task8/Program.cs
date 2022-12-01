// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.Write("Введите любое число больше 0: ");
int even = 2;
bool res = int.TryParse(Console.ReadLine(), out int num);
if (res == true && num > 0) {
    if (num % 2 == 0) {
        Console.Write($"Чётные числа в диапазоне от 1 до {num}: ");
        for (int i = 1; i <= num / 2; i++) {
            Console.Write($"{even} ");
            even = even + 2;}}
    else {
        Console.Write($"Чётные числа в диапазоне от 1 до {num}: ");
        num = num - 1;
        for (int i = 1; i <= num / 2; i++) {
        Console.Write($"{even} ");
        even = even + 2;}}
}
if (res == true && num <= 0) Console.Write("Введённое число не соответствует условиям задачи");
if (res == false) Console.Write("Вы ввели не число");
