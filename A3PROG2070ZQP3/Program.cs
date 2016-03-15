//Ziming Qi 6934525
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3PROG2070ZQ
{
    class Program
    {
        static void Main(string[] args)
        {

            bool chosen = false;//whether user chose something in the menu
            bool doubleCorrect = false;//if the double input is correct
            bool unitCorrect = false;//if the unit input is correct
            string chosenString;//the chosen option
            double value = 1;//the initial value for the value
            string convertFrom;
            string convertTo;
            double result = 1;//the initial value for result
            do
            {
                Console.WriteLine("Please chooose one of the following\n1.Start the conversion\n2.Exit");//the main menu
                chosenString = Console.ReadLine();
                if (chosenString == "1")//first option, go in to conver string
                {
                    doubleCorrect = false;//initialize the booleans
                    unitCorrect = false;
                    do//read length input
                    {
                        try
                        {
                            Console.WriteLine("Please enter the length.");
                            value = double.Parse(Console.ReadLine());
                            doubleCorrect = true;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("that's not a integer! try again!");
                            doubleCorrect = false;
                        }
                    }
                    while (!doubleCorrect);

                    do//read unit input & convert
                    {
                        try
                        {
                            Console.WriteLine("Please enter the unit to convert from");
                            convertFrom = Console.ReadLine();
                            Console.WriteLine("Please enter the unit to convert to");
                            convertTo = Console.ReadLine();
                            result = UnitConversion.Convert(value, convertFrom, convertTo);
                            unitCorrect = true;
                        }
                        catch (ArgumentException)
                        {
                            Console.WriteLine("At least one of the unit is not correct. Please try again");
                            unitCorrect = false;
                        }
                    }
                    while (!unitCorrect);


                    Console.WriteLine("The result is " + result + "\n--------------------------------------------------------------------------------------------");

                }
                else if (chosenString == "2")
                {
                    Environment.Exit(0);//second option quit
                }
                else
                {
                    Console.WriteLine("Please only choose 1 or 2, try again!\n--------------------------------------------------------------------------------------------------");
                }
            }
            while (!chosen);
        }
    }
}
