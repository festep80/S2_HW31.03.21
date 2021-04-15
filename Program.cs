using System;
using System.Collections.Generic;

namespace S2_HW31._03._21
{
    class Program
        
    {
        enum EventAgency { Exit, Clients, Events }
        enum Clients { Return, New, Find, Show }
        enum Events { Return, New, Find, Show, }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=====Event Agency=====");
                Console.WriteLine("1.Clients");
                Console.WriteLine("2.Events");
                Console.WriteLine("0.Exit");
                Console.Write("-> ");
                EventAgency switchEventAgency = (EventAgency)Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (switchEventAgency)
                {
                    case EventAgency.Clients:
                        Clients switchClients = new();
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("======Clients======");
                            Console.WriteLine("1.New client");
                            Console.WriteLine("2.Find client");
                            Console.WriteLine("3.Show clients");
                            Console.WriteLine("0.Return to main menu");
                            Console.Write("->");
                            switchClients = (Clients)Convert.ToInt32(Console.ReadLine());
                            switch (switchClients)
                            {
                                case Clients.Return:
                                    break;
                                case Clients.New:
                                    EventService.NewClient();
                                    break;
                                case Clients.Find:
                                    EventService.FindClient();
                                    break;
                                case Clients.Show:
                                    EventService.ShowClients();                                    
                                    break;
                                default:
                                    Console.WriteLine("Wrong choise!");
                                    Console.ReadKey();
                                    break;
                            }
                        } while (switchClients != Clients.Return);
                        break;
                    case EventAgency.Events:

                    default:
                        break;
                }
            }
            



        }
    }
}
