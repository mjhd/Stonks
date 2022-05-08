using System;
using System.Timers;
public class Stocks
{
  private static System.Timers.Timer aTimer;

  private static void SetTimer()
   {
        // Create a timer with a two second interval.
        aTimer = new System.Timers.Timer(20000);
        // Hook up the Elapsed event for the timer. 
        aTimer.Elapsed += OnTimedEvent;
        aTimer.AutoReset = true;
        aTimer.Enabled = true;
    }

    private static void OnTimedEvent(Object source, ElapsedEventArgs e)
    {
        Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
                          e.SignalTime);
    }

    public static void Main()
	  {
      SetTimer();
      
      int SValue;
	    Console.WriteLine("STOCK EXCHANGE!");
	    for(int i = 35; i > 0; i++)
	    {
	        Random rnd = new Random();
	        string SSS = "";
	        string SS = "";
	        int delay = rnd.Next(2,6);
	        while(delay != 0)
	        {
	            SS = Char.ConvertFromUtf32(rnd.Next(65,90));
	            SSS = (SSS + SS);
			delay = (delay - 1);
	        }
	        SValue = rnd.Next(1,10000);
	        Console.ForegroundColor = ConsoleColor.Green;
	        Console.WriteLine("Symbol: " + SSS + " | Value: " + SValue + "$ | ↑ |");
	        Console.ForegroundColor = ConsoleColor.White;
	        Console.WriteLine("------------------------------------");
	        i = i - 2;
	    }
	}
}