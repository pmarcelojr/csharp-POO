﻿using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Scott's Grade Book");
            book.GradeAdded += OnGradeAdded;

            while(true)
            {
                Console.Write("Enter a grade or 'q' to quit: ");
                var input = Console.ReadLine();

                if(input == "q")
                    break;
                
                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                   Console.WriteLine("*********************************");
                }
            }

            var stats = book.GetStatistics(); 
                        
            Console.WriteLine(Book.CATEGORY);
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The High grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
        }

        static void OnGradeAdded(Object sender, EventArgs e)
        {
            Console.WriteLine("A grade was added");
        }
    }
}
