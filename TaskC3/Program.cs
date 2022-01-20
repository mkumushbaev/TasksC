//FirstTask();
//SecondTask();
//ThirdTask();
//NinethTask();
//TenthTask();
//ElevenTask();
//TwelfthTask();
//FourteenthTask();
//EighteenthTask();
//NineteenthTask();
//TwentyFirstTask();
//TwentyThirdTask();


void FirstTask()
{
    int InputNumber = 0;
    int Sum = 0;

    
    for (int i = 1; i <= 10; i++)
    {
        Console.Write("Введите число: ");
        InputNumber = Convert.ToInt32(Console.ReadLine());
        Sum += InputNumber;
    }
    Console.WriteLine(Sum);
}
void SecondTask()
{
    Console.WriteLine("Введите необходимое кол-во чисел:");
    int AmountOfNumbers = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int InputNumber = 0;
    int Sum = 0;


    for (int i = 1; i <= AmountOfNumbers; i++)
    {
        Console.WriteLine("Введите число: ");
        InputNumber = Convert.ToInt32(Console.ReadLine());
        if (!(InputNumber < 0) && InputNumber % 1 == 0) 
        {
            Sum += InputNumber;
        }
    }
    Console.WriteLine(Sum);
}
void ThirdTask()
{
    double Sum = 0;
    int Numbering = 1;
    Console.WriteLine("Макс.    Оценка  |  Балл\n         5       |  100");


    for (int i = 1; i <= 4; i++)
    {
        Console.Write($"Введите оценку по {Numbering} предмету: ");
        int InputNumber = Convert.ToInt32(Console.ReadLine());
        Sum += InputNumber * 5;
        Numbering++;
    }
    Console.WriteLine($"Общее количество набранных баллов из 100: {Sum}");
}
void NinethTask()
{
    int Answer = 1;

    for (int i = 1; i < 6; i++)
    {
        int InputNumber = Convert.ToInt32(Console.ReadLine());
        Answer *= InputNumber;
    }
    Console.WriteLine($"Произведение = {Answer}");
}
void TenthTask()
{
    int Sum = 0;

    for (int i = 1; i <= 10; i++)
    {
        Console.Write("Введите число: ");
        int InputNumber = Convert.ToInt32(Console.ReadLine());
        InputNumber *= InputNumber;
        Sum += InputNumber;
    }
    Console.WriteLine($"Сумма = {Sum}");
}
void ElevenTask()
{
    Console.WriteLine("Введите число N:");
    int NumberN = Convert.ToInt32(Console.ReadLine());
    double Sum = 0;

    for (int i = 1; i <= NumberN; i++)
    {
        Console.WriteLine("Введите число:");
        double InputNumber = Convert.ToInt32(Console.ReadLine());

        Sum += InputNumber * InputNumber;
    }
    Console.WriteLine(Sum);
}
void TwelfthTask()
{
    Console.Write("Введите кол-во n чисел: ");
    int NumberN = Convert.ToInt32(Console.ReadLine());
    int Answer = 0;

    for (int i = 1; i <= NumberN; i++)
    {
        Console.Write("Введите число: ");
        int InputNumber = Convert.ToInt32(Console.ReadLine());
        Answer += InputNumber;
    }
    Console.WriteLine(Answer / NumberN);
}
void FourteenthTask()
{
    Console.Write("Введите кол-во учеников: ");
    double AmounOfStudents = Convert.ToInt32(Console.ReadLine());
    double Answer = 0;
    int count = 1;

    for (int i = 1; i <= AmounOfStudents; i++)
    {
        Console.Write($"Введите оценку {count} ученика: ");
        int Grade = Convert.ToInt32(Console.ReadLine());
        count++;
        Answer += Grade;
    }
    Console.WriteLine($"Средняя оценка = {Answer / AmounOfStudents:F1}");
}
void EighteenthTask()
{
    Console.Write("Введите кол-во n чисел: ");
    int NumberN = Convert.ToInt32(Console.ReadLine());
    int Sum = 0;

    for (int i = 1; i <= NumberN; i++)
    {
        Console.Write("Введите число: ");
        int InputNumber = Convert.ToInt32(Console.ReadLine());
        Sum += Math.Abs(InputNumber);
    }
    Console.WriteLine(Sum);
}
void NineteenthTask()
{
    int Sum = 0;
    int Count = 1;
    int AmountOfStudents = 1;

    for (int i = 1; i <= 2; i++)
    {
        Console.WriteLine($"Введите оценки {AmountOfStudents} ученика");     
        for (int a = 1; a <= 4; a++)
        {
            Console.Write($"Введите оценку по {Count} предмету: ");
            int Grade = Convert.ToInt32(Console.ReadLine());
            Sum += Grade;
            Count++;
        }
        Console.WriteLine($"-------------------------------\nСумма оценок {AmountOfStudents} ученика = {Sum}\n");
        AmountOfStudents++;
        Count = 1;
        Sum = 0;
    }
}
void TwentyFirstTask()
{
    Console.Write("Введите кол-во учеников: ");
    int AmountOfStudents = Convert.ToInt32(Console.ReadLine());
    double Answer = 0;
    int Count = 1;

    for (int i = 1; i <= 2; i++)
    {
        Count = 1;
        for (int a = 1; a <= AmountOfStudents; a++)
        {
            Console.Write($"Введите возраст {Count} ученика: ");
            double Age = Convert.ToDouble(Console.ReadLine());
            Answer += Age;
            Count++;
        }
        Console.WriteLine($"Средний возраст 1/2 классов = {Answer/AmountOfStudents:F1\n");
        Answer = 0;
    }
    
}
void TwentyThirdTask()
{
    Console.Write("Введите кол-во учеников: ");
    int AmountOfStudents = Convert.ToInt32(Console.ReadLine());
    int Count = 1;
    int Answer = 0;

    for (int i = 1; i <= 2; i++)
    {
        for (int a = 1; a <= AmountOfStudents; a++)
        {
            Console.Write("Введите рост ученика: ");
            int Height = Convert.ToInt32(Console.ReadLine());
            Answer += Height;
        }
        Console.Write($"Средний рост {Count} класса = {Answer/AmountOfStudents}");
        Answer = 0;
        Count++;
    }
}
