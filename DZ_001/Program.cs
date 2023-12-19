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


int[] SearchCoordinates()
{
    Console.Write("Введите координаты (строка столбец) элемента, который хотите найти: ");
    string input = Console.ReadLine();
    string[] coordinates = input.Split(' ');

    if (coordinates.Length == 2 && int.TryParse(coordinates[0], out int row) && int.TryParse(coordinates[1], out int column))
    {
        return new int[] { row, column };
    }
    else
    {
        Console.WriteLine("Некорректный ввод. Пожалуйста, введите два целых числа через пробел.");
        return SearchCoordinates();
    }

}

void ResultSearch(int[,] array, int[] coordinates)
{
    int rowToFind = coordinates[0];
    int columnToFind = coordinates[1];

    if (rowToFind >= 0 && rowToFind < array.GetLength(0) && columnToFind >= 0 && columnToFind < array.GetLength(1))
    {
        int numberToFind = array[rowToFind, columnToFind];
        bool numberFound = false;


        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == numberToFind)
                {
                    numberFound = true;
                    break;
                }
            }
            if (numberFound)
                break;
        }

        if (numberFound)
        {
            Console.WriteLine("Число есть в массиве");
        }
        else
        {
            Console.WriteLine("Числа нет в массиве");
        }
    }
    else
    {
        Console.WriteLine("Введенные координаты выходят за границы массива.");
    }
}

int[,] myArray = Create2DArray(2, 5, 0, 9);
Print2DArray(myArray);

int[] coordinatesToFind = SearchCoordinates();
ResultSearch(myArray, coordinatesToFind);
