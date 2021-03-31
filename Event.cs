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
        
    }
}
