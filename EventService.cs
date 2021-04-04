//EventService
//	список запланованих(замовлених) заходів, List<Event>
//Методи
//	додавання події до списку подій
//	видалення події
//	очищення списку подій(Clear)
//	пошук(вивід) подій замовлених на певну дату
//	пошук(вивід) подій замовлених на певний діапазон дат(дати можна порівнювати операціями >, <, методом CompareTo)
//	пошук(вивід) подій замовлених певним клієнтом
	

using System;
using System.Collections.Generic;
using System.Text;

namespace S2_HW31._03._21
{
    class EventService 
    {
        List<Event> events = new List<Event>();

        public void AddEvent(Event podiya)
        {
            events.Add(podiya);
        }
        public void DelEvent(Event podiya)
        {
            events.Remove(podiya);
        }
        public void ClearEvents()
        {
            events.Clear();
        }
        public void SearchDate(DateTime date)
        {
            foreach (var item in events)
            {
                if (item.Date == date)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public void SearchPeriod(DateTime start, DateTime finish)
        {
            foreach (var item in events)
            {
                if (item.Date >= start && item.Date <= finish)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public void SearchClient(Client client)
        {
            foreach (var item in events)
            {
                if (item.Client == client)
                {
                    Console.WriteLine(item);
                }
            }
        }

    }
}
