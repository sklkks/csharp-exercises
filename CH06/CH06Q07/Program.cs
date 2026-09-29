using System;

Console.Write("입력");
string num = Console.ReadLine();

bool intSuccess = int.TryParse(num, out int num1);
bool longSuccess = long.TryParse(num, out long num2);

int success = Convert.ToInt32(intSuccess) + Convert.ToInt32(longSuccess);


Console.WriteLine($"int: {intSuccess} / {num1}");
Console.WriteLine($"long: {longSuccess} / {num2}");
Console.WriteLine($"성공한 변환: {success}");