//FirstTask();
//ThirdTask();
//FourthTask();
//FifthTask();
//SixthTask();
//SeventhTask();
//EighthTask();
//NinethTask();
//TenthTask();



void FirstTask()
{
    Console.Write("Введите необходимое число: ");
    int InputNumber = Convert.ToInt32(Console.ReadLine());
    int a = 1;
    int b = 0;
    int Sum = 0;

    for (int i = 1; i <= InputNumber; i++)
    {
        Sum = a + b;
        a = b;
        b = Sum;
    }
    Console.WriteLine(Sum+"\n");

    a = 1;
    b = 0;
    Sum = 0;
    for (int i = 1; i <= InputNumber; i++)
    {
        Sum = a + b;
        a = b;
        b = Sum;
        Console.Write(Sum+" ");
    }

    a = 1;
    b = 0;
    Sum = 0;
    Console.WriteLine("\n");
    for (int i = 1; i <= InputNumber; i++)
    {
        Sum = a + b;
        a = b;
        b = Sum;        
    }
    if (Sum % 2 == 0)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
void ThirdTask()
{
    Console.Write("Введите кол-во часов: ");
    int Hours = Convert.ToInt32(Console.ReadLine());
    Hours /= 3;
    int Answer = 1;

    for (int i = 1; i <= Hours; i++)
    {
        Answer *= 2;
    }
    Console.WriteLine(Answer);
}
void FourthTask()
{
    Console.Write("Введите кол-во месяцев: ");
    int Months = Convert.ToInt32(Console.ReadLine());
    double Answer = 1000;

    for (int i = 1; i <= Months; i++)
    {
        Answer *= 1.02;
    }
    Console.WriteLine($"{Answer - 1000:F2}");

    Answer = 1000;
    for (int i = 1; i <= Months; i++)
    {
        Answer *= 1.02;
    }
    Console.WriteLine($"{Answer:F2}");
}
void FifthTask()
{
    Console.Write("Введите кол-во дней: ");
    int Days = Convert.ToInt32(Console.ReadLine());
    double Distance = 10;
    double Sum = 0;

    for (int i = 1; i <= Days; i++)
    {
        Sum += Distance *= 1.1;
        if (i == 7)
        {
            Console.WriteLine($"За 7 дней: {Sum:F2} км");
        }
    }
    Console.WriteLine($"За все время: {Sum:F2} км");
}
void SixthTask()
{
    double Area = 100;
    double Productivity = 20;
    double Answer;
    int count = 2;
    double Sum = 0;

    for (int i = 1; i < 8; i++)
    {
        Area *= 1.05;
        Productivity *= 1.02;
        Answer = Productivity * Area;        
        Console.WriteLine($"За {count} год = {Answer:F2}");
        count++;
        if (i <= 6)
        {
            Sum += Answer;
        }
        Answer = 0;
    }
    Console.WriteLine($"\nУрожай за 6 лет = {2000+Sum:F2}");

    Area = 100;
    count = 2   ;
    Console.Write("\n");
    for (int i = 2; i <= 7; i++)
    {
        Area *= 1.05;        
        if ((i == 4) || (i == 5) || (i == 6) || (i == 7))
        {
            Console.WriteLine($"Площадь за {count} год = {Area:F2}");
        }
        count++;
    }
}
void SeventhTask()
{
    Console.Write("Введите кол-во шаров: ");
    int Ball = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите внутренний диаметр: ");
    double Diameter = Convert.ToInt32(Console.ReadLine());
    decimal Sum = 0;


    for (int i = 1; i <= Ball; i++)
    {
        Sum += (decimal) ((0.166 * Math.PI * Math.Pow(Diameter, 3)) / 1000);
        Diameter -= 0.5;
    }
    Console.WriteLine($"Объем = {Sum:F3}");
}
void EighthTask()
{
    Console.Write("Введите предел степени: ");
    int Degree = Convert.ToInt32(Console.ReadLine());
    int Multy = 1;
    int Sum = 0;

    for (int i = 2; i <= Degree; i++)
    {        
        for (int a = 1; a <= i; a++)
        {
            Multy *= 2;
        }
        Sum += Multy;
        Multy = 1;
    }
    Console.WriteLine($"Сумма = {Sum}");
}
void NinethTask()
{
    Console.Write("Введите основание: ");
    int Base = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите крайнюю степень: ");
    int Degree = Convert.ToInt32(Console.ReadLine());
    int Multy = 1;
    int BaseForCycle = Base;
    int Sum = 0;

    for (int i = 1; i <= Degree; i++)
    {
        int a = i;
        while (a > 0) 
        {
            if (a % 2 == 0)
            {
                a /= 2;
                BaseForCycle *= BaseForCycle;
            }
            else
            {
                a -= 1;
                Multy *= BaseForCycle;
            }
        }
        Sum += Multy;
        BaseForCycle = Base;
        Multy = 1;
    }
    Console.WriteLine($"Сумма = {Sum}");
}
void TenthTask()
{
    int Base = -1;
    int Answer = 0;


    for (int i = 1; i <= 10; i++)
    {
        Answer += Base * i * i;
        Base = -Base;
    }
    Console.WriteLine($"Сумма = {Answer}");
}