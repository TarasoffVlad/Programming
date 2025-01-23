Console.WriteLine("Введите своё имя");
string Name = Console.ReadLine();
Console.WriteLine("Введите свою фамилию");
string Surname = Console.ReadLine();
Console.WriteLine("Укажите свой день рождения (числом, без месяца и года)");
byte Birthday = Convert.ToByte(Console.ReadLine());
Console.WriteLine("Укажите месяц рождения (числом)");
byte MonthOfBirth = Convert.ToByte(Console.ReadLine());
if ((MonthOfBirth == 1 && Birthday <= 20) || (MonthOfBirth == 12 && Birthday >= 22))
{
    Console.WriteLine($"Ваше имя: {Name}, ваша фамилия: {Surname}, ваш знак зодиака: Козерог");
}
else if ((MonthOfBirth == 2 && Birthday <= 20) || (MonthOfBirth == 1 && Birthday >= 21))
{
    Console.WriteLine($"Ваше имя: {Name}, ваша фамилия: {Surname}, ваш знак зодиака: Водолей");
}
else if ((MonthOfBirth == 3 && Birthday <= 20) || (MonthOfBirth == 2 && Birthday >= 21))
{
    Console.WriteLine($"Ваше имя: {Name}, ваша фамилия: {Surname}, ваш знак зодиака: Рыбы");
}
else if ((MonthOfBirth == 4 && Birthday <= 19) || (MonthOfBirth == 3 && Birthday >= 21))
{
    Console.WriteLine($"Ваше имя: {Name}, ваша фамилия: {Surname}, ваш знак зодиака: Овен");
}
else if ((MonthOfBirth == 5 && Birthday <= 20) || (MonthOfBirth == 4 && Birthday >= 20))
{
    Console.WriteLine($"Ваше имя: {Name}, ваша фамилия: {Surname}, ваш знак зодиака: Телец");
}
else if ((MonthOfBirth == 6 && Birthday <= 21) || (MonthOfBirth == 5 && Birthday >= 21))
{
    Console.WriteLine($"Ваше имя: {Name}, ваша фамилия: {Surname}, ваш знак зодиака: Близнецы");
}
else if ((MonthOfBirth == 7 && Birthday <= 22) || (MonthOfBirth == 6 && Birthday >= 22))
{
    Console.WriteLine($"Ваше имя: {Name}, ваша фамилия: {Surname}, ваш знак зодиака: Рак");
}
else if ((MonthOfBirth == 8 && Birthday <= 22) || (MonthOfBirth == 7 && Birthday >= 23))
{
    Console.WriteLine($"Ваше имя: {Name}, ваша фамилия: {Surname}, ваш знак зодиака: Лев");
}
else if ((MonthOfBirth == 9 && Birthday <= 22) || (MonthOfBirth == 8 && Birthday >= 23))
{
    Console.WriteLine($"Ваше имя: {Name}, ваша фамилия: {Surname}, ваш знак зодиака: Дева");
}
else if ((MonthOfBirth == 10 && Birthday <= 23) || (MonthOfBirth == 9 && Birthday >= 23))
{
    Console.WriteLine($"Ваше имя: {Name}, ваша фамилия: {Surname}, ваш знак зодиака: Весы");
}
else if ((MonthOfBirth == 11 && Birthday <= 21) || (MonthOfBirth == 10 && Birthday >= 24))
{
    Console.WriteLine($"Ваше имя: {Name}, ваша фамилия: {Surname}, ваш знак зодиака: Скорпион");
}
else if ((MonthOfBirth == 12 && Birthday <= 21) || (MonthOfBirth == 11 && Birthday >= 22))
{
    Console.WriteLine($"Ваше имя: {Name}, ваша фамилия: {Surname}, ваш знак зодиака: Стрелец");
}
