using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Prob8._3
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
                    bool cap_needed = true;
                    
                    Console.WriteLine("Welcome to Sentence Capitalizer, please enter the sentences you want to capitalize");

                    String input_string = Console.ReadLine();

                    String capped_string = "";

                    bool is_end (char c) {
                        if (c == '.' | c == '!' | c == '?') { 
                            return true;
                        } else
                        {
                            return false;
                        }
                    }
                    
                    for (int i = 0; i < input_string.Length; i++) {
                        if (cap_needed)
                        {
                            if (char.IsLetter(input_string[i]))
                            {
                                capped_string += char.ToUpper(input_string[i]);
                                cap_needed = false;
                            }
                            else if (char.IsDigit(input_string[i])) 
                            {
                                capped_string += char.ToUpper(input_string[i]);
                                cap_needed = false;
                            }
                            else
                            {
                                capped_string += input_string[i];
                            }
                        } else {
                            if (is_end(input_string[i])) {
                                capped_string += input_string[i];
                                cap_needed = true;
                            } else
                            {
                                capped_string += input_string[i];
                            }
                        }
                    }
                    Console.WriteLine ("Modified Sentences: ");
                    Console.WriteLine(capped_string);
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
                }

                catch (Exception ex)
                { 
                    Console.WriteLine(ex.ToString());
                }
            } while (exit == false);
            Console.WriteLine();
        }
    }
}
