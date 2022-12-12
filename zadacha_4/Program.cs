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