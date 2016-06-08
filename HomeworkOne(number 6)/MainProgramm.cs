using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkOne_number_6_
{
    class MainProgramm
    {
        static void Main(string[] args)
        {
            // Константа зарплаты в месяц (в условных денежных еденицах)


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
            Console.WriteLine("Вы пили кофе " + ts.Minutes + " мин. " + ts.Seconds + " сек.");
            Console.ReadKey();
        }
    }
}
