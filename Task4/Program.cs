// Напишите программу, которая принимает на вход три числа и 
// выдаёт максимальное из этих чисел
// Решено через создание массива.
Console.Clear();
Console.Write("Введите количество элементов массива: "); // Количество элементов массива
int n = int.Parse(Console.ReadLine());
int[] ar = new int[n]; // создание пустого массива
int i = 0;
Console.Clear();
// Заполнение массива, иначе через цикл for (i = 0; i < ar.Lenght; i++){...}
while ( i < ar.Length ) {                               
    Console.Write($"Введите элемент массива под индексом {i}: ");
    ar[i] = int.Parse(Console.ReadLine());
    Console.Clear();
    i++;                                                            
}
// определение максимального значения и вывод результатов, иначе через цикл for
i = 0;
int index = 0;
int max = ar[0];
Console.Write("Массив [ ");
while ( i < ar.Length) {
    if ( max < ar[i]) {
        max = ar[i];
        index = i;
    }
    Console.Write($"{ar[i]} ");
    i++;    
}
Console.Write("]. ");
Console.Write($"Максимальное число в массиве равно {max}, значение № - {index + 1}.");
