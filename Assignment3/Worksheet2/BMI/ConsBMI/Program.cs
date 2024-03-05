using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsBMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String unit ;
            int age;
            double weight = 0;
            double height = 0;
            bool exit = false;
            double BMI = 0;
            string gender = "";
            string msg = "";
            do
            {
                try
                {
                    bool answered = false;
                    do
                    {
                        Console.WriteLine("Welcome to BMI calculator, what kind of unit system do you want to use? ('metric'/'english')");
                        string unit_input = Console.ReadLine();
                        switch (unit_input)
                        {
                            case "metric":
                                unit = "metric";
                                answered = true;
                                break;
                            case "english":
                                unit = "english";
                                answered = true;
                                break;
                            default:
                                unit = "";
                                Console.WriteLine("That is not a valid unit system.");
                                break;
                        }
                    } while (answered == false);

                    Console.WriteLine("What is your gender? (Optional question, press enter to skip)");
                    gender = Console.ReadLine();

                    Console.WriteLine("What is your age? (Please enter a whole number.)");
                    age = int.Parse(Console.ReadLine());

                    switch (unit) {
                        case "metric":
                           Console.WriteLine("What is your weight in kilograms? (Please do not include units.)");
                           weight = double.Parse(Console.ReadLine());
                    
                           Console.WriteLine("What is your height in centimeters? (Please do not include units.)");
                           height = double.Parse(Console.ReadLine());
                           break;
                        case "english":
                            Console.WriteLine("What is your weight in pounds? (Please do not include units.)");
                            weight = double.Parse(Console.ReadLine());

                            Console.WriteLine("What is your height in inches? (Please do not include units.)");
                            height = double.Parse(Console.ReadLine());
                            break;
                        default:
                            Console.WriteLine("");
                            break;
                    }
                    

                    switch (unit)
                    {
                        case "metric":
                            BMI = weight / Math.Pow((height / 100), 2);
                            break;
                        case "english":
                            BMI = (weight / Math.Pow(height, 2)) * 703;
                            break;
                        default:
                            Console.WriteLine("That is not a valid unit system.");
                            break;

                    }
                    if (gender == "") { 
                        msg = ("Your BMI is " + BMI + " at age " + age + ".");
                    } else
                    {
                        msg = ("You are a "+ age +" year old "+ gender + " with a BMI of " + BMI + ".");
                    }

                    Console.WriteLine(msg);

                    Console.WriteLine("Would you like to try again? ('no' to exit)");
                    string exit_input = Console.ReadLine().ToLower();
                    if (exit_input == "no")
                    {
                        exit = true;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("You suck! You didn't input the correct value!: " + ex.Message);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("no! that size is too big >:( " + ex.Message);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Something broke and I am not sure what...: " + ex.Message);
                }
            } while (exit == false);
            Console.WriteLine();
        }
    }
}
