using System;

Console.Write("입력: ");
string fir = Console.ReadLine();
Console.Write("입력: ");
string sec = Console.ReadLine();

bool first = int.TryParse(fir, out int number1);
bool secend = int.TryParse(sec, out int number2);

int fir_int = Convert.ToInt32(number1);
int sec_int = Convert.ToInt32(number2);

Console.WriteLine($"첫 변환: {first} / {fir_int}");
Console.WriteLine($"둘째 변환: {secend} / {sec_int}");
