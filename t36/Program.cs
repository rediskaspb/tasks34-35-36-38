// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetRandomArray(int length, int leftRange, int rightRange)
{
    int[] array = new int[length];
    Random rand = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }

    return array;
}
int sum =0;
int SumEvenPos(int[] arr)
{
    for(int i = 1; i < arr.Length; i=i+2)
    {
    sum += arr[i];
    }
    return sum;
}

const int LENGTH = 4;
const int LEFTRANGE = -100;
const int RIGHTRANGE = 101;
int[] massive = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"{string.Join(", ", massive)}");
int sumE = SumEvenPos(massive);
Console.WriteLine($"Сумма элементов с четных позиций = "+ sum);

