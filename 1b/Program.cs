Console.WriteLine("Введите значение ");

double e = double.Parse(Console.ReadLine());
double summa = 0;
double z;

int k = 1;

do
{
    z = 1.0 / (Math.Pow(2.0, k)) + 1.0 / (Math.Pow(3.0, k));
    summa += z; z++;

}
while (Math.Abs(z) >= e);
Console.WriteLine($"Сумма последовательности summa={summa}");

