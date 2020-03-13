using System;
using System.Collections.Generic;
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
            DelayWrite("It is 7:00 am. You have a very important interview at " +
                "10:00 am for a job that you've been trying to get for three years!");
            DelayWrite("You haven't gotten much sleep all night due to high levels of excitement. " +
                "Would you like to keep sleeping? yes/no");
            string userSays = Console.ReadLine().ToLower();
            if(userSays == "yes")
            {

            }
        }
        static void DelayWrite(string text, int charDelay = 100, bool DelayNewLine = true)
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
