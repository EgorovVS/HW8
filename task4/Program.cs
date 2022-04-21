// Заполните спирально массив 4 на 4 по возрастанию

int row = Prompt("Введите количество строк ");
int column = row;
int[,] array = new int[row, column];
FillArray(array, row, column);
Console.WriteLine("Спирально - заполненный массив ");
PrintArray(array);

int Prompt(string message)
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}   


void PrintArray(int[,] arrayt)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] array, int row, int column)
{
    int full = 1, count = 0, ik = 0, jk = 0, k = 0;
    while (full <= row * column)
    {
        if (count == 0)
        {
            for (int j = jk; j < column - k; j++)
            {
                array[ik, j] = full++;
                jk = j;
            }
            count = 1;
            ik++;
        }
        if (count == 1)
        {
            for (int i = ik; i < row - k; i++)
            {
                array[i,jk] = full++;
                ik = i;
            }
            count = 2;
            jk--;
        }
        if(count == 2)
        {
            for(int j = jk; j >= column - column + k; j--)
            {
                array[ik,j] = full++;
                jk = j;
            }
            count = 3;
        }
        if(count == 3)
        {
            for(int i = ik; i>k;i--)
            {
                array[i,jk] = full++;
                ik = i;
            }
            count = 0;
            jk++;
        }
        k++;
    }

}