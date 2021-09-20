using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testProjectForGruppwWork
{
    public class Entertainment
    {
        Film film = new Film();
        Games games = new Games();

        public string Title { get; set; }
        /*In entertainment
            Film
            Games*/
        public void DisplayEntertainmentMenu()
        {
            Console.WriteLine("Entertaiment category" +
                "\n1.Film" +
                "\n2.Games");

            char c = Userchoice();
            PrintItems(c);
        }

        public char Userchoice()
        {
            //Validate user input NEEDED
            Console.Write("Please choose: ");
            return char.Parse(Console.ReadLine());
        }

       // Film film = new Film();
        //Games games = new Games();
        //input from Userchoice char c needs to print out the List in respective class
        public void PrintItems(char c)
        {
            if(c == '1')
            {
                foreach(var item in film.FilmList)
                {
                    Console.WriteLine($"{item}");
                }
            }
            else 
            {
                foreach (var item in games.GameList)
                {
                    Console.WriteLine($"{item}");
                }
            }
        }
    }
}
