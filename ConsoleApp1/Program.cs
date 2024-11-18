using System;

class Program
{
    static void Main()
    {
        // Шаг 2: Ввод значений
        Console.Write("Введите значение γ (gamma): ");
        double gamma = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение f: ");
        double f = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        // Шаг 3: Вычисления
        // Операция 1: e^(2*gamma)
        double expValue = Math.Exp(2 * gamma);

        // Операция 2: sin(f)
        double sinValue = Math.Sin(f);

        // Операция 3: 3.8*y + f
        double argumentForLog = 3.8 * y + f;

        // Операция 4: ln(3.8*y + f)
        double logValue = Math.Log(argumentForLog);

        // Шаг 5: Вычисление G
        double G = (expValue + sinValue) / logValue;

        // Шаг 6: Вывод результата
        Console.WriteLine($"Значение G = {G}");
    }
}