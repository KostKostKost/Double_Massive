int[,] Create2DArray(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void Swap2DArray(int[,] array)
{
    int rows = array.GetLength(0);
    int column = array.GetLength(1);

    if (rows >= 2)
    {
        for (int j = 0; j < column; j++)
            {
                int temp = array[0, j];
                array[0, j] = array[rows - 1, j];
                array[rows - 1, j] = temp;
            }
    }
}


int[,] myArray = Create2DArray(2, 5, 0, 9);

Console.WriteLine("Исходный массив:");
Print2DArray(myArray);

Console.WriteLine();

Swap2DArray(myArray);

Console.WriteLine("Массив после замены:");
Print2DArray(myArray);
