using System;

namespace HomeworkOne_number_6_
{
    class MainProgramm
    {
        static void Main(string[] args)
        {
            // Константа зарплаты в месяц (в условных денежных еденицах)
            const double monthMoney = 1400;

            // Вычисляем сколько зарабатывает сутки
            double dayMoney = monthMoney / 30;

            // Ждем, когда пользователь пойдет пить кофе.
            Console.WriteLine("Нажмите клавишу, когда пойдете пить кофе...");
            Console.ReadKey();

            // Пошел, засекаем время.
            DateTime start = DateTime.Now;
            Console.WriteLine("Нажмите клавишу, когда вернетесь...");
            Console.ReadKey();

            // Вернулся, как долго его не было?
            DateTime end = DateTime.Now;
            TimeSpan ts = end - start;
            Console.WriteLine("Вы пили кофе " + ts.Days + " дней " + ts.Hours + " часов " + ts.Minutes + " минут " + ts.Seconds + " секунд " + ts.Milliseconds + " миллисекунд ");

            // Сколько начальник должен вам заплатить за ваш перерыв
            Console.WriteLine("Начальник должен Вам заплатить за это время: " + (ts.TotalDays * dayMoney) + " условных денежных едениц");
        }
    }
}
