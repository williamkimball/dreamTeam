using System;
using System.Collections.Generic;


namespace dreamteam

{
    class Program
    {
        static void Main(string[] args)
        {
            Teammate Sathvik = new Teammate(){
                FirstName = "Sathvik",
                LastName = "Reddy",
                Speciality = "Graphs",
                WorkMessage = "I'll make a graph from some data. Is this funny? No? No is the answer."
            };
            Teammate Robert = new Teammate(){
                FirstName = "Robert",
                LastName = "Leedy",
                Speciality = "FontAwesome",
                WorkMessage = "I figured out FontAwesome when Will just gave up."
            };
            Teammate Leah = new Teammate(){
                FirstName = "Leah",
                LastName = "Gwin",
                Speciality = "Networking",
                WorkMessage = "I'm on point with my LinkedIn game."
            };
            Teammate Natasha = new Teammate(){
                FirstName = "Natasha",
                LastName = "Cox",
                Speciality = "React",
                WorkMessage = "State is great."
            };
            Teammate Seth = new Teammate(){
                FirstName = "Seth",
                LastName = "Dana",
                Speciality = "CSS",
                WorkMessage = "I like CSS."
            };

           List<Teammate> ClientSide = new List<Teammate>();
           List<Teammate> ServerSide = new List<Teammate>();

           ClientSide.Add(Seth);
           ClientSide.Add(Leah);

           ServerSide.Add(Natasha);
           ServerSide.Add(Robert);
           ServerSide.Add(Sathvik);

            foreach (var Person in ClientSide)
            {
                System.Console.WriteLine(Person.Work());
                
            }
            foreach (var Person in ServerSide)
            {
                System.Console.WriteLine(Person.Work());
                
            }
        }
    }
}
