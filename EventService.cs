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
                events.Add(_event);
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
        public static void NewEvent()
        {
            Console.Write("Enter phone: ");
            Event _event = new(clients.Find(x => x.Phone.Contains(Console.ReadLine())));
            events.Add(_event);
        }
        public static void DelEvent()
        {
            Console.Write("Enter event name: ");            
            events.Remove(events.Find(x => x.Name.Contains(Console.ReadLine())));
        }
        public static void ClearEvents()
        {
            events.Clear();
        }
        public static void FindDate()
        {
            Console.Write("Enter date (mm/dd/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            foreach (var item in events)
            {
                if (item.Date == date)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
        public static void FindPeriod()
        {
            Console.Write("Enter start (mm/dd/yyyy): ");
            DateTime start = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter finish (mm/dd/yyyy): ");
            DateTime finish = DateTime.Parse(Console.ReadLine());
            foreach (var item in events)
            {
                if (item.Date >= start && item.Date <= finish)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
        public static void FindClientEvents()
        {
            Console.Write("Enter phone: ");
            Client client = clients.Find(x => x.Phone.Contains(Console.ReadLine()));
            foreach (var item in events)
            {
                if(item.Client == client)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
        
    }
}
