// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

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
        matrix[i, j] = new Random().Next(0, 100);
       
         Console.Write(matrix[i, j] + "\t");
         System.Threading.Thread.Sleep(200);
    }
    Console.WriteLine();
}

Console.WriteLine();

void CHisloPoKoordintam(int[,]matrix){
Console.WriteLine("Введите координаты желаемого числа двумерного массива m x n");
Console.Write($"Введите  номер строки  (максимальная строка { matrix.GetLength(0)}): ");
int mm = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите  номер столбца (максимальный столбец { matrix.GetLength(1)}): ");
int mn = Convert.ToInt32(Console.ReadLine());
if (mm>matrix.GetLength(0)|| mn> matrix.GetLength(1) ) {Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Вы ввели непраильные коордитнаты, таких чисел нет");
Console.ResetColor() ;
return;
}
 Console.ForegroundColor = ConsoleColor.Green;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
       
       if(i==(mm-1) & j==(mn-1)) Console.ForegroundColor = ConsoleColor.Red;
         Console.Write(matrix[i, j] + "\t");
         System.Threading.Thread.Sleep(200);
        if(i==(mm-1) & j==(mn-1)) Console.ResetColor();
    }
    Console.WriteLine();
}


Console.WriteLine("Ваш символ красный");
return;
}

CHisloPoKoordintam(matrix);