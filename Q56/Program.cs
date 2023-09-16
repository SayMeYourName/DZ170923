// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


void FillArray(int[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
        for (int j = 0; j < array.GetLength(1); j++) 
            array[i, j] = new Random().Next(0, 10); 
} 

void PrintArray(int[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
            System.Console.Write($"{array[i, j],4}    "); 
        System.Console.WriteLine(); 
    } 
    System.Console.WriteLine(); 
} 

void MinSumRows(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.WriteLine($"Наименьшая сумма элементов в   {minSumRow + 1} строке");
    Console.WriteLine(); 
}


System.Console.WriteLine("Введите количество строк m"); 
int rows = Convert.ToInt32(Console.ReadLine()); 
System.Console.WriteLine("Введите количество столбцов n"); 
int cols = Convert.ToInt32(Console.ReadLine()); 
int[,] array = new int[rows, cols]; 
FillArray(array); 
PrintArray(array);
Console.WriteLine(); 
MinSumRows(array);
PrintArray(array); 