Console.Write("Введите число N ");

int N = int.Parse(Console.ReadLine());
double a = 1;

for (double k = 1; k <= N; k++)
{

    double P = (2 * k) / (2 * k + 1);
    
    a*= P;
}
Console.WriteLine($"Произведение {N} сомножителей выражений: {a}");
