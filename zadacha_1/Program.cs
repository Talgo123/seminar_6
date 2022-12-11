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

void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length/ 2; i++)
    {
        int temp = array[i];
        array[i] = array [array.Length - 1 - i];
        array [array.Length - 1 - i] = temp;
    }
}



int size = 7;
int leftRange = 1;
int rightRange = 100;

int[] array = FillArrayWithRandomNumbers(size, leftRange, rightRange);
System.Console.WriteLine('[' + string.Join(",", array) + ']');
ReverseArray(array);
System.Console.WriteLine('[' + string.Join(",", array) + ']');

