using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Author - Sam Conneely
//Date - 27.05.21

namespace CA_One
{
    class Program
    {
        static void Main(string[] args)
        {
            //Float will be used as the variable type to allow for decimal points
            //Double is not used as the amount of decimals is too great
            float milesTravelled = GetMiles();
            float gallonsUsed = GetGallons();
;
            //Calling the method Conversion() with two parameters milesTravelled and gallonsUsed,
            //these parameters are returned values from the methods GetMiles() and GetGallons() --- Float data types
            Conversion(milesTravelled, gallonsUsed);

            Console.ReadLine();
        }


        public static float GetMiles()
        {
            //Asking the user for the number of miles travelled
            Console.WriteLine("How many miles have you travelled?");

            //Declaring the variables within the GetMiles() method
            string milesInput = Console.ReadLine();
            bool correctInput = float.TryParse(milesInput, out float milesTravelled);

            //While Loop for ensure correct input type is entered
            //Loop continutes until the value is a float data type
            while (!correctInput)
            {
                //While the correctInput value is not (!) a float data type the user will be asked to input another value
                Console.WriteLine("Invalid input");
                Console.WriteLine("Please enter a valid number of miles");

                //milesInput is now assigned the value of the valid input for miles (float data type)
                milesInput = Console.ReadLine();
                
                //Console.ReadLine input is Parsed from string to float
                correctInput = float.TryParse(milesInput, out milesTravelled);
            }

            //Value of milesTravelled is returned from the GetMiles() method to the Main method
            return milesTravelled;
        }


        public static float GetGallons()
        {
            //Asking for user input
            Console.WriteLine("How many gallons of fuel did you use?");

            //Declaring variables
            string gallonsInput = Console.ReadLine();
            bool correctInput = float.TryParse(gallonsInput, out float gallonsUsed);

            //Starting the While Loop
            while (!correctInput)
            {
                //Returning an invalid message if user input is not correct
                Console.WriteLine("Invalid input");
                Console.WriteLine("Please enter a valid number of gallons");

                gallonsInput = Console.ReadLine();
                correctInput = float.TryParse(gallonsInput, out gallonsUsed);
            }

            //Returning the float value
            return gallonsUsed;
        }

        //The Conversion() method takes in two float values
        public static void Conversion(float milesTravelled, float gallonsUsed)
        {
            //The number miles travelled is divided by the amount of fuel used to return a final calculation for the program
            Console.WriteLine($"You have travelled {milesTravelled / gallonsUsed} miles, per gallon of fuel on your travels");
        }
    }
}
