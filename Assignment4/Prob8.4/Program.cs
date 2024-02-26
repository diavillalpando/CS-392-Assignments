using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob8._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            do 
            {
                try 
                {
                    int consonants = 0;
                    int vowels = 0;
                    Console.WriteLine("Welcome to vowel and consonant counter. Please enter a string.");

                    string input_string = Console.ReadLine();

                    for (int i = 0; i < input_string.Length; i++) {
                        if (char.IsLetter(input_string[i])) 
                        { 
                            char c = char.ToLower(input_string[i]);
                            if (c == 'a' | c == 'i' | c == 'o' | c == 'e' | c == 'u')
                            {
                                vowels++;
                            }
                            else
                            { 
                                consonants++;
                            }
                        }
                    }

                    Console.WriteLine($"Consonants: {consonants}");
                    Console.WriteLine($"Vowels {vowels}");

                    Console.WriteLine("Do you want to try again? (yes to continue, anything else to exit)");
                    string more = Console.ReadLine();
                    if (more == "yes")
                    {
                        continue;
                    }
                    else
                    {
                        exit = true;
                    }
                
                } catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            
            } while (exit == false);
        }
    }
}
