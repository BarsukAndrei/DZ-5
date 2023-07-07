/* Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
*/

/* int[] startArray = GetArray(6, 100, 999);
Console.WriteLine(String.Join(" ", startArray));
Console.WriteLine($"Количество четных элементов в массиве = {GetEvenCount(StartArray)}");

int GetEvenCount(int[] array)
{
    int count = 0;
    foreach(var item in array)
    {
        if(item % 2 == 0) count ++;
    }
    return count;
} */

/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных ИНДЕКСАХ.
 */

/* int[] startArray = GetArray(6, 0, 999);
Console.WriteLine(String.Join(" ", startArray));
Console.WriteLine($"Сумма элементов на нечетных позициях = {GetSumOdd(startArray)}");

int GetSumOdd(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0) sum += array[i];
    }
    return sum;
} */

/* Задайте массив целых двухзначных чисел. Найдите разницу между максимальным и минимальным элементов массива.
 */
/* int[] startArray = GetArray(6, 10, 99);
Console.WriteLine(String.Join(" ", startArray));
Console.WriteLine($"Разница = {GetDifference(startArray)}");

int GetDifference(int[] array)
{
    int min = array[0];
    int max = array[0];
    foreach(var item in array)
    {
        if(max < item) max = item;
        if(min > item) min = item;
    }
    return max - min;
} */
