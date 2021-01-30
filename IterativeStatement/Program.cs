using System;

namespace IterativeStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Message shown to user directing them to enter a value
            Console.WriteLine("Enter an integer value between 1 and 100");

            //Try catch used to block users for entering values above 100
            try
            {
                //For loop used to redo the question if vaild answer is given and to show user the times in the loop they are in
                int Value;
                for (Value = 1; Value >= 1; Value++)
                {
                    //Allows user to enter value
                    String ValueInput = Console.ReadLine();

                    //Converts string to interger 
                    int ValueOutput = int.Parse(ValueInput);

                    //If statement used to approve value given for loop
                    if (ValueOutput < 100)
                    {
                        Console.WriteLine("You have entered " + ValueOutput.ToString() + ". This is the current integer value in the loop: " + Value.ToString());
                    }
                    else if (ValueOutput > 100)
                    {
                        Console.WriteLine("Only integer values between 1 and 100 allowed, please exit the program by pressing Enter and try again");
                        Console.ReadKey(true);
                    }
                }
            }
            //Catch tells user to try again with a correct value number 
            catch 
            {
                Console.WriteLine("Press any key to exit the program");
                Console.ReadKey(true);
            }
        }
    }
}
