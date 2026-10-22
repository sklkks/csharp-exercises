using System;
using CH23Q01;

Console.Write("전체 수량: ");
int total = int.Parse(Console.ReadLine());
Console.Write("현재 예약량: ");
int reserved = int.Parse(Console.ReadLine());

StockState stock = new StockState(total, reserved);

Console.Write("미리 볼 예약량: ");
int preview = int.Parse(Console.ReadLine());

StockState prev = Preview(stock, preview, out bool success);
Console.WriteLine($"미리보기: {success} : {prev}");
Console.WriteLine($"원본: {stock}");

Console.Write("실제 예약량: ");
int actual = int.Parse(Console.ReadLine());
bool reserv = TryReserve(ref stock, actual);
Console.WriteLine($"확정: {reserv} : {stock}");


static bool TryReserve(ref StockState state, int amount)

{
    if (amount <= 0 || amount > state.Available)
    {
        return false;
    }

    state.Reserved += amount;
    return true;
}

static StockState Preview(StockState state, int amount, out bool success)
{
    success = TryReserve(ref state, amount);
    return state;
}