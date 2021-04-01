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

using System;
using System.Collections.Generic;
using System.Text;

namespace S2_HW31._03._21
{
    class Event
    {
        string name;
        uint people;
        string place;
        DateTime date;
        static readonly uint counter;

        public Event(string name = "NoName", uint people = 0, string place = "Unknown", DateTime date = default)
        {
            this.Name = name;
            this.People = people;
            this.Place = place;
            if(date==default)
            {
                this.Date = DateTime.Today;
            }
            else
            {
                this.Date = date;
            }
            
        }
        public string Name 
        {
            get => this.name;
            set 
            {
                if(!string.IsNullOrWhiteSpace(value))
                {
                    this.name = value;
                }
                else
                {
                    this.name = "Unknown";
                }
            }
        }
        public uint People { get; set; }
        public string Place { get; set; }
        public DateTime Date 
        { 
            get => this.date;
            set 
            {
                if(Date < DateTime.Now)
                {
                    this.date = default;
                }
            }
        }
        public override string ToString()
        {
            return $"\n{counter}\nName: {Name}\nPeople: {People}\nPlace: {Place}\nDate: {Date}\n";
        }
        
    }
    
}
