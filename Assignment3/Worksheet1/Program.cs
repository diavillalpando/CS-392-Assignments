// See https://aka.ms/new-console-template for more information

bool still_ordering = true;
double total_bill = 0.0;
do
{
    try
    {
        Console.WriteLine("Please select your coffee size: 1 - small, 2 - medium, 3 - large");
        string user_input = Console.ReadLine();

        switch (int.Parse(user_input))
        {
            case 1: //small
                Console.WriteLine("Here is your small drink :)");
                total_bill += 1;
                break;
            case 2: //medium
                Console.WriteLine("Here is your medium drink :)");
                total_bill += 2;
                break;
            case 3: //large
                Console.WriteLine("Here is your large drink :)");
                total_bill += 3;
                break;
            default:
                Console.WriteLine("You dind't order a correct drink>:(");
                break;

        }
        Console.WriteLine("do you want another drink? yes or no");
        user_input = Console.ReadLine().ToLower();
        if (user_input == "no")
        {
            still_ordering = false;
        }
    }
    catch (FormatException ex){
        Console.WriteLine("You suck! You didn't input the correct value!: " + ex.Message);
    }
    catch (OverflowException ex)
    {
        Console.WriteLine("no! that size is too big >:( " + ex.Message);
        break;
    }
    catch (Exception ex)
    {
        Console.WriteLine("Something broke and I am not sure what...: "+ ex.Message);
    }
} while (still_ordering);
Console.WriteLine("Bye! Please don't ever come back again. Your total Bill amount is: $"+total_bill);

