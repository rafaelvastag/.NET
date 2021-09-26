using StringBuilderApp.Entities;
using System;

namespace StringBuilderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's nice!!");
            Post p1 = new Post(DateTime.Parse("21/09/2020 13:05:33"), "Traveling to New Zealand",
                "I'm going to visit this wonderful country", 12);
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("I need sleep now");
            Comment c4 = new Comment("May the Force be with you");
            Post p2 = new Post(DateTime.Parse("28/07/2021 18:12:19"), "Good night guys",
                "See you tomorrow morning", 12);
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
