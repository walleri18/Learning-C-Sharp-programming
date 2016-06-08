using System;

namespace HomeworkOne_number_5_
{
    class MainProgramm
    {
        static void Main(string[] args)
        {
            // Сколько зарабатывает пользователь за месяц
            Console.Write("Введите пожалуйста сколько " +
                "Вы зарабатываете за месяц: ");
            double monthMoney = double.Parse(Console.ReadLine());

            // Вычисляем сколько зарабатывает за год, неделю, сутки, час, миниту
            double yearMoney = monthMoney * 12;
            double weekMoney = monthMoney / 4;
            double dayMoney = monthMoney / 30;
            double hourMoney = dayMoney / 24;
            double minuteMoney = hourMoney / 60;
            double secondMoney = minuteMoney / 60;

            // Вывод результата
            Console.WriteLine("\nВы зарабатываете:\n" +
                "В год - " + yearMoney + "\n" +
                "В месяц - " + monthMoney + "\n" +
                "В неделю - " + weekMoney + "\n" +
                "В сутки - " + dayMoney + "\n" +
                "В час - " + hourMoney + "\n" +
                "В миниту - " + minuteMoney + "\n" +
                "В секунду - " + secondMoney + "\n");
        }
    }
}
