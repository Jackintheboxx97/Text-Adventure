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
                    "Are you sure you want to keep sleeping? Duh/no:");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            string keepSleep = Console.ReadLine().ToLower();
              
            
              if (keepSleep == "duh")
              {
                DelayWrite("You Overslept!");
                Console.Beep();
              }
                
                
            else if (keepSleep == "no")
            {
                DelayWrite("Great! Let's get our day started then! I'll give you some time to wash yourself," +
                    "eat breakfast, and grab a cup of coffee");
            }
            else if(userSays == "no")
            {
                DelayWrite("I'm glad you're up! I'll give you some time to wash yourself, eat breakfast," +
                    " and grab a cup of coffee.");
            }
            
            
            Console.WriteLine();
            DelayWrite("Alright! Now that you're all cleaned up, let's get your outfit ready. I've already chosen a pantsuit for you to wear.");           
            Console.WriteLine();
            DelayWrite("Uh-oh! It looks like your pants are missing. You've only got thirty minutes left to get dressed!");
            Thread.Sleep(200);
            Console.WriteLine();
            Thread.Sleep(200);
            DelayWrite("How about this? I might know where your pants are. If you can answer this joke correctly, I'll help you find them. Ready? yes/no");
            Console.WriteLine();
            string readySays = Console.ReadLine().ToLower();
            if(readySays == "yes")
            {
                DelayWrite("Awesome! Think very carefully about your answer, ok?");
                Console.WriteLine();
                DelayWrite("Ok. Here's the joke: If I have just won the lottery for a million dollars " +
                    "and I decide to donate a quarter of it to charity, how much do I have left?");                   
            }
            else if(readySays == "no")
            {
                DelayWrite("Whelp! You're not getting any help finding your pants! Good luck making it to your interview.");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            string answer = Console.ReadLine().ToLower();
            if(answer == "999,999.75")
            {
                DelayWrite("You're very clever! You win. Here are your pants. Good luck on your interview.");

            }
            else
            {
                DelayWrite("You lose! Good luck finding your pants!");
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
