// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

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

 for(int g = 0; g < arr.GetLength(0); g++)   
  {  
    for (int i = 0; i < arr.GetLength(1) - 1; i++)
    {
        for (int j = 0; j < arr.GetLength(1) - 1 - i; j++)
        {
            if (arr[g, j] < arr[g, j + 1])
            {
                int temp = arr[g, j];
                arr[g, j] = arr[g, j + 1];
                arr[g, j + 1] = temp;
            }
        
        }
    }
  }
Console.WriteLine();

Console.WriteLine("В результате упорядочивания по убыванию элементов каждой строки двумерной массива матрица имеет вид:");
PrintArr(arr);
