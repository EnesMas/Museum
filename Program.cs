using System;

namespace museum1976
{
    class Program
    {
        static void Main(string[] args)
        {

/*             while (true)
            {
                
            
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("Rum 1");
                    break;
                case "2":
                    Console.WriteLine("Rum 2");
                    break;
                case "3":
                    Console.WriteLine("Rum 3");
                    break;
                case "4":
                    Console.WriteLine("Rum 4");
                    break;
                case "5":
                    Console.WriteLine("Rum 5");
                    break;
                case "6":
                    Console.WriteLine("Rum 6");
                    break;
                case "7":
                    Console.WriteLine("Rum 7");
                    break;

                case "q":
                    Console.WriteLine("Du skrev Q");
                    break;

                default:
                    Console.WriteLine("Du skrev något annat");
                    break;
            }

            } */
       

          int mueseumHall = 0;
          int Position_x = 20;
          int Position_y = 7;
          bool avslutaSpelet = true;
            // location info & display
      int x = 0, y = 2; // y is 2 to allow the top row for directions & space
      int dx = 1, dy = 0;
      int consoleWidthLimit = 79;
      int consoleHeightLimit = 24;

          Console.WriteLine("Du är inne på ett museum, rör dig fram med hjäp av tagentbordet. \nW = Framåt. \nS = Bakåt. \nD = Höger. \nA = Vänster. ");
          

          while (true)
          {
              
          
          Console.WriteLine("Använd tagenterna W/S/A/D, avsluta rundturen med 'Q'");
          string input = Console.ReadLine().ToLower();


do // until escape
      {
         // print directions at top, then restore position
         // save then restore current color

         
        
         Console.SetCursorPosition(x, y);

 
         // see if a key has been pressed
         if (input)
         {
            // get key and use it to set options
            consoleKey = Console.ReadKey(true);
            switch (consoleKey.Key)
            {
               
               case "w": //UP
                  Position_x = 0;
                  Position_y = -1;
                  break;
               case "s": // DOWN
                  Position_x = 0;
                  Position_y = 1;
                  break;
               case "a": //LEFT
                  Position_x = -1;
                  Position_y = 0;
                  break;
               case "d": //RIGHT
                  Position_x = 1;
                  Position_y = 0;
                  Console.ForegroundColor = ConsoleColor.Black;
                  break;
               case "q": //END
                  gameLive = false;
                  break;
            }
         }
 
         // find the current position in the console grid & erase the character there if don't want to see the trail
         Console.SetCursorPosition(x, y);
         if (trail == false)
            Console.Write(' ');
 
         // calculate the new position
         // note x set to 0 because we use the whole width, but y set to 1 because we use top row for instructions
         x += dx;
         if (x > consoleWidthLimit)
            x = 0;
         if (x < 0)
            x = consoleWidthLimit;
 
         y += dy;
         if (y > consoleHeightLimit)
            y = 2; // 2 due to top spaces used for directions
         if (y < 2)
            y = consoleHeightLimit;
 
         // write the character in the new position
         Console.SetCursorPosition(x, y);
         Console.Write(ch);
 
         // pause to allow eyeballs to keep up
         System.Threading.Thread.Sleep(delayInMillisecs);
 
      } while (avslutaSpelet);













          if (input == "w")
          {
              Position_x++;
			    int newPosition = Position_x ;
                Console.WriteLine("Du har gått " + newPosition + " steg");
          }
          else if (input == "s")
          {
              Position_x--;
			    int newPosition = Position_x ;
                Console.WriteLine("Du har gått " + newPosition + " steg bakåt");
          }
          else if (input == "d")
          {
              Position_y++;
			    int newPosition = Position_y ;
                Console.WriteLine("Du har gått " + newPosition + " steg åt höger");
          }
          else if (input == "a")
          {
              Position_y--;
			    int newPosition = Position_y ;
                Console.WriteLine("Du har gått " + newPosition + " steg åt vänster");
          }
          else if (input == "q")
          {
              
			    Environment.Exit(0);
          }

          else
          {
              Console.WriteLine("Du har tryckt ogiltig knapp!!");
          }


          }

        }
    }
}
