Console.WriteLine("Введите значение");
int summa = int.Parse(Console.ReadLine());

while (true)

{
    Console.WriteLine("Введите число последовательности ");
    int x = int.Parse(Console.ReadLine());
    if (x >= 0)
        summa = x;

    Console.WriteLine("Продолжить ввод? Y/N");
    if (Console.ReadLine() == "N")
        break;
}

Console.WriteLine($"Сумма чисел  {summa}");
