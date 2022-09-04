System.Console.WriteLine("Введите размер массива: ");
int mas = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[mas,mas];
int num = 1;
int i = 0;
int j = 0;

while(num <= mas*mas)
{
    numbers[i,j] = num;
    if (i <= j + 1 && i + j < mas - 1) 
    {
        ++j;
    }
    else if (i < j && i + j >= mas - 1) 
    {
        ++i;
    }
    else if (i >= j && i + j > mas - 1)
    {
        --j;
    }
    else 
    {
        --i;
    }
    ++num;
}

PrintArray(numbers);

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