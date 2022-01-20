SixthTask();
//EightTask();



void SixthTask()
{
    Console.Write("Введите макс. основание: ");
    int Base = Convert.ToInt32(Console.ReadLine());
    int Count = 1;
    int Answer = 0;
    int Sum = 0;

    for (int i = 1; i < Base; i++)
    {
        for (int a = 1; a < i; a++)
        {
            Answer += Count + (Count + 2);
            Count += 2;
        }        
        Sum += Answer;
        Answer = 0;
    }
    Console.WriteLine(Sum);
}
void EightTask()
{
    Console.Write("Введите основание: ");
    int Base = Convert.ToInt32(Console.ReadLine());
    int Sum = 1;
    int Number = 1;

    for (int i = 1; i <= Base; i++)
    {
        if (i == 1)
        continue;        
        Number += 2;
        Sum += Number + (Number + 2);        
    }
    Console.WriteLine($"Ответ: {Sum}");
}