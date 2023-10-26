using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabaseLibrary
{
    class MovieLibraryApp
    {

        DatabaseManager db = new();
        string input = "";

        public MovieLibraryApp()
        {
            MainMenu();
        }

        public void MainMenu()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("|                 |");
            Console.WriteLine("|  Movie Library  |");
            Console.WriteLine("|                 |");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. See List");
            Console.WriteLine("2. Search");
            Console.WriteLine("3. Add movie");
            Console.WriteLine("4. Edit Movie");
            Console.WriteLine("5. Delete Movie");
            Console.WriteLine("6. Exit");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    MovieList();
                    break;
                case "2":
                    MovieSearch();
                    break;
                case "3":
                    AddMovie();
                    break;
                case "4":
                    EditMovie();
                    break;
                case "5":
                    DeleteMovie();
                    break;
                case "6":
                    break;
            }
        }

        private void MovieList()
        {
            Console.WriteLine("movie list");
        }

        private void MovieSearch()
        {
            Console.WriteLine("movie search");
        }

        private void AddMovie()
        {
            Console.WriteLine("add movie");
        }

        private void EditMovie()
        {
            Console.WriteLine("edit movie");
        }

        private void DeleteMovie()
        {
            Console.WriteLine("delete movie");
        }
    }
}
