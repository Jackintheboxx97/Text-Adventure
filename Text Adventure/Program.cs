using System;
using System.Collections.Generic;
using System.Threading;
using System.Timers;

namespace Text_Adventure
{
    public static class Program
    {
        
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.Write(@"
___________.__             ________                          __      _____              __________                __          
\__    ___/|  |__   ____   \_____  \  __ __   ____   _______/  |_  _/ ____\___________  \______   \_____    _____/  |_  ______
  |    |   |  |  \_/ __ \   /  / \  \|  |  \_/ __ \ /  ___/\   __\ \   __\/  _ \_  __ \  |     ___/\__  \  /    \   __\/  ___/
  |    |   |   Y  \  ___/  /   \_/.  \  |  /\  ___/ \___ \  |  |    |  | (  <_> )  | \/  |    |     / __ \|   |  \  |  \___ \ 
  |____|   |___|  /\___  > \_____\ \_/____/  \___  >____  > |__|    |__|  \____/|__|     |____|    (____  /___|  /__| /____  >
                \/     \/         \__>           \/     \/                                              \/     \/          \/ 

       ");

       
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            DelayWrite("It is 8:00 am. You have a very important interview at " +
                "10:00 am for a job that you've been trying to get for three years!");
            DelayWrite("You haven't gotten much sleep all night due to high levels of excitement. " +
                "Would you like to keep sleeping? yes/no:");
            string userSays = Console.ReadLine().ToLower();

            if(userSays == "yes")
            {
                DelayWrite("I must warn you, going back to sleep now highly increases your" +
                    " chances of oversleeping and missing your interview." +
                    "Are you sure you want to keep sleeping? yes/no:");
            }            
             if(userSays == "no")
            {
                DelayWrite("I'm glad you're up! I'll give you some time to wash yourself, eat breakfast," +
                    " and grab a cup of coffee.");
                Console.Write("Double tap ENTER to continue");
            }
            Console.ReadKey();              

            string sleepResponse = Console.ReadLine().ToLower();

            if(sleepResponse == "yes")
            {
                Console.WriteLine("You've overslept!");
                Console.Beep();
            }                                 
            else if(sleepResponse == "no")
            {
                DelayWrite("Great! Let's get our day started then! I'll give you some time to wash yourself," +
                    "eat breakfast, and grab a cup of coffee.");
            }
            
            Console.ForegroundColor = ConsoleColor.Green;
            DelayWrite("Now you that you have yourself all cleaned up, let's get your outfit ready." +
                "I've already chosen a pantsuit for you to wear.");
               
            DelayWrite("Uh-Oh! Looks like your pants are missing! You only have 30 minutes left to get dressed!");
            DelayWrite("How about this? I might know where your pants are. " +
                "If you can answer this jokes I'll show you where they are. Ready? yes/no:");
            string readySays = Console.ReadLine().ToLower();
            if(readySays == "yes")
            {
                DelayWrite("Alright! If I have just won the lottery for a million dollars, " +
                    "and I decide to donate a quarter of it to charity, how much do I have left?");
            }
            else if(readySays == "no")
            {
                DelayWrite("Whelp! You're not getting any help finding your pants! Good luck making it to your interview.");
            }
            string answer = Console.ReadLine().ToLower();
            if(answer == "999,999.75")
            {
                DelayWrite("Fine! You win. Here are your pants. Good luck on your interview!");
            }
            else if(answer == "250,000")
            {
                DelayWrite("I can see why you guessed that. But that's not right. Would you like to try again? Redo/No");
            }
            string redoResponse = Console.ReadLine().ToLower();
            if (redoResponse == "Redo")
            {
                DelayWrite("Listen carefully. If I have just won the lottery for a million dollars, " +
                    "and I decide to donate a quarter of it to charity, how much do I have left?");
            }
            else if (redoResponse == "no")
            {
                DelayWrite("Well then, good luck finding your pants.");
            }
            string newAnswer = Console.ReadLine();
            if (newAnswer == "999,999.75")
            {
                DelayWrite("You win. Here your pants. Good luck on your interview.");
            }
            else if (newAnswer == "")
            {
                DelayWrite("You lose! Time is running out. Good luck finding your pants.");
            }
        }

        static void DelayWrite(string text, int charDelay = 50, bool DelayNewLine = true)
        {
            foreach(char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(charDelay);
            }
            if (DelayNewLine) System.Threading.Thread.Sleep(1000);
            Console.Write(Environment.NewLine);

            
            
        }
    }
}
