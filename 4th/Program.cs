Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Найдены следующие чётные числа: ");
if (number == 0)
{
    Console.Write(number);
}
    for (int i = 1; i <= number; i++)
    {

        if (i % 2 == 0)
        {
            Console.Write(i);
            if (i != number & i!= number-1)
            {
                Console.Write(", ");
            }
        }

    }