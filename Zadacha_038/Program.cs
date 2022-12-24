// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76

System.Console.WriteLine("Укажите размер массива: ");
int SIZE = int.Parse(Console.ReadLine());
double[] array = new double[SIZE];

System.Console.WriteLine("Укажите левую границу цифр: ");
int LEFT_RANGE = int.Parse(Console.ReadLine());

System.Console.WriteLine("Укажите правую границу цифр: ");
int RIGHT_RANGE = int.Parse(Console.ReadLine());

double[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1); // [-9; 10)
    }
    return arr;
}

void FindDifferenceMinBetweenMax(double[] arr, out double min, out double max)
{
    min = arr[0];
    max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
            min = arr[i];
        if (arr[i] > max)
            max = arr[i];
    }
}


if (SIZE == 1)
    System.Console.WriteLine("В массиве 1 число");
else
{
    array = FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
    Console.WriteLine('[' + string.Join(", ", array) + ']');
    FindDifferenceMinBetweenMax(array, out double min, out double max);
    System.Console.WriteLine($"Минимальное значение({min}) меньше максимального ({max}) на {max - min}");
}


