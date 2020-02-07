using System;
using System.IO;


namespace SummarizeTempsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists("temps.txt"))
            {

                using (StreamReader sr = File.OpenText("temps.txt"))
                {
                    bool LetsRunThisBack = true;
                    while (LetsRunThisBack == true)
                    {

                        int averageTemp = 0;

                        Console.WriteLine("Enter a temperature threshold");
                        int aboveCounter = 0;
                        int belowCounter = 0;
                        int tempThreshold = int.Parse(Console.ReadLine());
                        string fileTemp = "";
                        int summation = 0;
                        while ((fileTemp = sr.ReadLine()) != null)
                        {

                            Console.WriteLine(int.Parse(fileTemp));
                            summation = summation + int.Parse(fileTemp);
                            if (int.Parse(fileTemp) >= tempThreshold)
                            {
                                aboveCounter += 1;
                            }
                            else
                            {
                                belowCounter += 1;
                            }




                        }
                        averageTemp = summation / (aboveCounter + belowCounter);
                        Console.WriteLine("above counter = " + aboveCounter);
                        Console.WriteLine("below counter = " + belowCounter);
                        Console.WriteLine("The average is" + averageTemp);

                        Console.WriteLine("Do you want to continue? If so, type 'yes'.");
                        if (Console.ReadLine() == "yes")
                        {
                            LetsRunThisBack = true;

                        }
                        else
                        {
                            LetsRunThisBack = false;
                        }

                    }
                }
            }
            else
            {
                Console.WriteLine("Temperature does not exist");
            }
                
            
        }
    }
}
