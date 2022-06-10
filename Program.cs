// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел

Console.Write("Введите первое число => ");
string paramString1 = Console.ReadLine();
int Paramint1 = int.Parse(paramString1);
Console.Write("Введите второе число => ");
string paramString2 = Console.ReadLine();
int Paramint2 = int.Parse(paramString2);
Console.Write("Введите третье число => ");
string paramString3 = Console.ReadLine();
int Paramint3 = int.Parse(paramString3);

if (Paramint1 > Paramint2)
{
    if (Paramint1 > Paramint3)
    {
        Console.WriteLine($"{Paramint1} = максимум");
    }
    else
    {
        Console.WriteLine($"{Paramint3} = максимум");
    }
}
else
    {
        if (Paramint2 > Paramint3)
        {
            Console.WriteLine($"{Paramint2} = максимум");
        }
        else
        {
            Console.WriteLine($"{Paramint3} = максимум");
        }
    }