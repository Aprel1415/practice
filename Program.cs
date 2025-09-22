int[] row = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

Console.WriteLine("Таблица умножения:");
Console.WriteLine("==================");

foreach (int number in row)
{
    for (int multiplier = 1; multiplier <= 10; multiplier++)
    {
        Console.Write($"{number} x {multiplier} = {number * multiplier}\t");
    }
    Console.WriteLine(); 
}