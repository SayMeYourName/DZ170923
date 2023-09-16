// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int [,] GetMultiplicationMatrix(int[,] arrayA, int[,] arrayB)
{
      int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
      for (int i = 0; i < arrayA.GetLength(0); i++)
      {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
          for (int k = 0; k < arrayA.GetLength(1); k++)
          {
            arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
          }
        }
      }
      return arrayC;
}

int[,] GetArray(int m, int n, int min, int max)
{
      int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
      for (int j = 0; j < n; j++)
      {
        result[i, j] = new Random().Next(min, max + 1);
      }
    }
    return result;
}

void PrintArray(int[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
            System.Console.Write($"{array[i, j],4}   "); 
        System.Console.WriteLine(); 
    } 
    System.Console.WriteLine(); 
} 

Console.Write("Введите количество строк 1 матрицы: ");
int rowsA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 1 матрицы: ");
int colsA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк 2 матрицы: ");
int rowsB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 2 матрицы: ");
int colsB = Convert.ToInt32(Console.ReadLine());

int[,] A = GetArray(rowsA, colsA, 0, 10);
int[,] B = GetArray(rowsB, colsB, 0, 10);
PrintArray(A);
Console.WriteLine();
PrintArray(B);
Console.WriteLine();
PrintArray(GetMultiplicationMatrix(A,B));

