using System;

Console.Write("정수 개수: ");
int count = int.Parse(Console.ReadLine());
int[] numbers = new int[count];

for (int i = 0; i < count; i++)
{
    Console.Write($"{i + 1}번째 정수: ");
    numbers[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine($"폭: {MeaSure(numbers, GetRange)}");
Console.WriteLine($"변화: {MeaSure(numbers, CountDifferentAdjacentPairs)}");


static int GetRange(int[] arr) 
{
    int max = arr[0];
    int min = arr[0];
    foreach (int n in arr)
    {
        if( n > max ) max = n;
        if( n < min ) min = n;
    }
    return max - min;
}

static  int CountDifferentAdjacentPairs(int[] arr)
{
    int diffCount = 0;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] != arr[i + 1])
        {
            diffCount++;
        }

    }
    return diffCount;
}
static int MeaSure(int[] x, Measure measure)
{
    return measure(x);
}

delegate int Measure(int[] x);