// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


int [] Array = CreateRandomArray(10, 100, 1000);
ShowArray(Array);
int Count = CountEven(Array);

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

int CountEven(int[] array)
{
int count = 0;
for (int i=0; i < array.Length; i++)
{
    if (array[i]%2 == 0) count++;
}
return count;
}

Console.WriteLine($"количество четных чисел в массиве: {Count}");