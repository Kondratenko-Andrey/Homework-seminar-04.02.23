// В прямоугольной матрице найти строку с наименьшей суммой элементов.

void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void FillArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-5, 10);
        }
    }
}

Console.Write("Введите необходимое кол-во строк в матрице: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите необходимое кол-во столбцов в матрице: ");
int n = int.Parse(Console.ReadLine()!);

int[,] arr = new int[m, n];

Console.WriteLine("Ниже предоставлена сформированная матрица:");

FillArr(arr);
PrintArr(arr);

int[] sumOfElements = new int[m];
int minSum = 0;

 for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sumOfElements[i] += arr[i, j];
        }
    }

//for(int i =0; i < sumOfElements.Length; i++)
//    Console.Write($"{sumOfElements[i]} ");

for(int i =1; i < sumOfElements.Length; i++)
    if(sumOfElements[i] < sumOfElements[minSum]) minSum = i;

Console.WriteLine();

Console.Write($"Индекс строки с наименьшей суммой элементов равен: {minSum}");