    Console.WriteLine("Введите число последовательности");
    double summa = 0;
    double c = int.Parse(Console.ReadLine());
    while (true)
    {
        if (c >= 0)
        summa += Math.Pow(c, 2);

    Console.WriteLine("Продолжить ввод? Y/N");
    if (Console.ReadLine() == "N")

        break;
}
Console.WriteLine($"Сумма последовательности {summa}");
