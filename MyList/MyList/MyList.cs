using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class MyList<T> : IList<T>
{
    private const int DefaultCapacity = 4;
    private T[] array;
    private int count;
    public MyList()
    {
        array = new T[DefaultCapacity];
    }
    public T this[int index] 
    { 
        get => array[index];
        set => array[index] = value;
    }

    public int Count => count;

    public bool IsReadOnly => false;

    public void Add(T item)
    {
        if (count == array.Length)
        {
            Array.Resize(ref array, array.Length * 2);
        }
        array[count++] = item;
    }

    public void Clear()
    {
        count = 0;
    }

    public bool Contains(T item)
    {
    
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        
    }

    public IEnumerator<T> GetEnumerator()
    {
        
    }

    public int IndexOf(T item)
    {
        
    }

    public void Insert(int index, T item)
    {
        
    }

    public bool Remove(T item)
    {
        
    }

    public void RemoveAt(int index)
    {
        
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

