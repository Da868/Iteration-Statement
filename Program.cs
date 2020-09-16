using System;

namespace Iteration_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user to input information
            Console.Write("Enter and Interger value between 1 and 25:");

            try
            {
                // This variable is will gather data from the user input
                string input = Console.ReadLine();
                // This variablw will be used to perform the iteration in the while loop and is a parsed as integer
                int value_of_input = int.Parse(input);

                // The user will need to choose an input between 1 and 25
                if((value_of_input >= 1) && (value_of_input <= 25))
                {
                    Console.WriteLine("Executing a While Loop");
                    Console.WriteLine("The While Loop will iterate From" + " " + value_of_input.ToString(input)  + " " + " to 25");
                    //This is the start of the While Loop
                    while(( value_of_input > 0) && (value_of_input <=25))
                    {
                        Console.WriteLine("You have entered" + " " + value_of_input.ToString(input) + " " + "." + "This is the current interger value in the loop:" + value_of_input.ToString());value_of_input++;
                   
                
                    }
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);

                }
                else  // To make sure the user enter the information as requested
                {
                    Console.WriteLine("Please enter a interger between 1 and 25 and try again...");
                    Console.WriteLine("Press any key to exit the program and try again....");
                    Console.ReadKey(true);
                }
            } // End of try
            catch  // To ensure the program is caught and avoids build errors. 
            {
                Console.WriteLine("Please enter an interger value and try running the program again....");
                Console.WriteLine("Press any key  to exit the program ....");
                Console.ReadKey(true);
                
            } // End of catch
        } // End of Main
    } // End of class
} // End of namespace
