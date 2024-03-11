using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;



namespace ForCodingChallenges.HackerRank
{
    public class HackerRank_EventManagement
    {
        // This solution works in some testcases, i had not opportunity to debug it yet.

        interface IPerson
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        interface IEventInfo
        {
            public string EventName { get; set; }
            public DateOnly EventDate { get; set; }
            public int Capacity { get; set; }
            public bool Canceled { get; set; }
            public List<IPerson> Registrations { get; set; }
            public List<IPerson> Attendees { get; set; }
            void Register(IPerson person);
            void Attend(IPerson person);

        }
        interface IEventManager
        {
            public List<IEventInfo> Events { get; set; }
            void AddEvent(IEventInfo eventInfo);
            void Register(string eventName, IPerson person);
            void Attend(string eventName, IPerson person);
            List<string> GetEventCountByYears();
            List<string> GetEventRegistrationCountByYears();
            List<string> GetEventAttendeesCountByYears();
        }

        /*
         * Create Person, EventInfo and EventManager classes
         */
        class Person : IPerson
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            //constructor
            public Person(string firstname, string lastname)
            {
                FirstName = firstname;
                LastName = lastname;
            }
        }

        class EventInfo : IEventInfo
        {

            public string EventName { get; set; }
            public DateOnly EventDate { get; set; }
            public int Capacity { get; set; }
            public bool Canceled { get; set; }

            public List<IPerson> Registrations { get; set; }
            public List<IPerson> Attendees { get; set; }

            public EventInfo(string eventname, DateOnly eventdate, int capacity, bool canceled)
            {

                EventName = eventname;
                EventDate = eventdate;
                Capacity = capacity;
                Canceled = canceled;
                Registrations = new List<IPerson>();
                Attendees = new List<IPerson>();
            }

            public void Register(IPerson person)
            {
                if (!Canceled && !Registrations.Contains(person) && Registrations.Count() < Capacity)
                {
                    Registrations.Add(person);
                }
            }

            public void Attend(IPerson person)
            {
                if (!Canceled && Registrations.Contains(person) && !Attendees.Contains(person))
                {
                    Attendees.Add(person);
                }
            }
        }


        //sorry i had to speak with with postal employee!.


        class EventManager : IEventManager
        {
            public List<IEventInfo> Events { get; set; }

            public EventManager(List<IEventInfo> ievents)
            {
                Events = ievents;
            }


            public void AddEvent(IEventInfo eventInfo)
            {
                if (!Events.Contains(eventInfo))
                {
                    Events.Add(eventInfo);
                }
            }
            public void Register(string eventName, IPerson person)
            {
                foreach (var tmpEvent in Events)
                {
                    if (tmpEvent.EventName == eventName )
                    {
                        tmpEvent.Register(person);
                        break;
                    }
                }
            }
            public void Attend(string eventName, IPerson person)
            {
                foreach (var tmpEvent in Events)
                {
                    if (tmpEvent.EventName == eventName)
                    {
                        tmpEvent.Attend(person);
                        break;
                    }

                }

            }
            public List<string> GetEventCountByYears()
            {
                List<string> l = new List<string>();
                var gevents = Events.GroupBy(x => x.EventDate.Year)
                                .Select(x => new { Year = x.Key, Count = x.ToList().Count() })
                                .ToList();
                foreach (var e in gevents)
                {
                    l.Add(e.Year + " - " + e.Count.ToString());

                }
                l.Sort();
                return l;
            }
            public List<string> GetEventRegistrationCountByYears()
            {
                List<string> l = new List<string>();
                var gevents = Events.GroupBy(x => new { x.EventDate.Year })
                                .Select(x => new {
                                    Year = x.Key.Year,
                                    Regis = x.Sum( n=>  n.Registrations.Count())
                                })
                                .ToList();

                foreach(var item in gevents)
                {
                        l.Add ($"{item.Year} - {item.Regis.ToString()}");

                }
                l.Sort();
                return l;
            }
            public List<string> GetEventAttendeesCountByYears()
            {
                List<string> l = new List<string>();

                var gevents = Events.GroupBy(x => new { x.EventDate.Year })
                                    .Select(x => new {
                                        Year = x.Key.Year,
                                        Attendees = x.Sum(n => n.Attendees.Count())
                                    })
                                    .ToList();

                foreach(var item in gevents)
                {
                        l.Add ($"{item.Year} - {item.Attendees.ToString()}");

                }
                l.Sort();
                return l;
            }

        }


        public void TestAPISolution()
        {
            Console.WriteLine("Please copy all the entire Case to Test:");
            List<IPerson> persons = new List<IPerson>();
            List<IEventInfo> events = new List<IEventInfo>();
            EventManager evtM = new EventManager(events);

            int n = Convert.ToInt32(Console.ReadLine().Trim());
            for (int i = 1; i <= n; i++)
            {
                var a = Console.ReadLine().Trim().Split(" ");
                persons.Add(new Person(a[0], a[1]));
            }

            int m = Convert.ToInt32(Console.ReadLine().Trim());
            for (int i = 1; i <= m; i++)
            {
                var a = Console.ReadLine().Trim().Split(" ");
                events.Add(new EventInfo(a[0],
                            //date part
                            new DateOnly(Convert.ToInt32(a[1].Split('.')[0]), Convert.ToInt32(a[1].Split('.')[1]), Convert.ToInt32(a[1].Split('.')[2])),
                            // capacity
                            Convert.ToInt32(a[2]),
                            //canceled
                            a[3] == "1" ? true : false));
            }

            foreach (var item in events)
            {
                evtM.AddEvent(item);
            }

            int p = Convert.ToInt32(Console.ReadLine().Trim());
            for (int i = 1; i <= p; i++)
            {
                var a = Console.ReadLine().Trim().Split(" ");
                if (a[0] == "1")
                {
                    evtM.Register(events[Convert.ToInt32(a[2])].EventName, persons[Convert.ToInt32(a[1])]);
                }
                else if (a[0] == "2")
                {
                    evtM.Attend(events[Convert.ToInt32(a[2])].EventName, persons[Convert.ToInt32(a[1])]);
                }
            }
            var yy = evtM.GetEventCountByYears();
            var b = evtM.GetEventRegistrationCountByYears();
            var c = evtM.GetEventAttendeesCountByYears();
            Console.WriteLine("Event Count:");
            foreach (var item in yy)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Registrations:");
            foreach (var item in b)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Attendees:");
            foreach (var item in c)
            {
                Console.WriteLine(item);
            }

        }
      
    }
}
