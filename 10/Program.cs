Console.Write("Введите числа последовательности");
int n = int.Parse(Console.ReadLine());
double sum = 0;
double sredneearif;

for (int i = 1; i <= n; i++)
{
    double number = double.Parse(Console.ReadLine());
    sum += number;
}

sredneearif = sum / n;
Console.WriteLine($"Среднее арифметическое {sredneearif}");
