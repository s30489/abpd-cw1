// See https://aka.ms/new-console-template for more information
Console.WriteLine("Modyfikacja 1");

static double srednia(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }
    sum /= numbers.Length;
    return sum;
}

int[] arr = { 1, 2, 3, 4, 5 };

Console.WriteLine(srednia(arr));