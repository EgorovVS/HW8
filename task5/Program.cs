/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно 
выводить массив, добавляя индексы каждого элемента. */

int[,,] array = FillArray(4, 4, 4);
PrintArray(array);

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine($"Лист номер {i + 1} ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($" Элемент c индексом {j},{k}  => {array[i, j, k]}" + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] FillArray(int list, int row, int column)
{
    int[,,] unique = new int[list, row, column];
    int[,,] array = new int[list, row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = rnd.Next(11, 99);
            }
        }
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                if (unique[i, j, k] == array[i, j, k])
                    break;
                else
                {
                    unique[i, j, k] = array[i, j, k];
                }
        }
    }
    return unique;
}