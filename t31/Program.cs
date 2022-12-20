// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

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

(int, int) SumPositiveAndNegative(int[] array)
{
    int sumPositive = 0;
    int sumNegative = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) //если эл-т положит
        {
            sumPositive += array[i]; //копить положит сумму
        }
        else //если эл-т отрицат 
        {
            sumNegative += array[i]; //копить отриц сумму
        }
    }
    return (sumPositive, sumNegative);
}
const int LENGTH = 12;
const int LEFTRANGE = -9;
const int RIGHTRANGE = 9;
int[] massive = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"{string.Join(", ", massive)}");
(int sumP, int sumN) = SumPositiveAndNegative(massive);
Console.WriteLine($"Сумма положит эл-в = {sumP}, отрицат-х = {sumN}");
