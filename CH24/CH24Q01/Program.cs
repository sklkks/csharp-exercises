using System;

Console.Write("입력 개수: ");
int count = int.Parse(Console.ReadLine());

int[] acceptCounts = new int[3];
int rejectCount = 0;

DeliveryKind[] kinds = (DeliveryKind[])Enum.GetValues(typeof(DeliveryKind));

for (int i = 0; i < count; i++)
{
    Console.Write($"{i + 1}번 배송 구분: ");
    string input = Console.ReadLine().Trim();

    if (input != null && !input.Contains(",") &&
        Enum.TryParse<DeliveryKind>(input, true, out DeliveryKind kind) &&
        Enum.IsDefined(typeof(DeliveryKind), kind))
    {
        Console.WriteLine($"접수: {kind}");

        if (kind == DeliveryKind.Standard) acceptCounts[0]++;
        else if (kind == DeliveryKind.Express) acceptCounts[1]++;
        else if (kind == DeliveryKind.Pickup) acceptCounts[2]++;
    }
    else
    {
        Console.WriteLine("거절");
        rejectCount++;
    }
}

for (int j = 0; j < kinds.Length; j++)
{
    Console.WriteLine($"{kinds[j]}: {acceptCounts[j]}");
}
Console.WriteLine($"거절: {rejectCount}");

enum DeliveryKind
{
    Standard = 10,
    Express = 20,
    Pickup = 30
}
