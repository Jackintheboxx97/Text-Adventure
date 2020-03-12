using System;

namespace Text_Adventure
{
   public static class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.Write(@"
__________                       ________
\____    /____   ____   ____    /  _____/
  /     //  _ \ /    \_/ __ \  /   __  \ 
 /     /(  <_> )   |  \  ___/  \  |__\  \
/_______ \____/|___|  /\___  >  \_____  /
        \/          \/     \/         \/ 
");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            DelayWrite("Hey! Are you ok?");
            Console.ReadLine();
            DelayWrite("You don't look like you're from around here. Are you lost?");
            Console.ReadLine();

            
        }
        static void DelayWrite(string text, int charDelay = 75, bool DelayNewLine = true)
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
