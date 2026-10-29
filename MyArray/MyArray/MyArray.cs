using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class MyArray
{
    public static void ForEach<T>(T[] array, Action<T> action)
    {
        Queue<T> a = new Queue<T>();

        while (a.Count > 0)
        {
            action(a.Dequeue());
        }
    }

    public static int Count<T>(T[] array, Predicate<T> match)
    {
        int count = 0;
        foreach (T number in array)
        {
            if (match(number))
            {
                count++;
            }
        }
        return count;
    }

    public static bool Exists<T>(T[] array, Predicate<T> match)
    {
        foreach (T number in array)
        {
            if (match(number))
            {
                return true;
            }
        }
        return false;
    }

    public static int FindIndex<T>(T[] array, Predicate<T> match)
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


    public static T[] Filter<T>(T[] array, Predicate<T> match)
    {
        T[] result = new T[Count(array, match)];
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


    public static void Transform<T>(T[] array, Func<T, T> transformer)
    {
        for (int i = 0; i < array.Length; ++i)
        {
            array[i] = transformer(array[i]);
        }
    }

    public static TOutput[] ConvertAll<TInput, TOutput>(TInput[] array, Func<TInput, TOutput> converter)
    {
        TOutput[] result = new TOutput[array.Length];
        int index = 0;
        for(int i = 0;i < array.Length - 1; ++i)
        {
            result[index++] = converter(array[i]);
        }
        return result;
    }

    public static void Sort<T>(T[] array, Func<T, T, int> comparison)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - 1 - i; j++)
            {
                if (comparison(array[j], array[j + 1]) > 0)
                {
                    T temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
    public static void Sort<T>(T[] array) where T : IComparable<T>
    {
        Sort(array, (x, y) => x.CompareTo(y));
    }
         
}

