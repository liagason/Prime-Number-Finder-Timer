using System;
using System.Management;
using System.Diagnostics;
namespace Prime_rangeber_Finder_Timer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime Number Finder & Timer [Version: 1.0.0.2, Compiled: Tuesday, 13 Nov 2018]");
            Console.WriteLine("Copyright (c) 2018, Sotiris Liagas. All rights reserved.\n");
            Console.WriteLine("Primality test algorithm is based on trial division and is NOT optimized for speed.");
            Console.WriteLine("Source code & documentation are available at https://github.com/liagason\n");
            Console.WriteLine("Find all prime numbers up to (e.g. 500000):");
            int m;
            string input = Console.ReadLine();
            long range;
            Int64.TryParse(input, out range);
            bool isPrimeNumber = true;
            if (range >= 2 && range is long)
            {
                for (m = 0; m < 2; m++)
                {
                    Stopwatch stopWatch = new Stopwatch();
                    stopWatch.Start();
                    for (long i = 2; i <= range; i++)
                    {
                        for (long j = 2; j <= range; j++)
                        {

                            if (i != j && i % j == 0)
                            {
                                isPrimeNumber = false;
                                break;
                            }
                        }
                        if (isPrimeNumber && m == 0)
                        {
                            Console.WriteLine(i);
                        }
                        isPrimeNumber = true;
                    }
                    stopWatch.Stop();
                    TimeSpan ts = stopWatch.Elapsed;
                    if (m == 0) Console.WriteLine("[Needed " + ts + " to FIND AND PRINT all prime numbers up to " + range + "]");
                    if (m == 1) Console.WriteLine("[Needed " + ts + " to JUST PRINT all prime numbers up to " + range + "]");
                }
                ManagementObjectSearcher myProcessorObject = new ManagementObjectSearcher("select * from Win32_Processor");
                foreach (ManagementObject obj in myProcessorObject.Get())
                {
                    Console.WriteLine("[Tested on " + obj["Name"] + "]");
                }
            }
            else
            {
                Console.WriteLine("Fatal error. Input must be an integer number.");
            }
            Console.WriteLine("Press ENTER to exit...");
            Console.Read();
        }
    }
}
