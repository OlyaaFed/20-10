Console.WriteLine("Введите элемент");
    int summa = 0;
while (true)
{

    int k = int.Parse(Console.ReadLine());
    if (k >= 0)
        summa += k;

    Console.WriteLine("Продолжить ввод? Y/N");
    if (Console.ReadLine() == "N")
        break;
   }

    Console.WriteLine($"Сумма чисел {summa}");
