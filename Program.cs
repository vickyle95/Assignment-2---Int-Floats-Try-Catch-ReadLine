using System.Transactions;
using static System.Formats.Asn1.AsnWriter;

namespace Assignment_2___Int__Floats__Try_Catch__ReadLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Name: Vicky Le
            // Date: 4/14/2024
            // Class: Programming 120

            //Question1();
            //Question2();
            //Question3();
            //Question4();
            //Question5();
            //Question6();
            //Question7();
        }
        public static void Question1()
        {
            // Problem
            string Q1 = "1.Write a program that prompts the user to input five decimal numbers. Your program should do the following:\r\n\r\na.Prompts the user to input five decimal numbers.\r\n\r\nb.Prints the five decimal numbers.\r\n\r\nc.Add the five decimal numbers.\r\n\r\nd.Print the sum and the average of the five decimals. Calculating the sum and the average are two separate calculations.";
            Console.WriteLine((Q1) + "\n");

            // Results
            // Prompt user to input five decimal numbers
            Console.Write(("Enter your five decimal numbers") + "\n");
            Console.Write("Number 1: ");
            string userNumber1 = Console.ReadLine();
            Console.Write("Number 2: ");
            string userNumber2 = Console.ReadLine();
            Console.Write("Number 3: ");
            string userNumber3 = Console.ReadLine();
            Console.Write("Number 4: ");
            string userNumber4 = Console.ReadLine();
            Console.Write("Number 5: ");
            string userNumber5 = Console.ReadLine();
            try
            {
                float number1 = float.Parse(userNumber1);
                float number2 = float.Parse(userNumber2);
                float number3 = float.Parse(userNumber3);
                float number4 = float.Parse(userNumber4);
                float number5 = float.Parse(userNumber5);

                // Calculate sum of the five decimal numbers
                float sum = number1 + number2 + number3 + number4 + number5;
                // calculate average of the five decimal numbers
                float average = sum / 5;
                // Display
                Console.WriteLine($"The sum of the five decimal numbers is: {sum}");
                Console.WriteLine($"The average of the five decimal numbers is: {average}");
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter the valid decimal numbers.");
            }
        } // Question1
        public static void Question2()
        {
            // Problem
            string Q2 = "2. Write a program that prompts the capacity, in gallons, of an automobile fuel tank and the miles per gallon the automobile can be driven. The program outputs the number of miles the automobile can be driven without re-fueling.";
            Console.WriteLine((Q2) + "\n");

            //Result
            try
            {
                // Input fuel tank capacity and miles per gallon
                Console.Write("Enter the fuel tank's capacity in gallons: ");
                float fuelTankCapacity = float.Parse(Console.ReadLine());
                Console.Write("Enter the miles per gallon the automobile can be driven: ");
                float milesPerGallon = float.Parse(Console.ReadLine());

                // Calculate
                float milesCanDrive = fuelTankCapacity * milesPerGallon;
                
                // Display
                Console.WriteLine($"The automobile can be driven {milesCanDrive} miles without re-fueling.");
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter the valid decimal numbers.");
            }
        } // Question2

        public static void Question3()
        {
            // Problem
            string Q3 = "Write a  program that prompts the user to input the elapsed time for an event in seconds. The program then outputs the elapsed time in hours, minutes, and seconds. (For example, if the elapsed time is 9630 seconds, then the output is 2:40:30.)";
            Console.WriteLine((Q3) + "\n");

            // Results
            try
            {
                // Input elapsed time in seconds
                Console.Write("Enter the elapsed time in seconds: ");
                int elapsedTimeSeconds = int.Parse(Console.ReadLine());

                // Convert seconds to hours, minutes, and remaining seconds
                int hours = elapsedTimeSeconds / 3600;
                int minutes = (elapsedTimeSeconds % 3600) / 60;
                int seconds = elapsedTimeSeconds % 60;

                //Display
                Console.WriteLine($"Elapsed time: {hours}:{minutes:D2}:{seconds:D2}");
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        } // Question3
        
        public static void Question4()
        {
            // Problem
            string Q4 = "Write a  program that prompts the user to input the elapsed time for an event in hours, minutes, and seconds. The program then outputs the elapsed time in seconds.";
            Console.WriteLine((Q4) + "\n");

            // Results
            try
            {
                int secondsPerHours = 3600;
                int secondsPerMinutes = 60;

                // Input elapsed time in hours, minutes, and seconds
                Console.Write("Enter hours:");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Enter minutes:");
                int minutes = int.Parse(Console.ReadLine());

                Console.Write("Enter seconds:");
                int seconds = int.Parse(Console.ReadLine());

                // Convert elapsed time to total seconds
                int elapsedTimeInSeconds = (hours * secondsPerHours) + (minutes * secondsPerMinutes) + seconds;

                // Display
                Console.WriteLine($"Elapsed time in seconds: {elapsedTimeInSeconds}");
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        } // Question4

        public static void Question5()
        {
            // Problem
            string Q5 = "To make a profit, a local store marks up the prices of its items by a certain percentage. Write a program that reads the original price of the item sold, the percentage of the marked-up price, and the sales tax rate. The program then outputs the original price of the item, the percentage of the mark-up, the store’s selling price of the item, the sales tax rate, the sales tax, and the final price of the item. (The final price of the item is the selling price plus the sales tax.)";
            Console.WriteLine((Q5) + "\n");

            // Result
            try
            {
                float originalPrice;
                float markupPricePercentage;
                float salesTaxRate;
                float markupPercentageBase = 100;

                // Input item details
                Console.Write("Enter the item’s original price in here:");
                originalPrice = float.Parse(Console.ReadLine());

                Console.Write("Enter the markup price percentage in here:");
                markupPricePercentage = float.Parse(Console.ReadLine());

                Console.Write("Enter the sales tax rate in here:");
                salesTaxRate = float.Parse(Console.ReadLine());


                // Calculate markup price, selling price, tax rate, and final price
                float markupPrice = (markupPricePercentage / markupPercentageBase) * originalPrice;
                float sellingPrice = originalPrice + markupPrice;
                float taxRate = (salesTaxRate / markupPercentageBase) * sellingPrice;
                float finalPrice = sellingPrice + taxRate;

                // Display

                Console.WriteLine("\n");
                Console.WriteLine($"The original price of the item: ${originalPrice}");
                Console.WriteLine($"The percentage of mark-up: {markupPricePercentage}%");
                Console.WriteLine($"The store’s selling price of the item: ${sellingPrice}");
                Console.WriteLine($"The sales tax rate: {salesTaxRate}%");
                Console.WriteLine($"The sales tax: ${taxRate}");
                Console.WriteLine($"The final price of the item: ${finalPrice}");
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        } //Question5

        public static void Question6()
        {
            // Problem
            string Q6 = "Write a program that prompts the user to input a length expressed in centimeters. The program should then convert the length to inches (to the nearest inch) and output the length expressed in yards, feet, and inches, in that order. For example, suppose the input for centimeters is 312. To the nearest inch, 312 centimeters is equal to 123 inches. 123 inches would thus be output as:\r\n\r\n3 yard(s), 1 feet (foot), and 3 inch(es).";
            Console.WriteLine((Q6) + "\n");

            // Results
            int centimeters = 0;
            try
            {
                // Ask user for the length in centimeters
                Console.Write("Enter a length in centimeters: ");
                string userInput = Console.ReadLine();
                centimeters = int.Parse(userInput);
            }
            catch
            {
                Console.WriteLine("Your value was an invalid format");
            }
            // Convert users length to inches
            double convertedToInches = Math.Round(centimeters / 2.54);
          
            // Convert to yards, feet, and inches
            int inchesInYard = 36;
            int yards = (int)convertedToInches / inchesInYard;
            convertedToInches %= inchesInYard;

            int inchesInFoot = 12;
            int feet = (int)convertedToInches / inchesInFoot;
            convertedToInches %= inchesInFoot;
            int inches = (int)convertedToInches;

            // Display 
            Console.WriteLine($"{yards} yard(s), {feet} feet (foot), and {inches} inch(es)");
        } // Question6

        public static void Question7()
        {
            // Problem 
            string Q7 = " A milk carton can hold 3.78 liters of milk. Each morning, a dairy farm ships cartons of milk to a local grocery store. The cost of producing one liter of milk is $0.38, and the profit of each carton of milk is $0.27. Write a program that does the following:\r\n\r\na. Prompts the user to enter the total amount of milk produced in the morning.\r\n\r\nb. Outputs the number of milk cartons needed to hold milk. (Round your answer to the nearest integer.)\r\n\r\nc. Outputs the cost of producing milk.\r\n\r\nd. Outputs the profit for producing milk.";
            Console.WriteLine((Q7) + "\n");

            // Results
            try
            {
                double milkProduceLiters;
                double litersPerCaton = 3.78d;
                double costPerLiter = 0.38d;
                double profitPerCarton = 0.27d;

                // User enter the tomal amount of milk produced in the morning
                Console.Write("Enter the total amount of milk produced in the morning: ");
                float milkProducedLiters = float.Parse(Console.ReadLine());

                // Calculate the number of milk cartons needed (rounded up to the nearest integer)
                int cartonsNeededHoldMilk = (int)Math.Round(milkProducedLiters / litersPerCaton);

                // Calculate the cost of producing the milk
                double costOfProducingMilk = milkProducedLiters * costPerLiter;

                // Calculate the profit for producing the milk
                double profitForProducingMilk = cartonsNeededHoldMilk * profitPerCarton;

                // Display
                Console.WriteLine($"The number of milk cartons needed to hold milk: {cartonsNeededHoldMilk}");
                Console.WriteLine($"The cost of producing milk: ${costOfProducingMilk}");
                Console.WriteLine($"The profit for producing milk.: ${profitForProducingMilk}");
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        } // Question7

    } // class
} // namespace
