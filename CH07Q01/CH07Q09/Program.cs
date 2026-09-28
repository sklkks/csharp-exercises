using System;

Console.Write("쿠폰 사용 여부: ");
bool coupon = bool.Parse(Console.ReadLine());

Console.Write("포인트 사용 선택 여부: ");
bool point = bool.Parse(Console.ReadLine());

Console.Write("현재 포인트: ");
int currentpoint = int.Parse(Console.ReadLine());

bool uespoint = point && (currentpoint >= 100);
bool discount = (coupon || point) && (!point || uespoint);
int discountAmount = discount ? 1000 : 0;
int remainingPoint = (discount && point) ? currentpoint - 100 : currentpoint;

Console.WriteLine($"할인 적용: {discount}");
Console.WriteLine($"할인액: {discountAmount}");
Console.WriteLine($"남은 포인트: {remainingPoint}");