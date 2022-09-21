void Zadacha1()
{
    Console.WriteLine("_________________________");
    Console.WriteLine("Задача 1");
    Console.WriteLine("Введите любое трехзначное число:");
    int number = Convert.ToInt32(Console.ReadLine());
    int tens = number / 10 % 10;
    Console.WriteLine($"Вторая цифра числа {number} это {tens}");
}
Zadacha1();

void Zadacha2()
{
    Console.WriteLine("_________________________");
    Console.WriteLine("Задача 2");
    Console.WriteLine("Введите любое число:");
    int number = Convert.ToInt32(Console.ReadLine());
    number = Math.Abs(number);
    int ones = Math.Abs(number % 10);
    int newnumber = 0;
    if (number < 100) Console.WriteLine("В вашем числе нет третьей цифры");
    else
    {
        while (number > 999)
        {
            number = number / 10;
        }
        newnumber = number % 10;
        Console.WriteLine($"Третья цифра вашего числа это {newnumber}");
    }
}

Zadacha2();

void Zadacha3()
{
    Console.WriteLine("_________________________");
    Console.WriteLine("Задача 3");
    Console.WriteLine("Введите число от 1 до 7:");
    int number = Convert.ToInt32(Console.ReadLine());
    int monday = 1;
    int tuesday = 2;
    int wednesday = 3;
    int thutsday = 4;
    int friday = 5;
    int saturday = 6;
    int sunday = 7;
    if (number == 1) Console.WriteLine("Понедельник - рабочий день");
    else if (number == 2) Console.WriteLine("Вторник - рабочий день");
    else if (number == 3) Console.WriteLine("Среда - рабочий день");
    else if (number == 4) Console.WriteLine("Четверг - рабочий день");
    else if (number == 5) Console.WriteLine("Пятница - рабочий день");
    else if (number == 6) Console.WriteLine("Суббота - выходной день! Ура!");
    else if (number == 7) Console.WriteLine("Воскресенье - выходной день! Ура!");

}
Zadacha3();
