// Программа выводит третью цифру вводимого числа или сообщает, что ее нет
Console.WriteLine("Введите число, а я напишу его третью цифру: ");
int Number = Convert.ToInt32(Console.ReadLine());
string NumberText = Convert.ToString(Number);
if (NumberText.Length > 2)
Console.WriteLine("Третья цифра этого числа " +NumberText[2]);
else
Console.WriteLine("У введенного числа нет третьей цифры");
