/* C# Interactive Program that asks for the input of a name and from 2 options to select how you are feeling */

using System;

namespace Feeling
{
    class Hello
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Hello. Please state your name.");

	        string name = Console.ReadLine();

	        Console.WriteLine("Hello {0} how are you on this fine day? Press 1 for Good or 2 for bad.", name);

	        int result;

	        if (int.TryParse(Console.ReadLine(), out result))

	        {

    	    if (result == 1)

          Console.WriteLine("Well {0} I am glad to hear it, cool!", name);

    	    else if (result == 2)

          Console.WriteLine("Well {0} I am sorry to hear it, that sucks!", name);   
        
    	    else

          Console.WriteLine("Incorrect response");

	        }

	        else

    	    Console.WriteLine("Incorrect response");

	        Console.ReadLine();

        }
    
    }
  
  
}