Console.WriteLine("Введите кол-во строк(больше чем столбцов): ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[lines,columns];
FillArray(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,100);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

int minsum = Int32.MaxValue;
int indexLine = 0;
int sum = 0;

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        sum += numbers[i,j];
    }

    if (sum < minsum)
    {
        minsum = sum;
        indexLine++;
    }
    sum = 0;
}

System.Console.WriteLine("Строка с наименьшей суммой элементов номер "+ indexLine);