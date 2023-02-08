// Написать программу, которая обменивает элементы первой строки и последней строки

void FillArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(10);
        }
    }
}

void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }

        Console.WriteLine();

    }

}

void ChangeElements(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int temp = arr[0, j];
        arr[0, j] = arr[(arr.GetLength(0) - 1), j];
        arr[(arr.GetLength(0) - 1), j] = temp;
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

Console.WriteLine();

ChangeElements(arr);

Console.WriteLine("В результате обмена элементов первой строки и последней строки матрица имеет вид:");
PrintArr(arr);
