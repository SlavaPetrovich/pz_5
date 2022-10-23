Random a = new Random();
int b = a.Next(-99, 100);
int c = a.Next(-99, 100);
int d = a.Next(-99, 100);
int e = a.Next(-99, 100);
int[] x = {b, c, d, e};
int counter = 0;

for (int i = 0; i < 4; i++)
{
    if (i % 2 != 0)
    {
        counter = counter + x[i];
    }
}

Console.WriteLine($"[{b}, {c}, {d}, {e}] -> {counter}");
