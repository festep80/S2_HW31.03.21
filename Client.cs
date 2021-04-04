//Клієнт(Client)
//	ім'я	
//	номер телефону
//Визначити конструктор(и) та властивості для полів класу
//* Перевіряти правильність телефону
//1. Перевизначити(override) метод ToString()	

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace S2_HW31._03._21
{
    class Client
    {
        string name;
        string phone;
        public Client()
        {
            Console.Write("Enter name of client: ");
            Name = Console.ReadLine();
            Console.Write("Enter phone(10 digits): ");
            Phone = Console.ReadLine();
        }
        public string Name 
        { 
            get { return this.name; } 
            set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.name = value;
                }
            }
        }
        public string Phone 
        {
            get { return this.phone; }
            set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.phone = value;
                }
            }
        }

        public override string ToString() => $"Name: {this.Name}\nPhone: {this.Phone}\n";            
    }
}
