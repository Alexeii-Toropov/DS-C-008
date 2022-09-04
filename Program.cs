Console.WriteLine("Введите кол-во строк: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[lines,columns];
FillArray(numbers);
Console.WriteLine("Массив начальный: ");
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

int temp = 0;

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1) - 1; j++)
    {
        for (int k = 0; k < numbers.GetLength(1) - 1; k++)
        {
            if (numbers[i,k] < numbers[i, k + 1])
            {
                temp = numbers[i,k];
                numbers[i,k] = numbers[i,k + 1];
                numbers[i,k + 1] = temp;
            }
        }
    }
}
Console.WriteLine("Массив измененный: ");
PrintArray(numbers);