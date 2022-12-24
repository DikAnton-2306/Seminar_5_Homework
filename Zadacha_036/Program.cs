// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

System.Console.WriteLine("Укажите размер массива: ");
int SIZE = int.Parse(Console.ReadLine());

System.Console.WriteLine("Укажите левую границу цифр: ");
int LEFT_RANGE = int.Parse(Console.ReadLine());

System.Console.WriteLine("Укажите правую границу цифр: ");
int RIGHT_RANGE = int.Parse(Console.ReadLine());

int[] array = new int[SIZE];

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1); // [-9; 10)
    }
    return arr;
}

int SumNumbersOddIndex (int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i = i + 2)
    {
        sum += arr[i];
    }
    return sum;
}

array = FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.WriteLine('[' + string.Join(", ", array) + ']');
int sum = SumNumbersOddIndex(array);
System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sum}");