void NumbersBetween(int m, int n)
{
    Console.Write(m + "  ");
    ++m;
    if (m <= n)
        NumbersBetween(m, n);
}

Console.WriteLine("Введите значения начала и конца промежутка");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

Console.WriteLine("\nПромежуток:");
NumbersBetween(m, n);