/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
строку с наименьшей суммой элементов. */

int[,] massive = FillArray(6, 4);
int min = 1000;
int answer = 0;
PrintArray(massive);
SumArray(massive);
Console.WriteLine($"Строка с наименьшей суммой элементов - {answer + 1}");
Console.ReadKey();

void SumArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        Console.WriteLine($"сумма {i + 1} строки " + sum);
        Console.WriteLine();
        {
            min = sum;
            answer = i;
        }

    }
}
int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 11);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}" + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
