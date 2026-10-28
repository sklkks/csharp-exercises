using System;

Console.Write("데이터 수: ");
int count = int.Parse(Console.ReadLine());

int expected = 0;
int accepted = 0;
Alarm accumlated = Alarm.None;
for(int i = 0; i < count; i++)
{
    Console.Write($"{i + 1}번 수신 바이트");
    int packet = int.Parse(Console.ReadLine());
    int sequence = (packet >> 4) & 0b111;
    Alarm alarm = (Alarm)(packet & 0b111);
    bool success = (packet & 0b1000_1000) == 0 && sequence == expected;
    if (success)
    {
        accumlated |= alarm;
        accepted++;
        expected = (expected + 1) & 0b0111;

    }
    Console.WriteLine($"{success}: 순번 {sequence}, 경보 {alarm}, 기대 {expected}");

}

Console.WriteLine($"수신{accumlated}, 누적 {accumlated}");

[Flags]
enum Alarm
{
    None = 0,
    Heat = 1,
    Somke = 1 << 1,
    Water = 1 << 2,
}