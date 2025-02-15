// ask for user input - name
// new DateTime 
// format into date and time variables 
// make strings for motivational quotes and emojis
// new Random for random index
// Add customized greetings to dictionary 
// make an if statement: 
// morning: 0-12pm
// day: 12-18pm
// evening: after 18pm

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Name?");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Magenta;
        var userName = Convert.ToString(Console.ReadLine());
        Console.ResetColor();

        DateTime today = DateTime.Now;
        var todayDate = today.ToString("dddd dd MMMM");
        var todayTime = today.ToString("hh:mm tt");
        var todayHour = Convert.ToInt32(today.Hour);

        string[] motivational = {
            "You're doing better than you think. Keep going!",
            "Believe in yourself, and you're halfway there.",
            "Small steps lead to big changes. Keep moving forward!",
            "The sky's the limit. Keep reaching higher!",
            "Success is built on consistency. Keep showing up!",
            "You're capable of amazing things!",
            "Don't stop until you're proud!",
            "Every day is a fresh start. Make it count!",
            "You have the power to create your own future!",
            "The best way to predict the future is to create it.",
            "Dream big, work hard, stay focused!",
            "Your potential is limitless. Don't hold back!",
            "Stay positive, work hard, and make it happen!",
            "Great things never come from comfort zones.",
            "Success is not final, failure is not fatal: It’s the courage to continue that counts."
        };

        string[] morningEmojis = { "🌞", "☕️", "🌱", "💪", "🌟" };
        string[] afternoonEmojis = { "⚡️", "🔥", "🚀", "📈", "💪" };
        string[] eveningEmojis = { "🌙", "💤", "🌟", "💪", "😊" };



        var random = new Random();
        var index = random.Next(motivational.Length);
        var indexEmoji = random.Next(morningEmojis.Length);

        Dictionary<string, string> greeting = new Dictionary<string, string>();
        greeting.Add("morning", $"Good Morning, {userName}. {morningEmojis[indexEmoji]}  It's {todayTime}, and the day is {todayDate}. {motivational[index]}");
        greeting.Add("day", $"Good Day, {userName}. {afternoonEmojis[indexEmoji]}  It's {todayTime}, and the day is {todayDate}. {motivational[index]} ");
        greeting.Add("evening", $"Good Evening, {userName}. {eveningEmojis[indexEmoji]}  It's {todayTime}, and the day is {todayDate}. {motivational[index]} ");

        if (todayHour < 12) {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(greeting["morning"]);
            }  else if (todayHour < 18) {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(greeting["day"]);
            } else {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(greeting["evening"]);
            }
    }
}



