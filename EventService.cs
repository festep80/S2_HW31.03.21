using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_HW31._03._21
{
    static class EventService
    {
        public static List<Event> events = new();
        public static List<Client> clients = new();

        public static void NewClient()
        {
            Client client = new();
            clients.Add(client);
            Console.WriteLine("To add  a new event with this client, please enter (y): "); 
            if(Console.ReadLine() == "y")
            {
                Event _event = new(client);
                AddEvent(_event);
            }
        }

        public static void FindClient()
        {
            Console.Clear();
            if (clients.Any()==true)
            {
                Console.Write("Enter phone: ");
                Console.WriteLine(clients.Find(x => x.Phone.Contains(Console.ReadLine())).ToString()); 
            }
            else
            {
                Console.WriteLine("There are no clients in the database.");
            }
            Console.ReadKey();
        }

        public static void ShowClients()
        {
            Console.Clear();
            if (clients.Any() == true)
            {
                Console.WriteLine("========Clients========");
                foreach (var item in clients)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                Console.WriteLine("There are no clients in the database.");
            }   
            Console.ReadKey();
        }
        public static void AddEvent(Event _event)
        {
            events.Add(_event);
        }
        public static void DelEvent(Event _event)
        {
            events.Remove(_event);
        }
        public static void ClearEvents()
        {
            events.Clear();
        }
        public static void SearchDate(DateTime date)
        {
            foreach (var item in events)
            {
                if (item.Date == date)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public static void SearchPeriod(DateTime start, DateTime finish)
        {
            foreach (var item in events)
            {
                if (item.Date >= start && item.Date <= finish)
                {
                    Console.WriteLine(item);
                }
            }
        }
        
    }
}
