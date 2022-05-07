using System;
public class Stocks
{
    public static void Main() 
	  {
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
	        Console.WriteLine("Symbol: " + SSS + " | Value: " + SValue + " | ↑ |");
	        
	        Console.WriteLine("-----------------------------------");
	        i = i - 2;
	    }
	}
}