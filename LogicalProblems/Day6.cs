using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace LogicalProblems
{
    class Day6
    {
        public static void FibonacciSeries()
        {
            int firstNumber = 0, SecondNumber = 1, nextNumber, number;
            Console.WriteLine("Enter the number upto which print the Fibonacci series : ");
            number = int.Parse(Console.ReadLine());
            //First print first and second number
            Console.Write(firstNumber + " " + SecondNumber + " ");
            //Starts the loop from 2 because 0 and 1 are already printed

            for (int i = 2; i < number; i++)
            {
                nextNumber = firstNumber + SecondNumber;
                Console.Write(nextNumber+" ");
                firstNumber = SecondNumber;
                SecondNumber = nextNumber;
            }         
            
        }
        public static void PerfectNumber()
        {
            int number, sum = 0;
            Console.Write("enter the Number");
            number = int.Parse(Console.ReadLine());
        
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }

            if (sum == number)
            {
                Console.WriteLine("\n Entered number is a perfect number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n Entered number is not a perfect number");
                Console.ReadLine();
            }
        }
        public static void PrimeNumber()
        {
            Console.WriteLine("enter NUmber");
            int number = Convert.ToInt32(Console.ReadLine());
            int factors = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    factors++;
                }
            }
            if (factors == 2)                //primenumber twofactors
            {
                Console.WriteLine("{0} is a Prime Number", number);
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
            Console.ReadLine();
        }
        public static void ReverseNumber()
        {
            Console.WriteLine("Enter a Number");
            int number = int.Parse(Console.ReadLine());
            int reverse = 0;
            while (number > 0)
            {
                int rem = number % 10;
                reverse = (reverse * 10) + rem;
                number = number / 10;

            }
            Console.WriteLine("Reverse number={0}", reverse);
            Console.ReadLine();
        }
        public static void CouponNumber()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[6];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            var finalCoupon = new String(stringChars);
            Console.WriteLine(finalCoupon);
        }

      public static void StopWatch()
        {
            //stopwatch stopw = new stopwatch();
            //stopw.start();
            //stopw.stop();
            //timespan tspan = stopw.elapsed;
            //string elapsedtime = string.format(" {0:00}:{1:00}:{2:00}.{3:00} ",
            //tspan.hours, tspan.minutes, tspan.seconds, tspan.milliseconds / 10);
            //console.writeline(" runtime " + elapsedtime);

            Stopwatch stopwatch = new Stopwatch();

            // Begin timing.
            stopwatch.Start();

            // Do something.
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(1);
            }

            // Stop timing.
            stopwatch.Stop();

            // Write result.
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
        }

        public static void ToBinary()
        {
            Console.Write("Enter the Decimal Number : ");
            int number = int.Parse(Console.ReadLine());
            int i;
            int[] numberArray = new int[10];
            for (i = 0; number > 0; i++)
            {
                numberArray[i] = number % 2;
                number = number / 2;
            }
            Console.Write("Binary Represenation of the given Number : ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(numberArray[i]);
            }
            Console.ReadKey();
        }
        public static void TemperatureConversion()
        {
            Console.Write("Enter temperature in Celsius : ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = ((celsius * 9) / 5) + 32;
            Console.WriteLine("The converted fahrenheit temperature is : " + fahrenheit);

            Console.WriteLine("Enter Fahrenheit Temperature:");
            double Fahrenheit = Convert.ToDouble(Console.ReadLine()); ;
            double Celsius = (Fahrenheit - 32) * 5 / 9;
            Console.WriteLine("The converted Celsius temperature is:" + Celsius);
            Console.ReadLine();
        }
        public static void ToDecimal()
        {
            Console.Write("Enter the Binary Number : ");
            int binaryNumber = int.Parse(Console.ReadLine());
            int decimalValue = 0;
            // initializing base1 value to 1, i.e 2^0 
            int base1 = 1;

            while (binaryNumber > 0)
            {
                int reminder = binaryNumber % 10;
                binaryNumber = binaryNumber / 10;
                decimalValue += reminder * base1;
                base1 = base1 * 2;
            }
            Console.Write($"Decimal Value : {decimalValue} ");
            Console.ReadKey();

        }

        public static double SquareRoot(double n, double l)
        {
            double x = n;
            // The closed guess will be stored in the root
            double root;
            // To count the number of iterations
            int count = 0;
            while (true)
            {
                count++;
                // Calculate more closed x
                root = 0.5 * (x + (n / x));
                // Check for closeness
                if (Math.Abs(root - x) < l)
                    break;
                // Update root
                x = root;
            }
            return root;
        }
        public static void MonthlyPayment()
        {

            double principal = 50000;
            double years = 1;
            double rate = 1;

            double r = (rate / 100) / 12;   // monthly interest rate
            double n = 12 * years;          // number of months

            double payment = (principal * r) / (1 - Math.Pow(1 + r, -n));
            double interest = payment * n - principal;

            Console.WriteLine("Monthly payments = " + payment);
            Console.WriteLine("Total interest   = " + interest);
        }
        public static void DayOfWeek() 
        {
            Console.WriteLine("Enter year :");
           
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Month :");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Day :");
            int day = Convert.ToInt32(Console.ReadLine());

            int y1, x, m1, d1;
            y1 = year - (14 - month) / 12;
            x = y1 + (y1 / 4) - (y1 / 100) + (y1 / 400);
            m1 = month + 12 * ((14 - month) / 12) - 2;
            d1 = (day + x + 31 * m1 / 12) % 7;

            switch (d1)
            {
                case 0:
                    Console.WriteLine("sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                default:
                    Console.WriteLine("saturday");
                    break;
            }
        }

       
        // Function for Calculating the notes
        public static void VendingMachine(int amount)  
        {
            int[] notes = new int[] {1000,500,100,50,100,5,1};
            int[] noteCounter = new int[10];

            for (int i = 0; i < notes.Length; i++)
            {
                if (amount >= notes[i])
                {
                    noteCounter[i] = amount / notes[i];
                    amount = amount - noteCounter[i] * notes[i];
                }
            }

            for (int i = 0; i < notes.Length; i++)
            {
                if (noteCounter[i] != 0)
                {
                    Console.WriteLine("Rs." + notes[i] +"notes"+ "=="+ noteCounter[i]);
                }
            }
        }
    }
}



