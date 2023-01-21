// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.


int [] Array = CreateRandomArray(10, 1, 1000);
ShowArray(Array);
int difference = DifferenceMaxMin(Array);


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


int DifferenceMaxMin(int[] array)
{
int max = array[0];
int min = array[0];

for (int i=0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    else if (array[i] < min) min = array[i];
}
int diff = max - min;
return diff;
}

Console.WriteLine($"Разницa между максимальным и минимальным элементами массива равна: {difference}");

