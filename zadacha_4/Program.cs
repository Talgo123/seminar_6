// : Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


System.Console.WriteLine("введите число: ");
int num = int.Parse(Console.ReadLine());
int[] array = Fibonacci(num);
System.Console.WriteLine('[' + string.Join(",", array) + ']');



int[] Fibonacci(int n)
{
    int[] arr = new int[n];
    arr[0] = 0;
    arr[1] = 1;
    for (int i = 2; i <arr.Length; i++)
    {
        arr[i] = arr[i - 2] + arr[i - 1];
    }
    return arr;
}