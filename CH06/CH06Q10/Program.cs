using System;

Console.Write("");
string people = Console.ReadLine();

Console.Write("");
string speed = Console.ReadLine();

Console.Write("");
string alarm = Console.ReadLine();

bool people1 = int.TryParse(people, out int number1);
bool speed1 = double.TryParse(speed, out double number2);
bool alarm1 = bool.TryParse(alarm, out bool number3);

int success = Convert.ToInt32(people1) + Convert.ToInt32(speed1) + Convert.ToInt32(alarm1);

Console.WriteLine($"인원 [{people}]: {people1} / {number1} / {number1.GetType()}");
Console.WriteLine($"속도 [{speed}]: {speed1} / {number2} / {number2.GetType()}");
Console.WriteLine($"알림 [{alarm}]: {alarm1} / {number3} / {number3.GetType()}");
Console.WriteLine($"변환 성공: {success} / 모두 성공: {(people1 && speed1 && alarm1)}");