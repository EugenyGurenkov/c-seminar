int[] numbers = new int [3];
Console.WriteLine("Введите 3 числа: ");
int MaxNumber = numbers[0];
for (byte i = 0; i < numbers.Length; i++)
{
    int number = Convert.ToInt32(Console.ReadLine());
    numbers[i] = number;
}
for (byte i = 0; i < numbers.Length; i++)
{
    if (MaxNumber < numbers[i])
    {
        MaxNumber = numbers[i];
    }
}
Console.WriteLine("Max = "+MaxNumber); 
