using System;
using System.Collections.Generic;
namespace testProjectForGruppwWork
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Home Library System");
            /*ASCI ROBOT*/
            Console.WriteLine("Welcome!");
            Console.WriteLine("What would you like to access?");

            Entertainment entertainment = new Entertainment();

            entertainment.DisplayEntertainmentMenu();




        }
    }

}
