// Определение одновременной кратности ввдимого числа 7 и 23
Console.WriteLine("Введите число, а я определю, кратно ли оно 7 и 23 одновременно: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 7 == 0 && num % 23 == 0)
{
    Console.WriteLine("Введенное число кратно 7 и 23 одновременно");
}
else
{
    Console.WriteLine("Введенное число не кратно 7 и 23 одновременно");
}
