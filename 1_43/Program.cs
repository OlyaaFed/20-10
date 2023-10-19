Console.Write("Введите число");

int n = int.Parse(Console.ReadLine());
int a = 0;
int b = n % 10;

while (n > 0)

{
    a = n % 10;
    n /= 10;
    if (n < 10)
        break;
}
int sum = a + b;

Console.WriteLine($"Сумма {sum}");
