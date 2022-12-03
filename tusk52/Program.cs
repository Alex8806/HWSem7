// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите размерность двумерного массива m x n");
Console.Write("Введите  m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ваш массив: ");
int[,] matrix = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
       
         Console.Write(matrix[i, j] + "\t");
         System.Threading.Thread.Sleep(100);
    }
    Console.WriteLine();
}

Console.WriteLine("Среднее арифметическое каждого столбца:");

for (int i = 0; i <  matrix.GetLength(1); i++)
{ double sum=0;
    Console.Write($"столбец {i+1} = ");
    for (int j = 0; j < m; j++)
    {
        sum+=matrix[j, i] ;
       
        
    }
    Console.WriteLine(Math.Round(sum/m,4));
    System.Threading.Thread.Sleep(100);
}