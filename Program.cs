void NumbersBetween(int m, int n)
{
    Console.Write(m + "  ");
    ++m;
    if (m <= n)
        NumbersBetween(m, n);
}

int m = 1;
int n = 5;

Console.Write("\nПромежуток от {0} до {1}: ", m, n);
NumbersBetween(m, n);

m = 4;
n = 8;

Console.Write("\n\nПромежуток от {0} до {1}: ", m, n);
NumbersBetween(m, n);