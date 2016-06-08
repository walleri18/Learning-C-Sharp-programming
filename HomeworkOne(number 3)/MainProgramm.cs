using System;

namespace HomeworkOne_number_3_
{
    class MainProgramm
    {
        static void Main(string[] args)
        {
            // Буферная переменная
            string tmpVar;

            // Переменные для хранения операндов (целочисленные)
            int oneArgumentInt, twoArgumentInt;

            // Переменные для хранения операндов (вещественные)
            double oneArgumentDouble, twoArgumentDouble;

            Console.WriteLine("Калькулятор\n");

            // Приём целочисленных аргументов
            Console.WriteLine("Приём целочисленных аргументов:");

            Console.Write("Первый аргумент = ");
            tmpVar = Console.ReadLine();
            oneArgumentInt = int.Parse(tmpVar);

            Console.Write("Второй аргумент (ноль вводить нельзя) = ");
            tmpVar = Console.ReadLine();
            twoArgumentInt = int.Parse(tmpVar);

            // Приём вещественных аргументов
            Console.WriteLine("\n\nПриём вещественных аргументов:");

            Console.Write("Первый аргумент = ");
            tmpVar = Console.ReadLine();
            oneArgumentDouble = double.Parse(tmpVar);

            Console.Write("Второй аргумент (ноль вводить нельзя) = ");
            tmpVar = Console.ReadLine();
            twoArgumentDouble = double.Parse(tmpVar);

            // Подсчёт и вывод
            Console.WriteLine("Целочисленный результат:");
            Console.WriteLine("1. " + oneArgumentInt + " + " + 
                twoArgumentInt + " = " + 
                (oneArgumentInt + twoArgumentInt));
            Console.WriteLine("2. " + oneArgumentInt + " - " +
                twoArgumentInt + " = " +
                (oneArgumentInt - twoArgumentInt));
            Console.WriteLine("3. " + oneArgumentInt + " * " +
                twoArgumentInt + " = " +
                (oneArgumentInt * twoArgumentInt));
            Console.WriteLine("4. " + oneArgumentInt + " / " +
                twoArgumentInt + " = " +
                (oneArgumentInt / twoArgumentInt));
            Console.WriteLine("5. " + oneArgumentInt + " % " +
                twoArgumentInt + " = " +
                (oneArgumentInt % twoArgumentInt));
            Console.WriteLine("6. " + oneArgumentInt + " == " +
                twoArgumentInt + " = " +
                (oneArgumentInt == twoArgumentInt));

            Console.WriteLine("\nЦелочисленный результат:");
            Console.WriteLine("1. " + oneArgumentDouble + " + " +
                twoArgumentDouble + " = " +
                (oneArgumentDouble + twoArgumentDouble));
            Console.WriteLine("2. " + oneArgumentDouble + " - " +
                twoArgumentDouble + " = " +
                (oneArgumentDouble - twoArgumentDouble));
            Console.WriteLine("3. " + oneArgumentDouble + " * " +
                twoArgumentDouble + " = " +
                (oneArgumentDouble * twoArgumentDouble));
            Console.WriteLine("4. " + oneArgumentDouble + " / " +
                twoArgumentDouble + " = " +
                (oneArgumentDouble / twoArgumentDouble));
            Console.WriteLine("5. " + oneArgumentDouble + " % " +
                twoArgumentDouble + " = " +
                (oneArgumentDouble % twoArgumentDouble));
            Console.WriteLine("6. " + oneArgumentDouble + " == " +
                twoArgumentDouble + " = " +
                (oneArgumentDouble == twoArgumentDouble));
            Console.WriteLine();
        }
    }
}
