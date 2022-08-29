// Вывод второй цифры трехзначного вводимого числа
Console.WriteLine("Введите трехзначное число");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
string stringNumberText = Convert.ToString(stringNumber);
if (stringNumberText.Length == 3)
Console.WriteLine("Вторая цифра этого числа "+stringNumber[1]);
else
Console.WriteLine("Введено некорректное число");
