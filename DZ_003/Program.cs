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

void SumArray(int[,] array, out int minSumRow, out int minSum)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    minSum = int.MaxValue;
    minSumRow = -1;

    for (int i = 0; i < rows; i++)
    {
        int currentSum = 0;

        for (int j = 0; j < cols; j++)
        {
            currentSum += array[i, j];
        }

        if (currentSum < minSum)
        {
            minSum = currentSum;
            minSumRow = i;
        }
    }
}

int[,] myArray = Create2DArray(2, 5, 0, 9);
Print2DArray(myArray);

int minSumRow, minSum;
SumArray(myArray, out minSumRow, out minSum);

Console.WriteLine($"\nСтрока с наименьшей суммой элементов: {minSumRow + 1}. Сумма элементов в этой строке: {minSum}");
