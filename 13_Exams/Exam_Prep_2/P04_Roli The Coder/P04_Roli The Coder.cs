using System;
using System.Collections.Generic;
using System.Linq;


namespace P04_Roli_The_Coder
{
    class P04_Roli_The_Coder
    {
        class Event
        {
            public string Name { get; set; }
            public List<string> Participants { get; set; }

        }
        static void Main()
        {

            var input = Console.ReadLine();

            var eventList = new Dictionary<string, Event>();

            while (input != "Time for Code")
            {
                var tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string eventName;

                var eventId = tokens[0];

                if (tokens[1].StartsWith("#"))
                {
                    eventName = tokens[1].Substring(1);
                }
                else
                {
                    input = Console.ReadLine();
                    continue;
                }

                var participantList = new List<string>();

                for (int i = 2; i < tokens.Length; i++)
                {
                    if (!participantList.Contains(tokens[i]))
                    {

                        participantList.Add(tokens[i]);

                    }
                }

                Event currentEvent = new Event();
                currentEvent.Name = eventName;
                currentEvent.Participants = participantList;


                if (!eventList.ContainsKey(eventId))
                {
                    eventList.Add(eventId, currentEvent);
                }

                else if (eventList[eventId].Name == eventName)
                {
                    foreach (var person in currentEvent.Participants)
                    {
                        if (!eventList[eventId].Participants.Contains(person))
                        {
                            eventList[eventId].Participants.Add(person);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var id in eventList.OrderByDescending(x => x.Value.Participants.Count).ThenBy(x => x.Value.Name))
            {
                Console.WriteLine($"{id.Value.Name} - {id.Value.Participants.Count}");

                foreach (var person in id.Value.Participants.OrderBy(x => x))
                {
                    Console.WriteLine($"{person}");
                }
            }

        }
    }
}
