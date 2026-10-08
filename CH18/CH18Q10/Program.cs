using System;

using CH18Q10;

Console.Write("한도: ");
int limit = int.Parse(Console.ReadLine());
Console.Write("초기 내역 수: ");
int count = int.Parse(Console.ReadLine());
int[] initial = new int[count];

for(int i = 0; i < initial.Length; i++)
{
    Console.Write($"{i + 1}번 초기 금액: ");
    initial[i] = int.Parse(Console.ReadLine());

}

Console.Write("추가할 단건 금액: ");
int single= int.Parse(Console.ReadLine());
Console.Write("추가 묶음 개수: ");
int batchCount= int.Parse(Console.ReadLine());
int[] batch = new int[batchCount];

for (int i = 0; i < batch.Length; i++)
{
    Console.Write($"{i + 1}번 묶음 금액: ");
    batch[i] = int.Parse(Console.ReadLine());

}

ExpenseBook book = new ExpenseBook(limit, initial);

Console.WriteLine($"초기: {book.Describe()}");
bool success = book.TryAdd(single);
Console.WriteLine($"단건: {success}: {book.Describe()}");
success = book.TryAdd(batch);
Console.WriteLine($"묶음: {success}: {book.Describe()}");

ExpenseBook empty = new ExpenseBook(limit);
Console.WriteLine($"별도 장부: {book.Describe()}");