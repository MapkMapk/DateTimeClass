using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeLib
{
    /// <summary>
    /// 
    /// //Создать метод PrevDate()  определяющий дату предыдущего дня. Метод имеет входящий параметр DateTime 
    //Создать метод NextDate() определяющий дату следующего дня. Метод имеет входящий параметр DateTime
    //Создать метод DaysUntilEndMonth(), который позволяет определить сколько дней осталось до конца месяца. Метод имеет входящий параметр DateTime
    //Создать метод LeapYearCheck() , который позволяет определить является ли год високосным
    //Создать метод FindDate(), который позволяет определить дату i-того по счету дня относительно установленной даты (при отрицательных значениях индекса отсчет ведется в обратном порядке). Метод имеет два входящих параметра:  дата относительно которой выполняется поиск, целое значение - число дней, которые необходимо отсчитать от указанной даты
    //Создать метод NextDayOfMonth(), который возвращает значение true, если установленная дата не является последним днем месяца, иначе false;
    //Создать метод FirstDayOdYear(), который выдает значение true, если установленная дата является началом года, иначе false;
    /// </summary>
    public class DateTimeClass
    {
            /// <summary>
            /// метод определяет является ли входящая дата корректной
            /// </summary>
            /// <param name="date">дата</param>
            /// <returns>является ли дата корректной</returns>
            public static bool CorrectDate(string date) 
            {
            DateTime dt = new DateTime();
            if (DateTime.TryParse(date, out dt) == false) {return false; }
            else { return true; }
            }
            /// <summary>
            /// метод определяет дату предыдущего дня.
            /// </summary>
            /// <param name="date">дата</param>
            /// <returns>дату вчерашнего дня</returns>
            public static DateTime PrevDate(DateTime date)
            {
                DateTime dayBefore = new DateTime();
                if (CorrectDate(Convert.ToString(date)))
                {
                    dayBefore = date.AddDays(-1);
                    
                }
                return dayBefore;
            }
            /// <summary>
            /// метод определяет дату следующего дня
            /// </summary>
            /// <param name="date">дата</param>
            /// <returns>дата следующего дня</returns>
            public static DateTime NextDate(DateTime date)
            {   
                DateTime dayBefore = new DateTime();
                if (CorrectDate(Convert.ToString(date)))
                {
                    dayBefore = date.AddDays(+1);
                    
                }
                return dayBefore;
            }
            /// <summary>
            /// вычисление кол-ва дней до конца месяца
            /// </summary>
            /// <param name="date">дата</param>
            /// <returns></returns>
            public static int DaysUntilEndMonth(DateTime date)
            {
            int daysInMonth = 0;
                if (CorrectDate(date.ToShortDateString()))
                {
                    daysInMonth = System.DateTime.DaysInMonth(date.Year, date.Month) - date.Day;

                }
            return daysInMonth;


            }



    }
}
