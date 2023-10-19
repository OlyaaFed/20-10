Console.WriteLine("Введите число");
int k = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число послдедовательности");
int P = int.Parse(Console.ReadLine());
int n = 0;

for (int i = 0; i < P; i++)
{

    int a = int.Parse(Console.ReadLine());  
    if (a == k)
    {

        n++;
    }
}

Console.WriteLine($"Числа {k} будут повторяться {n} раз");
