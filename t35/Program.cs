// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] GetRandomArray(int length, int leftRange, int rightRange)
{
    int N=123;
    int[] array = new int[N];
    Random rand = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}

const int LENGTH = 123;
const int LEFTRANGE = 1;
const int RIGHTRANGE = 151;
int[] massive = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"{string.Join(", ", massive)}");

int count=0;
for(int i = 0; i < massive.Length; i++)
{
    if(massive[i] > 10 && massive[i] < 100)
    count=count+1;
}

Console.WriteLine("Количество чисел от 10 до 99 =" + count);