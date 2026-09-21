using System;

int total_seats = 100;
int ticket_price = 12000;

int first_Booking = int.Parse(Console.ReadLine());
int additional_Booking  = int.Parse(Console.ReadLine());
int cancel_Booking = int.Parse(Console.ReadLine());



Console.WriteLine($"첫 예매: 예매 {first_Booking}석 / 남은 좌석 {total_seats - first_Booking}석 / 판매 {ticket_price * first_Booking}원");
Console.WriteLine($"추가 예매: {first_Booking + additional_Booking}석 / 남은 좌석{total_seats - first_Booking - additional_Booking}석 / {ticket_price * (first_Booking + additional_Booking)}원");
Console.WriteLine($"취소 후: {first_Booking + additional_Booking - cancel_Booking}석 / 남은 좌석{total_seats - first_Booking - additional_Booking + cancel_Booking}석 / {ticket_price * (first_Booking + additional_Booking - cancel_Booking)}원");
