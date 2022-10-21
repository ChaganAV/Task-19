Console.WriteLine("Введите 5-ти значное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num/10000 == num%10)
{
    if ((num/1000)%10 == (num%100)/10)
        Console.WriteLine($"Число {num} палиндром");
    else
        Console.WriteLine($"Число {num} не палиндром");
}
else
    Console.WriteLine($"Число {num} не палиндром");

