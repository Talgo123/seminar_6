//  Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

void CopeArray(int[] arr)
{
    int[] mass = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        mass[i] = arr[i];
        System.Console.WriteLine('[' + string.Join(",", mass) + ']'); // или можем вывести строку за цикл чтобы пропустить этапы копирования.
    }
}

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1); // от минуса 9 до 10 (10 не включается)
    }
    return arr;
}

int EntryNumber(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int size = EntryNumber("введите размер массива: ");
int[] array = new int[size];
array = FillArrayWithRandomNumbers(size, -9, 9);

System.Console.WriteLine('[' + string.Join(",", array) + ']');
CopeArray(array);
