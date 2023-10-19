Console.Write("Введите числа последовательности ");

int n = int.Parse(Console.ReadLine());
double proiz = 1;

for (int i = 1; i <= n; i++)
{
    double number = double.Parse(Console.ReadLine());
    double a = Math.Abs(number);
    proiz *= a;
}

Console.WriteLine($"Произведение элементов {proiz}");
