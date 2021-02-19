using System;
using System.Collections.Generic;

namespace Bowling {
    class Program {
        static int bowl1Game(Random rnd) { // creating a new method here
            var game = new List<int>(10);
            for (var idx = 0; idx < 10; idx++) {
                var score = rnd.Next(0, 31);
                game.Add(score);
            }
            var total = 0;
            foreach (var score in game) {
                total += score;
            }
            Console.WriteLine($"bowling score is {total}");
            return total;
        }


        static void Main(string[] args) {
            //creating a randomly generated number here// how we were suppose to do this correctly in class, down below is my attempt.
            var rnd = new Random();
            var series = 0; // added to see the total of all games
            for (var idx = 0; idx < 3; idx++){ // this can create more than 1 games score, right now it will display 3 scores rather then 1
                   var score = bowl1Game(rnd); // this was added to to pass this to our new method up above 
                    series += score; // added to see the total of all games
            }
            Console.WriteLine($"Series score is {series}"); // added to see the total of all games

            // var game = new List<int>(10);

            //for (var idx = 0; idx < 10; idx++) {
            //    var score = rnd.Next(0, 31);
            //    game.Add(score);
            //}

            //var total = 0;
            //foreach(var score in game) {
            //    total += score;
            //}
            // Console.WriteLine($"bowling score is {total}"); // we just made a random score generator for the game of bowling this is the score for a single game




            // // my attempt at making this I misunderstood what we were doing or what he was asking 
            //var points = new List<int>();
            //points.Add(10);
            //points.Add(20);
            //points.Add(30);
            //points.Add(35);
            //points.Add(40);
            //points.Add(45);
            //points.Add(50);
            //points.Add(55);

            //for(var idx = 0; idx <= 10; idx++) {
            //    var rnd = new Random();
            //    var nbr = rnd.Next(0, 56);
            //    points.Add(nbr);

            //};
            //foreach()
        }
    }
}
