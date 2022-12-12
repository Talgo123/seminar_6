//  Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
int EntryNumber(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void Triangle(int a, int b, int c)
{
   if (a + b < c || a + c < b || b + c < a)
   {
    System.Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} существует");
   }
   else
   {
    System.Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c}  не существует");
   }
}

int firstSide = EntryNumber("Введите первую сторону треугольника: ");
int secondSide = EntryNumber("Введите вторую сторону треугольника: ");
int thirdSide = EntryNumber("Введите третью сторону треугольника: ");

Triangle(firstSide, secondSide, thirdSide);

