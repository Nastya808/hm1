using System;

class Program
{
    static void Main()
    {
        // Завдання 1
        string quote = "It's easy to win forgiveness for being wrong; being right is what gets you into real trouble.";
        string author = "Bjarne Stroustrup";
        Console.WriteLine($"{quote} {author}");

        // Завдання 2
        Console.WriteLine("Введіть п'ять чисел:");
        double sum = 0;
        double min = double.MaxValue;
        double max = double.MinValue;
        double product = 1;

        for (int i = 0; i < 5; i++)
        {
            double num = double.Parse(Console.ReadLine());
            sum += num;
            if (num < min) min = num;
            if (num > max) max = num;
            product *= num;
        }

        Console.WriteLine($"Сума: {sum}");
        Console.WriteLine($"Мінімум: {min}");
        Console.WriteLine($"Максимум: {max}");
        Console.WriteLine($"Добуток: {product}");

        // Завдання 3
        Console.WriteLine("Введіть шестизначне число:");
        int number = int.Parse(Console.ReadLine());
        int reversedNumber = 0;

        while (number > 0)
        {
            int digit = number % 10;
            reversedNumber = reversedNumber * 10 + digit;
            number /= 10;
        }

        Console.WriteLine($"Результат: {reversedNumber}");

        // Завдання 4
        Console.WriteLine("Введіть початкове та кінцеве значення діапазону:");
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        int a = 0, b = 1, c;
        while (a <= end)
        {
            if (a >= start)
                Console.WriteLine(a);
            c = a + b;
            a = b;
            b = c;
        }

        // Завдання 5
        Console.WriteLine("Введіть два цілих числа (A < B):");
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());

        for (int i = A; i <= B; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }

        // Завдання 6
        Console.WriteLine("Введіть довжину лінії:");
        int length = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть символ заповнювач:");
        char fillChar = char.Parse(Console.ReadLine());

        Console.WriteLine("Введіть напрямок (горизонтальна або вертикальна):");
        string direction = Console.ReadLine();

        if (direction == "горизонтальна")
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(fillChar);
            }
        }
        else if (direction == "вертикальна")
        {
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(fillChar);
            }
        }
        else
        {
            Console.WriteLine("Невірний напрямок.");
        }
    }
}
