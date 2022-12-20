// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

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

const int LENGTH = 5;
const int LEFTRANGE = 1;
const int RIGHTRANGE = 100;
int[] massive = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"{string.Join(", ", massive)}");

int max = 0;
int min = 100;
for(int i = 0; i < massive.Length; i++)
    {
        if (max < massive[i])
        max = massive[i];
        else if(massive[i] < min)
        min = massive[i];
    }
int Dif = max - min;
// Console.WriteLine("Макс =" + max);
// Console.WriteLine("Мин =" + min);
Console.WriteLine("Разница между максимальным и минимальным элементов массива =" + Dif);
