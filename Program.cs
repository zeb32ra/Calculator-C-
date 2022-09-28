int operation_number = 0;
Console.WriteLine("Справка:\r\n" +
        "1. Сложить 2 числа\r\n2. Вычесть первое из второго\r\n3." +
        " Перемножить два числа\r\n4. Разделить первое на второе\r\n5." +
        " Возвести в степень N первое число\r\n6. Найти квадратный корень из числа\r\n7." +
        " Найти 1 процент от числа\r\n8. Найти факториал из числа\r\n9. Выйти из программы\r\n");
while (operation_number != 9)
{
    Console.WriteLine("Введите номер операции");
    operation_number = Convert.ToInt32(Console.ReadLine()); // comment for commit
    if (operation_number == 1) // new commit for comment
    {
        Console.WriteLine("Введите числа для сложения");
        int number1 = Convert.ToInt32(Console.ReadLine());
        int number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(number1 + number2);
    }
    else if (operation_number == 2)
    {
        Console.WriteLine("Введите числа для вычитания");
        int number1 = Convert.ToInt32(Console.ReadLine());
        int number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(number1 - number2);
    }
    else if (operation_number == 3)
    {
        Console.WriteLine("Введите числа для умножения");
        int number1 = Convert.ToInt32(Console.ReadLine());
        int number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(number1 * number2);
    }
    else if (operation_number == 4)
    {
        Console.WriteLine("Введите числа для деления");
        double number1 = Convert.ToDouble(Console.ReadLine());
        double number2 = Convert.ToDouble(Console.ReadLine());
        if (number2 == 0)
        {
            Console.WriteLine("Нельзя делить на 0");
        }
        else
        {
            Console.WriteLine(number1 / number2); 
        }
    }
    else if (operation_number == 5)
    {
        Console.WriteLine("Введите число и степень, в которую будет возведено число");
        int number1 = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Math.Pow(number1, n));
    }
    else if (operation_number == 6)
    {
        Console.WriteLine("Введите число для извлечения квадратного корня");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Math.Pow(number1, 0.5));
    }
    else if (operation_number == 7)
    {
        Console.WriteLine("Введите числло для нахождение 1% от него");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(0.01 * number1);
    }
    else if (operation_number == 8)
    {
        Console.WriteLine("Введите число для нахождения факториала");
        int number1 = Convert.ToInt32(Console.ReadLine());
        int factorial = 1;
        for (int i = 1; i <= number1; i++)
        {
            factorial *= i;
        }
        Console.WriteLine(factorial);
    }
    else
    {
        break;
    }
}