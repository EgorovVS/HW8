/* Задайте две матрицы. Напишите программу, которая будет находить 
произведение двух матриц. */

int[,] matrix1 = FillArray(4, 4);
int[,] matrix2 = FillArray(4, 6);
int[,] matrix3 = MatrixPower(matrix1, matrix2);
PrintArray(matrix1);
PrintArray(matrix2);
PrintArray(matrix3);


int[,] MatrixPower(int[,] array, int[,] array2)
{
    int[,] power = new int[array.GetLength(0), array2.GetLength(1)];
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(0); j++)
            {
                for (int k = 0; k < array2.GetLength(1); k++)
                {
                    power[i, k] += array[i, j] * array2[i, k];
                }
            }
        }
    }
        return power;
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
