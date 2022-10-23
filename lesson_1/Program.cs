Random a = new Random();
int b = a.Next(100, 1000);
int c = a.Next(100, 1000);
int d = a.Next(100, 1000);
int e = a.Next(100, 1000);
int counter = 0;
int[] x = {b, c, d, e};

for (int i = 0; i < 4; i++)
{
    if (x[i] % 2 == 0)
    {
        counter++;
    }
}
Console.WriteLine($"[{b}, {c}, {d}, {e}] -> {counter}");