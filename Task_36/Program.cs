// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int [] Array = CreateRandomArray(4, 0, 100);
ShowArray(Array);
int summa = SumNumbers(Array);

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int SumNumbers(int[] array)
{
int sum = 0;
for (int i=0; i < array.Length; i++)
{
    if (i%2-1 == 0) sum = sum + array[i];
}
return sum;
}

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {summa}");