using System;

Console.Write("주문 A 수량: ");
int a_items = int.Parse(Console.ReadLine());
Console.Write("주문 B 수량: ");
int b_items = int.Parse(Console.ReadLine());

Console.Write("묶음당 수량: ");
int bundle_items = int.Parse(Console.ReadLine());

int a_bundles = GetBundleCount(a_items, bundle_items);
int b_bundles = GetBundleCount(b_items, bundle_items);

int sum = a_bundles + b_bundles;
int total_bunble = GetBundleCount(a_items + b_items, bundle_items);
int reduced = Math.Abs(total_bunble - sum);

Console.WriteLine($"개별 포장: {sum}");
Console.WriteLine($"합동 포장: {total_bunble}");
Console.WriteLine($"줄어든 묶음: {reduced}");

int GetBundleCount(int amount, int capacity)
{
    return (amount + capacity - 1) / capacity;
}