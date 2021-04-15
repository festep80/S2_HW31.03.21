using System;
using System.Collections.Generic;

namespace S2_HW31._03._21
{
    class Program
        
    {
        enum EventAgency { Exit, Clients, Events }
        enum Clients { Return, New, Find, Show }
        enum Events { Return, New, Del, DelAll, FindDate, FindPeriod, FindClient }
        static void Main(string[] args)
        {
            EventAgency switchEventAgency = new();
            do
            {
                Console.Clear();
                Console.WriteLine("=====Event Agency=====");
                Console.WriteLine("1.Clients");
                Console.WriteLine("2.Events");
                Console.WriteLine("0.Exit");
                Console.Write("-> ");
                switchEventAgency = (EventAgency)Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (switchEventAgency)
                {
                    case EventAgency.Exit:
                        Console.WriteLine("Goodbye!");
                        Console.ReadKey();
                        break;
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
                        Events switchEvents = new();
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("======Events======");
                            Console.WriteLine("1.New event");
                            Console.WriteLine("2.Delete event");
                            Console.WriteLine("3.Delete all events");
                            Console.WriteLine("4.Find event by date");
                            Console.WriteLine("5.Find event by period");
                            Console.WriteLine("3.Find event by client");
                            Console.WriteLine("0.Return to main menu");
                            Console.Write("-> ");
                            switchEvents = (Events)Convert.ToInt32(Console.ReadLine());
                            switch (switchEvents)
                            {
                                case Events.Return:
                                    break;
                                case Events.New:
                                    EventService.NewEvent();
                                    break;
                                case Events.Del:
                                    EventService.DelEvent();
                                    break;
                                case Events.DelAll:
                                    EventService.ClearEvents();
                                    break;
                                case Events.FindDate:
                                    EventService.FindDate();
                                    break;
                                case Events.FindPeriod:
                                    EventService.FindPeriod();
                                    break;
                                case Events.FindClient:
                                    EventService.FindClientEvents();
                                    break;
                                default:
                                    Console.WriteLine("Wrong choise!");
                                    Console.ReadKey();
                                    break;
                            }

                        } while (switchEvents != Events.Return);
                        break;

                    default:
                        Console.WriteLine("Wrong choise!");
                        Console.ReadKey();
                        break;
                }
            } while (switchEventAgency != EventAgency.Exit);
            



        }
    }
}
