Random a = new Random();
int b = a.Next(1, 100);
int c = a.Next(1, 100);
int d = a.Next(1, 100);
int e = a.Next(1, 100);
int[] x = {b, c, d, e};

int max = x.Max();
int min = x.Min();

int answer = max - min;
Console.WriteLine($"[{b}, {c}, {d}, {e}] -> {answer}");

