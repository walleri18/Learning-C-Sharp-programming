using System;

namespace HomeworkOne_number_4_
{
    class MainProgramm
    {
        static void Main(string[] args)
        {
            // Узнаём сколько времни сейчас
            DateTime dateNow = DateTime.Now;

            // Забиваем дату Новго Года
            DateTime dateNewGod = new 
                DateTime(dateNow.Year + 1, 1, 1);

            // Узнаём разницу
            TimeSpan result = dateNewGod - dateNow;

            // Выводим результат
            Console.WriteLine("До Нового " + dateNewGod.Year + 
                " Года" + " осталось: " + result.Days + " дней " 
                + result.Hours + " часов " + result.Minutes 
                + " минут " + result.Seconds + " секунд\n"); 
        }
    }
}
