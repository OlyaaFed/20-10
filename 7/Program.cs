Console.WriteLine("Числа последовательности");

int P = int.Parse(Console.ReadLine());
int summa = 0;

Console.WriteLine("Введите числа последовательности");
for (int i = 0; i < P; i++)

{

    int z = int.Parse(Console.ReadLine());
    summa += Math.Abs(z);
}

Console.WriteLine($"Сумма {summa}");
