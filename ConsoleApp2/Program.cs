﻿using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*
            1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            Console.WriteLine("please enter your number : ");
            int x = int.Parse(Console.ReadLine());

            if (x % 3 == 0 && x % 4 == 0)
            {

                Console.WriteLine(" YES ");
            }
            else { 
            Console.WriteLine(" NO ");
            }*/
            #endregion

            #region Q2
            /*Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            Console.WriteLine("please enter your number : ");
            int x = int.Parse(Console.ReadLine());
            if (x < 0)
            {
                Console.WriteLine("negative");
            }
            else { Console.WriteLine("positive"); }*/
            #endregion\

            #region Q3
            /*Write a program that takes 3 integers from the user then prints the max element and the min element.


            Console.WriteLine("please enter your 3 numbers : ");
            int x = int.Parse(Console.ReadLine());
            int max = x;
            int min = x ;
            for (int i = 0; i < 2; i++) {
                
                int z = int.Parse(Console.ReadLine());


                if (z > max)
                    max = z;

                if (z < min)
                    min = z;

            }
            Console.WriteLine("max number is " + max);
            Console.WriteLine("min number is " + min);*/



            #endregion

            #region Q4
            /*Write a program that allows the user to insert an integer number then check If a number is even or odd.
            Console.WriteLine("please enter your number : ");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {

                Console.WriteLine(" Even ");
            }
            else
            {
                Console.WriteLine(" Odd ");
            }
            */

            #endregion

            #region Q5
            /*Write a program that takes character from the user then if it is a vowel chars(a, e, I, o, u) then print(vowel) otherwise print(consonant).
            Console.WriteLine("please enter a character ");
            char c = char.Parse(Console.ReadLine());

            switch (c) { 
            
            case 'a': Console.WriteLine("Vowel");
                    break;
            case 'e': Console.WriteLine("Vowel");
                    break;
            case 'I': Console.WriteLine("Vowel");
                    break;
            case 'o': Console.WriteLine("Vowel");
                    break;
            case 'u': Console.WriteLine("Vowel");
                    break;
                    default: Console.WriteLine("Consonant");
                    break ;
            }
              */
            #endregion

            #region Q6
            /*Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            Console.WriteLine("please enter your number : ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1 ; i <= x ; i++ ) {
                Console.WriteLine( i);
            }*/
            #endregion

            #region Q7
            /*Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            Console.WriteLine("please enter your number : ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(i * x );
            }
            */
            #endregion

            #region Q8
            /*Write a program that allows to user to insert number then print all even numbers between 1 to this number
            Console.WriteLine("please enter your number : ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {

                Console.WriteLine(i++);
            }*/
            #endregion

            #region Q9
            /* Write a program that takes two integers then prints the power.
            int x = 1;
            Console.WriteLine("enter the number :");
            Console.WriteLine("enter the power :");
            int n =int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            for (int i = 0; i < p; i++)
            {
                  x *= n ;          
            
            }
            Console.WriteLine(x);*/
            #endregion

            #region Q10
            /* Write a program to enter marks of five subjects and calculate total, average and percentage.

            Console.WriteLine("Enter Marks of five subjects: ");
            int grade = 0;
            double toutal = 500;
            for (int i = 0; i < 5; i++) {
                int x = int.Parse(Console.ReadLine());
                grade += x;
            }
            Console.WriteLine("Total marks = " + grade);
            Console.WriteLine(" Average Marks = " + grade / 5.0);
            double percentage = (grade / toutal) * 100; 
            Console.WriteLine("Percentage = " + percentage +"%");
            */
            #endregion

            #region Q11
            /* Write a program to input the month number and print the number of days in that month.

            Console.WriteLine("Month Number: ");
            int month = int .Parse(Console.ReadLine());
            switch (month) { 
            
            
             case 1:
                    Console.WriteLine(" 31");
                    break;
             case 2:
                    Console.WriteLine("Days in Month: 28");
                         break;
             case 3:
                    Console.WriteLine("Days in Month: 31");
                    break;
             case 4:
                    Console.WriteLine("Days in Month: 30");
                    break;
             case 5:
                    Console.WriteLine("Days in Month: 31");
                    break;
             case 6:
                    Console.WriteLine("Days in Month: 30");
                    break;
             case 7:
                    Console.WriteLine("Days in Month: 31");
                    break;
             case 8:
                    Console.WriteLine("Days in Month: 30");
                    break;
             case 9:
                    Console.WriteLine("Days in Month: 31");
                    break;
             case 10:
                    Console.WriteLine("Days in Month: 30");
                    break;
             case 11:
                    Console.WriteLine("Days in Month: 31");
                    break;
             case 12:
                    Console.WriteLine("Days in Month: 30");
                    break;
                    default:
                    Console.WriteLine("The month number you entered does not exist");
                    break ;*/
            #endregion

            #region Q12
            /*
              Console.Write("Enter the size of the identity matrix: ");
              int n = int.Parse(Console.ReadLine());


              for (int i = 0; i < n; i++)
              {
                  for (int j = 0; j < n; j++)
                  {
                      if (i == j)
                          Console.Write("1 ");
                      else
                          Console.Write("0 ");
                  }
                  Console.WriteLine();
                 }*/
            #endregion

            #region Q13
            /*Write a program in C# Sharp to find the sum of all elements of the array.
            int[] arr = { 1, 2, 3, 4, 5 }; 
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Sum = " + sum);*/
            #endregion

            #region Q14

            #endregion

            #region Q15
            /* Write a program in C# Sharp to find maximum and minimum element in an array


            int[] arr = { 12, 45, 2, 67, 5, 90, 34 }; 

            int max = arr[0];
            int min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
                if (arr[i] < min)
                    min = arr[i];
            }

            Console.WriteLine("Maximum element is: " + max);
            Console.WriteLine("Minimum element is: " + min);
        */
            #endregion
        }
    }
    
}

