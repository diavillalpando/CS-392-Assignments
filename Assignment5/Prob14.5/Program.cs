using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob14._5
{
    class DJIAData
    {
        public string Date { get; set; }
        public double ClosingValue { get; set; }
        public double OpeningValue { get; set; }
        public double HighestValue { get; set; }
        public double LowestValue { get; set; }
    }

    class DJIAAnalyzer
    {
        private List<DJIAData> data;

        public DJIAAnalyzer(string filePath)
        {
            data = new List<DJIAData>();
            LoadData(filePath);
        }

        private void LoadData(string file)
        {
            StreamReader reader = new StreamReader(file);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                DJIAData djiaData = new DJIAData
                {
                    Date = parts[0],
                    ClosingValue = double.Parse(parts[1]),
                    OpeningValue = double.Parse(parts[2]),
                    HighestValue = double.Parse(parts[3]),
                    LowestValue = double.Parse(parts[4])
                };
                data.Add(djiaData);
            }

        }

        public void SearchClosingValue(double value)
        {
            Console.WriteLine($"\nHere are the dates for which the Closing Value is above {value}: ");
            foreach (var djiaData in data)
            {
                if (djiaData.ClosingValue >= value)
                {
                    Console.WriteLine($"Date: {djiaData.Date}, Closing Value: {djiaData.ClosingValue}");
                }
            }
        }

        public void SearchFirstClosingValue(double value)
        {
            foreach (var djiaData in data)
            {
                if (djiaData.ClosingValue >= value)
                {
                    Console.WriteLine($"\nHere is the first Date with Closing Value {value} or greater: {djiaData.Date}");
                    return;
                }
            }
            Console.WriteLine($"\nThere are no dates where the Closing Value was above {value}.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            do
            {
                try
                {
                    DJIAAnalyzer analyzer = new DJIAAnalyzer("DJIA.csv");

                    string search_for;
                    do
                    {
                        Console.WriteLine("Welcome to Dow Jones Industrial Average Highs. Which dates do you want to search for? For the first date that the Closing Value was greater than or equal to a specific value, type 'first'. For all the dates that the Closing Value was greater than or equal to a specific value, type 'all'. To exit, type 'exit'." );

                        search_for = Console.ReadLine();

                        if (search_for == "first")
                        {
                            Console.WriteLine("Enter the value you want to search for.");
                            double val = double.Parse(Console.ReadLine());

                            analyzer.SearchFirstClosingValue(val);
                            Console.WriteLine("\n");
                        }
                        else if (search_for == "all")
                        {
                            Console.WriteLine("Enter the value you want to search for.");
                            double val = double.Parse(Console.ReadLine());

                            analyzer.SearchClosingValue(val);
                            Console.WriteLine("\n");
                        }
                        else if (search_for == "exit")
                        {
                            exit = true;
                            break;
                        }
                        else 
                        {
                            Console.WriteLine("\nThe only options are 'first', 'all', or 'exit'. Please try again.\n");
                        }
                    } while (search_for != "first" || search_for != "all" || search_for != "exit"); 

                    
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("\nNope: " + ex.Message);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("\nIn your dreams: " + ex.Message);
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
    

