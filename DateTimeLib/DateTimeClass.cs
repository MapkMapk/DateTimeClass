﻿using System;
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
            /// метод определяет дату предыдущего дня.
            /// </summary>
            /// <param name="date">дата</param>
            /// <returns>дату вчерашнего дня</returns>
            public static DateTime PrevDate(DateTime date)
            {
                DateTime dayBefore = date.AddDays(-1);
                return dayBefore;
            }
        
    

    }
}
