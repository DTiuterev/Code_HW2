// Определение выходного дня по вводимой цифре дня недели 
Console.WriteLine("Введи цифру, обозначающую соответствующий день недели (от 1 до 7): ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber > 0 && dayNumber < 6)
    
  Console.WriteLine("Это рабочий день");

else if (dayNumber == 6 || dayNumber == 7)    

    Console.WriteLine("Это выходной день");
    
    else Console.WriteLine("Введено некорректное число");
