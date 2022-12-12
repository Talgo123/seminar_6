//  Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


int number = new Random().Next(1, 100);
System.Console.WriteLine(number);
GetBinaryView(number);

void GetBinaryView(int number)
{
    if (number <= 0)
    {
        return;
    }
    GetBinaryView(number 2 /);
    Console.WriteLine(number % 2);
}