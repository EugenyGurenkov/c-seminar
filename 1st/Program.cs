Console.Write("Введите первое число: ");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int Number2 = Convert.ToInt32(Console.ReadLine());
if (Number1 > Number2)
{
    Console.WriteLine("Max = " + Number1+", Min = "+ Number2);
}
if (Number1 < Number2)
{
    Console.WriteLine("Max = " + Number2+", Min = "+ Number1);

}
else
{
    Console.WriteLine("Max и Min значения не найдены! Введены одинаковые числа.");
}

