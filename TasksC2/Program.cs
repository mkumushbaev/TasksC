//FirstTask();
//FourthTask();
//SixthTask();
//SeventhTask();
//EightTask();
//TenthTask();
//EleventhTAsk();


void FirstTask()
{
    int sumA = 0;
    int sumB = 0;
    int sumV = 0;
    int sumG = 0;


    for (int i = 100; i <= 500; i++)
    {
        if (i % 2 == 0)
        {
            sumA += i;
        }
    }
    Console.WriteLine($"а) {sumA}");


    Console.Write("Введите a при a < 500: ");
    int inputA = Convert.ToInt32(Console.ReadLine());
    for (int i = inputA; i <= 500; i++)
    {
        if (i % 2 == 0)
        {
            sumB += i;
        }
    }
    Console.WriteLine($"б) {sumB}");


    Console.Write("Введите b при b > -10: ");
    int inputB = Convert.ToInt32(Console.ReadLine());
    for (int i = -10; i < inputB; i++)
    {
        if (i % 2 == 0)
        {
            sumV += i;
        }
    }
    Console.WriteLine($"в) {sumV}");


    Console.Write("Введите значение a, при a < b: ");
    inputA = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение b, при a < b: ");
    inputB = Convert.ToInt32(Console.ReadLine());
    for (int i = inputA; i < inputB; i++)
    {
        if (i % 2 == 0)
        {
            sumG += i;
        }
    }
    Console.WriteLine($"г) {sumG}");
}
void FourthTask()
{
    int sum = 0;
    for (int i = 20; i <= 40; i++)
    {
        if (i % 2 == 0)
        {
            sum += (int)Math.Pow(i, 3);
        }
    }
    Console.WriteLine(sum);
}
void SixthTask()
{   
    Console.WriteLine("Введите основание:");
    int Base = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите крайнюю степень:");
    int Degree = Convert.ToInt32(Console.ReadLine());
    int Multiplication = 1;
    int Sum = 0;
    int BaseForCycle = Base;


    for (int a = 1; a <= Degree; a++)
    {
        int b = a;
        while (b > 0)
        {
            if (b % 2 == 0)
            {
                b /= 2;
                BaseForCycle *= BaseForCycle;
            }
            else if (b % 2 != 0)
            {
                b -= 1;
                Multiplication *= BaseForCycle;
            }
        }
        Sum += Multiplication;
        if (b == 0)
        {
            Multiplication = 1;
            BaseForCycle = Base;
        }
    }
    Console.WriteLine(Sum);

    #region бинарное возведение в степень
    //while (Degree > 0)
    //{
    //    if (Degree % 2 == 0)
    //    {
    //        Degree /= 2;
    //        Base *= Base;
    //    }
    //    else if (Degree % 2 != 0)
    //    {
    //        Degree -= 1;
    //        Multiplication *= Base;
    //    }
    //}
    //Console.WriteLine(Multiplication);
    #endregion
}
void SeventhTask()
{
    Console.WriteLine("Введите числитель:");
    double Numerator = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите знаменатель:");
    double Denominator = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите кол-во дробей:");
    int NumberOfFractions = Convert.ToInt32(Console.ReadLine());
    double Sum = 0;


    Console.Write("Сумма дробей: ");
    for (int i = 1; i <= NumberOfFractions; i++)
    {
        Sum += Numerator / Denominator;
        Console.Write($"{Numerator}/{Denominator} ");
        Numerator += 1;
        Denominator += 1;
    }
    Console.Write($"= {Sum:F2}");
}
void EightTask()
{
    Console.WriteLine("Введите кол-во:");
    double Denominator = Convert.ToDouble(Console.ReadLine());
    double Sum = 1;

    for (int i = 1; i < Denominator; i++)
    {
        Sum += (double) (1 / Denominator);
        Denominator -= 1;
    }
    Console.WriteLine($"{1+Sum:F2}");
}
void TenthTask()
{
    Console.WriteLine("Введите x:");
    int NumberX = Convert.ToInt32(Console.ReadLine());
    int Numerator = NumberX;
    int Denominator = 3;
    double Sum = 0;
    double Answer = 1;
    

    for (int a = 3; a <= 11; a++)
    {
        int b = a;
        while (b > 0)
        {
            if (b % 2 == 0)
            {
                b /= 2;
                Numerator *= Numerator;
            }
            else if (b % 2 != 0)
            {
                b -= 1;
                Answer *= NumberX;
            }
        }
        Sum += Answer / Denominator;
        if (b == 0)
        {
            Numerator = NumberX;
            Answer = 1;
            Denominator += 1;
        }
    }
    Console.WriteLine($"{NumberX+Sum:F2}");
}
void EleventhTAsk()
{
    int DistanceToWork = 1;
    double Storona = 1;
    double Distance = 1;
    double Puth = 1;

    for (int i = 1; i <= 100; i++)
    {
        Storona = -Storona;
        Distance += Storona / i;
        Puth += Distance;
    }
    Console.WriteLine($"Расстояние от дома = {Distance:f2}\nПройденный путь = {Puth:f2}");
}
