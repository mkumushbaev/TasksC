//SecondTask();
//ThirdTask();
//FourthTask();
//SeventhTask();
//EightTask();
//NinethTask();
//TenthTask();
//EleventhTask();
//ThirteenthTask();
//FourteenthTask();
//FifteenthTask();
//SixteenthTask();
//SeventeenthTask();
//EighteenthTask();
//TwentiethTask();

void SecondTask()
{
    Console.WriteLine("Введите число:");
    int inputNumber = Convert.ToInt32(Console.ReadLine());


    for (int i = 0; i < 10; i++)
    {
        Console.Write($"{inputNumber} ");
    }
}
void ThirdTask()
{
    Console.WriteLine("Введите любое число > 10:");
    int inputNumberForB = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите любое число < 50:");
    int inputNumberForV = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Введите значения a и b, где b < a");
    Console.Write("а: ");
    int NumberA = Convert.ToInt16(Console.ReadLine());
    Console.Write("b: ");
    int NumberB = Convert.ToInt16(Console.ReadLine());


    Console.WriteLine("\nа)");
    for (int i = 20; i <= 35; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write(i + " ");
        }
    }

    Console.WriteLine("\nб)");
    for (int i = 10; i <= inputNumberForB; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write(Math.Pow(i, 2) + " ");
        }
    }

    Console.WriteLine("\nв)");
    for (int i = inputNumberForV; i < 50; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write(Math.Pow(i, 3) + " ");
        }
    }

    Console.WriteLine("\nг)");
    for (int i = NumberA; i >= NumberB; i--)
    {
        if (i % 2 == 0)
        {
            Console.Write(i + " ");
        }
    }
}
void FourthTask()
{
    Console.WriteLine("а)");
    for (int i = 10; i <= 25; i++)
    {
        Console.WriteLine($"{i} {i + 0.4}");
    }

    Console.WriteLine("б)");
    for (int i = 25; i <= 35; i++)
    {
        Console.WriteLine($"{i} {i + 0.5} {i - 1 + 0.8}");
    }

    Console.WriteLine("а)");
    for (int i = 21; i >= 10; i--)
    {
        Console.WriteLine($"{i} {i - 1 + 0.2}");
    }

    Console.WriteLine("б)");
    for (int i = 45; i >= 25; i--)
    {
        Console.WriteLine($"{i} {i - 1 + 0.5} {i - 1 + 0.2}");
    }

    Console.WriteLine("а)");
    for (int i = 21; i <= 35; i++)
    {
        Console.WriteLine($"{i} {i - 1 + 0.4}");
    }

    Console.WriteLine("б)");
    for (int i = 16; i <= 24; i++)
    {
        Console.WriteLine($"{i} {i - 1 + 0.5} {i + 0.8}");
    }
}
void SeventhTask()
{
    Console.WriteLine("1 штука = 55.99 руб\n");
    for (int i = 2; i <= 20; i++)
    {
        Console.WriteLine($"{i} шт. = {i * 55.99} руб");
    }
}
void EightTask()
{
    for (int i = 1; i <= 10; i++)
    {
        if (i / 2.205 > 1)
        {
            Console.WriteLine($"{i} фунт = {i / 2.205:#.##} кг.");
        }
        else
        {
            Console.WriteLine($"{i} фунт = {Math.Truncate((i / 2.205) * 1000)} г.");
        }
    }
}
void NinethTask()
{
    for (int i = 10; i <= 22; i++)
    {
        Console.WriteLine($"{i} дюйм = {i * 2.54} см");
    }
}
void TenthTask()
{
    Console.Write("Введите курс в деревянных: ");
    double RubleRate = Convert.ToDouble(Console.ReadLine());

    for (int i = 1; i <= 20; i++)
    {
        Console.WriteLine($"{i}$ = {i * RubleRate:#.##} руб.");
    }
}
void EleventhTask()
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"При высоте {i} км, расстояние = {Math.Sqrt(2 * 6371 * i):#.##} км");
    }
}
void ThirteenthTask()
{
    for (int i = 1; i < 9; i++)
    {
        Console.WriteLine($"{i} * 7 = {i * 7}");
    }
}
void FifteenthTask()
{
    Console.Write("Введите значение для умножения:\n");
    int inputNumber = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= 9; i++)
    {
        Console.WriteLine($"{i} * {inputNumber} = {i * inputNumber}");
    }
}
void SixteenthTask()
{
    for (int i = 2; i <= 20; i++)
    {
        Console.WriteLine($"{Math.Sin(i):F3}");
    }
}
void SeventeenthTask()
{
    for (double i = 0.1; i < 1.6; i += 0.1)
    {
        Console.WriteLine($"{Math.Sin(i):F3}");
    }
}
void EighteenthTask()
{
    Console.Write("Введите цену сыра за 1кг.: ");
    double PriceOfCheese = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите цену конфет за 1кг.: ");
    double PriceOfCandy = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("\n");

    for (double i = 50; i <= 1000; i += 50)
    {
        Console.WriteLine($"{i} гр. = {i / 1000 * PriceOfCheese:F2} руб.");
    }

    Console.WriteLine("\n");

    for (double i = 100; i <= 2000; i += 100)
    {
        Console.WriteLine($"{i} гр. = {i / 1000 * PriceOfCandy:F2} руб.");
    }
}
void TwentiethTask()
{
    for (decimal i = 2.1m; i <= 2.8m; i += 0.1m)
    {
        Console.Write($"{i:F1} ");
    }

    Console.WriteLine("\n");
    for (decimal i = 3.2m; i <= 3.9m; i += 0.1m)
    {
        Console.Write($"{i:F1} {i:F1} ");
    }

    Console.WriteLine("\n");
    for (decimal i = 2.2m; i <= 4.2m; i += 0.2m)
    {
        Console.Write($"{i:F1} ");
    }

    Console.WriteLine("\n");
    for (decimal i = 4.4m; i <= 6.4m; i += 0.2m)
    {
        Console.Write($"{i:F1} ");
    }
}
