Console.WriteLine("Введите натуральное число n");
int z;
int a;
int b = 0;
int P;
int sum;

z = Convert.ToInt32(Console.ReadLine());
P = z;

while (z != 0)
{
    if (z / 10 == 0)
        b = z;
    z /= 10;
}

a = P % 10;
sum = b + a;

Console.WriteLine($"Сумма {sum}");
