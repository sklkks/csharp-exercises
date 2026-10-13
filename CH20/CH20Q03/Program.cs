using System;
using CH20Q03;

Console.Write("페이지 수: ");
int pages = int.Parse(Console.ReadLine());
Booklet basic = new Booklet(pages);

Console.Write("지정 부수: ");
int wl = int.Parse(Console.ReadLine());
Booklet wlwjd = new Booklet(pages, wl);



Console.WriteLine($"기본: {basic.Pages}쪽, {basic.Copies}부, {basic.sheets}장");

Console.WriteLine($"지정: {wlwjd.Pages}쪽, {wlwjd.Copies}부, {wlwjd.sheets}장");