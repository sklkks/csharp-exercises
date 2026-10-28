using System;

class MyArray
{
    public static void ForEach(int[] array, Action<int> action)
    {
        foreach (int number in array)
        {
            action(number);
        }
    }

    public static int Count(int[] array, Predicate<int> match)
    {
        int count = 0;
        foreach (int number in array)
        {
            if (match(number))
            {
                count++;
            }
        }
        return count;
    }

    public static bool Exists(int[] array, Predicate<int> match)
    {
        foreach (int number in array)
        {
            if (match(number))
            {
                return true;
            }
        }
        return false;
    }

    public static int FindIndex(int[] array, Predicate<int> match)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (match(array[i]))
            {
                return i;
            }
        }
        return -1;
    }


    public static int[] Filter(int[] array, Predicate<int> match)
    {
        int[] result = new int[Count(array, match)];
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (match(array[i]))
            {
                result[index++] = array[i];
            }
        }
        return result;
    }


    public static void Transform(int[] array, Func<int, int> transformer)
    {
        for (int i = 0; i < array.Length; ++i)
        {
            array[i] = transformer(array[i]);
        }
    }

    public static void Sort(int[] array, Func<int, int, int> comparison)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - 1 - i; j++)
            {
                if (comparison(array[j], array[j + 1]) > 0)
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
}

