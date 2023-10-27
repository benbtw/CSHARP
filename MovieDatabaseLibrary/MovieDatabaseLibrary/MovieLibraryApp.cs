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
            Console.Clear();
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
            Console.Clear(); // ASC or DESC
            db.ReadFromTable("SELECT * FROM MOVIES ORDER BY Score DESC");
        }

        private void MovieSearch()
        {
            Console.Clear();
            Console.WriteLine("What movie are you searchin for?");
            Console.WriteLine("Search with either Title, Year, Director, or Score: ");
            input = Console.ReadLine();
            switch (input)
            {
                case "Title":
                    Console.WriteLine("Enter the Title: ");
                    input = Console.ReadLine();
                    db.ReadFromTable($"SELECT * FROM MOVIES WHERE Title = '{input}'");
                    break;
                case "Year":
                    Console.WriteLine("Enter the Year: ");
                    input = Console.ReadLine();
                    db.ReadFromTable($"SELECT * FROM MOVIES WHERE Year = {input}");
                    break;
                case "Director":
                    Console.WriteLine("Enter the Director: ");
                    input = Console.ReadLine();
                    db.ReadFromTable($"SELECT * FROM MOVIES WHERE Director = '{input}'");
                    break;
                case "Score":
                    Console.WriteLine("Enter the Score: ");
                    input = Console.ReadLine();
                    db.ReadFromTable($"SELECT * FROM MOVIES WHERE Score = {input}");
                    break;
            }
            Thread.Sleep(1000);
            MainMenu();
        }

        private void AddMovie()
        {
            Console.Clear();
            string title, year, director, score;
            Console.WriteLine("Enter the Title: ");
            title = Console.ReadLine();
            Console.WriteLine("Enter the Year: ");
            year = Console.ReadLine();
            Console.WriteLine("Enter the Director: ");
            director = Console.ReadLine();
            Console.WriteLine("Enter the Score: ");
            score = Console.ReadLine();
            db.ExecuteStatement($"insert into movies values (" +
                $"'{title}', " +
                $"{Int32.Parse(year)}, " +
                $"'{director}', " +
                $"{float.Parse(score)});");
            Thread.Sleep(1000);
            MainMenu();
        }

        private void EditMovie()
        {
            Console.Clear();
            string change, new_val;
            Console.WriteLine("What is the title of the movie you want to edit?");
            input = Console.ReadLine();
            Console.WriteLine("What would you like to edit? (Title, Year, Director, or Score)");
            change = Console.ReadLine();
            switch (change)
            {
                case "Title":
                    Console.WriteLine("Enter the New Title: ");
                    new_val = Console.ReadLine();
                    db.ExecuteStatement($"update movies set Title = '{new_val}' where Title = '{input}';");;
                    break;
                case "Year":
                    Console.WriteLine("Enter the New Year: ");
                    new_val = Console.ReadLine();
                    db.ExecuteStatement($"update movies set Year = {Int32.Parse(new_val)} where Title = '{input}';");
                    break;
                case "Director":
                    Console.WriteLine("Enter the New Director: ");
                    new_val = Console.ReadLine();
                    db.ExecuteStatement($"update movies set Director = '{new_val}' where Title = '{input}';");
                    break;
                case "Score":
                    Console.WriteLine("Enter the New Score: ");
                    new_val = Console.ReadLine();
                    db.ExecuteStatement($"update movies set Score = {float.Parse(new_val)} where Title = '{input}';");
                    break;
            }
            Thread.Sleep(1000);
            MainMenu();

        }

        private void DeleteMovie()
        {
            Console.Clear();
            Console.WriteLine("What is the Title of the movie you want to delete?");
            input = Console.ReadLine();
            db.ExecuteStatement($"DELETE FROM movies WHERE Title = '{input}';");
            Thread.Sleep(1000);
            MainMenu();
        }
    }
}
