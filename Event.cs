//Захід(Event)
//	назва
//	кількість осіб заходу
//	місце проведення
//	час проведення(стандартна структура DateTime)
//	ІД події(автоматично присвоюється 1, 2, 3, ...), формується на основі статичного поля counter
//	counter - статичне поле, що рахує кількість створених екземплярів
//	клієнт(посилання на Клієнта, що замовив захід)
//Методи
//	конструктор(и)
//	перенесення події на певне число днів вперед(метод AddDay структури DateTime)
//https://docs.microsoft.com/en-us/dotnet/api/system.datetime.adddays?view=netframework-4.8
//	перенесення події на певне число тижнів вперед

//Визначити  властивості для полів класу.
//*Перевіряти правильність дати події(не раніше сьогоднішньої), властивості DateTime.Today, DateTime.Now
//Перевизначити(override) метод ToString()
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
    class Event 
    {
        static uint counter = 0;
        DateTime date;
        

        public Event(Client client)
        {
            counter++;
            ID = counter;
            Console.Write("Enter name of event: ");
            Name = Console.ReadLine();
            Console.Write("Enter count of people: ");
            People = Convert.ToUInt32(Console.ReadLine());
            Console.Write("Enter event's place: ");
            Place = Console.ReadLine();
            Console.Write("Enter date of event(mm/dd/yyyy): ");
            Date = DateTime.Parse(Console.ReadLine());
            Client = client;           
        }
        public string Name { get; set; }
        public uint People { get; set; }
        public string Place { get; set; }
        public DateTime Date 
        { 
            get => this.date;
            set 
            {
                if (value < DateTime.Now)
                {
                    this.date = DateTime.Now;
                }
                else
                {
                    this.date = value;
                }
            }
        }
        public uint ID { get; set; }
        public Client Client { get; set; }
        public override string ToString()
        {
            return $"\n{counter}\nName: {Name}\nPeople: {People}\nPlace: {Place}\nDate: {Date}\nClient: {Client.ToString()}";
        }

        public void AddDaysToEvent(int days)
        {
            this.date = date.AddDays(days);
        }
        public void AddWeeksToEvent(int weeks)
        {
            this.date = date.AddDays(weeks * 7);
        }
       
    }
    
}
