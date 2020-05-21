using System;
using System.Collections.Generic;
using static LearningCSharp.UsefulTool;

namespace LearningCSharp
{

    internal static class Giraffe
    {
        // A struct holds values not references
        // A struct can have methods
        // Constructor must have parameters
        struct Graph
        {
            public int xPos;
            public int yPos;

            public Graph(int xPos, int yPos)
            {
                this.xPos = xPos;
                this.yPos = yPos;
            }

            public void Transpose()
            {
                int a = this.xPos;
                this.xPos = yPos;
                this.yPos = a;
            }
        }


        struct MyDate
        {
            public int day;
            public int month;
            public int year;

            public MyDate(int day, int month, int year)
            {
                this.day = day;
                this.month = month;
                this.year = year;
            }

            public void ShowDate()
            {
                string mon = Enum.GetName(typeof(MonthsOfYear), this.month - 1);
                Console.WriteLine("Date: {0:D2}-{1}-{2}", this.day, mon, this.year);
            }
        }


        static void DoUsefulTools()
        {
            AddHeading("Useful Tools");
            SayHi(Environment.GetEnvironmentVariable("USER"));
        }


        static void DoInheritance()
        {
            AddHeading("Inheritance");
            BasicChef chef = new BasicChef();
            ItalianChef italianchef = new ItalianChef();
            AddHeading("Basic Chef");
            chef.MakeSalad();
            chef.MakeChicken();
            chef.MakeSpecialDish();
            // Basic chef cannot cook lasagne!
            AddHeading("Italian Chef");
            italianchef.MakeSalad();
            italianchef.MakeChicken();
            italianchef.MakeLasagne();       // Extra functionality
            italianchef.MakeSpecialDish();   // Overrides "basic chef" method
        }


        static void DoStruct()
        {
            AddHeading("Structures");
            // Structs are value types; Classes are reference types
            // Structs exist only on the stack, whereas class objects reference
            // their entities on the heap

            Graph pos1 = new Graph(12, 5);
            Graph pos2 = new Graph(8, 11);

            Console.WriteLine(">> Initial Values:");
            Console.WriteLine("Position 1: [{0},{1}]", pos1.xPos, pos1.yPos);
            Console.WriteLine("Position 2: [{0},{1}]", pos2.xPos, pos2.yPos);

            // This assigns values of "pos1" to same values of "pos2", but as a struct
            // is not a reference type it does not point to "pos2", unlike a class type
            pos1 = pos2;
            Console.WriteLine(">> After: pos1 = pos2");
            Console.WriteLine("Position 1: [{0},{1}]", pos1.xPos, pos1.yPos);
            Console.WriteLine("Position 2: [{0},{1}]", pos2.xPos, pos2.yPos);

            pos1.xPos = 24;
            Console.WriteLine(">> After: pos1.xPos = 24");
            Console.WriteLine("Position 1: [{0},{1}]", pos1.xPos, pos1.yPos);
            Console.WriteLine("Position 2: [{0},{1}]", pos2.xPos, pos2.yPos);

            pos1.Transpose();
            Console.WriteLine(">> After: pos1.Transpose()");
            Console.WriteLine("Position 1: [{0},{1}]", pos1.xPos, pos1.yPos);
            Console.WriteLine("Position 2: [{0},{1}]", pos2.xPos, pos2.yPos);

            int day = InputInteger("Input date day", 1, 31);
            int month = InputInteger("Input date month number", 1, 12);
            int year = InputInteger("Input the year", 1950, 2100);
            Console.WriteLine(">> Input date: {0:D2}/{1:D2}/{2}", day, month, year);
            MyDate xdate = new MyDate(day, month, year);
            xdate.ShowDate();

        }


        static void DoDate()
        {

            DateTime now = DateTime.Now;
            Console.WriteLine("Today's Date: {0:D2}-{1}-{2}", now.Day, now.ToString("MMM"), now.Year);
            now = (now.AddDays(-10).AddMonths(3));
            Console.WriteLine("Changed to: {0:D2}-{1}-{2}", now.Day, now.ToString("MMM"), now.Year);
        }



        static void DoSong()
        {
            AddHeading("Songs");
            List<Song> songs = new List<Song>();

            Song song1 = new Song("Blurred Lines", "Pharrell Williams", 220);
            songs.Add(song1);
            Console.WriteLine("Added song number: {0}", Song.songCount);

            Song song2 = new Song("Last Christmas", "George Michael", 315);
            songs.Add(song2);
            Console.WriteLine("Added song number: {0}", Song.songCount);

            // Invalid rating "UH" will be overwritten by "NR" default rating.
            Song song3 = new Song("Umbrella", "Rihanna", 502);
            songs.Add(song3);
            Console.WriteLine("Added song number: {0}", Song.songCount);

            Console.WriteLine("\nThe Song list:");
            foreach (Song song in songs)
            {
                Console.WriteLine("{0} is {1} secs long", song.title, song.duration);
                WrittenBy(song.artist);   // Using "UsefulTool" static method
            }

            // Uses the "Song" class static variable to get value
            Console.WriteLine("\nThe class song count is: {0}", Song.songCount);
            // Uses the "Song" class instance method to get value
            Console.WriteLine("The song count is: {0}", song1.GetSongCount());

        }


        static void DoFilms()
        {
            AddHeading("Films");
            List<Film> films = new List<Film>();

            Film film1 = new Film("Mean Girls", "John Smith", "12A");
            films.Add(film1);
            Film film2 = new Film("The Last Witness", "Tom Brown", "15");
            films.Add(film2);
            // Invalid rating "UH" will be overwritten by "NR" default rating.
            Film film3 = new Film("Mary Poppins", "Jo Black", "UH");
            films.Add(film3);

            foreach (Film film in films)
            {
                Console.WriteLine("{0} has rating: {1}", film.title, film.Rating);
            }
        }


        static void DoStudent()
        {
            AddHeading("Students");
            List<Student> students = new List<Student>();

            Student student1 = new Student("Sophie", "Geography", 68.5);
            students.Add(student1);
            Student student2 = new Student("Joseph", "Mathematics", 81.9);
            students.Add(student2);
            Student student3 = new Student("Dave", "History", 48.2);
            students.Add(student3);

            foreach (Student st in students)
            {
                Console.WriteLine("{0} has grade: {1}", st.name, st.grade);
            }

            foreach (Student st in students)
            {
                string words = (st.HasHonours()) ? "has" : "Does not have";
                Console.WriteLine("{0} {1} an honours degree", st.name, words);
            }

            foreach (Student st in students)
            {
                Console.WriteLine("{0} has grade: {1}", st.name, st.grade);
            }

        }


        static void DoBook()
        {
            AddHeading("Books");
            List<Book> books = new List<Book>();
            List<NewBook> newbooks = new List<NewBook>();

            // Book declaration (1)
            Book book1 = new Book();
            book1.title = "Pride and Prejudice";
            book1.author = "Jane Austen";
            book1.pages = 320;
            books.Add(book1);     // Add to the "books" list

            // Book declaration (2)
            Book book2 = new Book
            {
                title = "Jane Eyre",
                author = "Charlotte Bronte",
                pages = 415
            };
            books.Add(book2);

            // (1) Using class constructor with parameters
            NewBook newbook1 = new NewBook("Emma", "Jane Austen", 410);
            newbooks.Add(newbook1);
            NewBook newbook2 = new NewBook("Wuthering Heights", "Emily Bronte", 340);
            newbooks.Add(newbook2);

            // (2) Using class constructor with no parameters
            NewBook newbook3 = new NewBook
            {
                title = "Bleak House",
                author = "Charles Dickens",
                pages = 745
            };
            newbooks.Add(newbook3);

            // Loop through a list of books
            foreach (Book b1 in books)
            {
                Console.WriteLine("Book: \"{0}\" by {1} has {2} pages",
                                   b1.title, b1.author, b1.pages);
            };


            // Loop through a list of new books
            foreach (NewBook b2 in newbooks)
            {
                Console.WriteLine("Book: \"{0}\" by {1} has {2} pages",
                                   b2.title, b2.author, b2.pages);
            };

        }


        // Exceptions
        static void DoException()
        {
            AddHeading("Calc Exceptions");
            int[] num = { 0, 0 };
            int idx = 0;
            var numlist = new List<string> { "first", "next" };

            foreach (string item in numlist)
            {
                bool ok = false;
                do
                {
                    Console.Write("Enter {0} number: ", item);
                    try
                    {
                        num[idx] = Convert.ToInt32(Console.ReadLine());
                        ok = true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(">> Error: " + e.Message);
                        Console.WriteLine(">> Please try again");
                    }
                } while (!ok);
                idx++;
            }

            try
            {
                Console.WriteLine("{0} + {1} = {2} ", num[0], num[1], num[0] + num[1]);
                Console.WriteLine("{0} - {1} = {2} ", num[0], num[1], num[0] - num[1]);
                Console.WriteLine("{0} x {1} = {2} ", num[0], num[1], num[0] * num[1]);
                Console.WriteLine("{0} / {1} = {2} ", num[0], num[1], num[0] / num[1]);
                if (num[1] < 0)
                {
                    throw new Exception(
                        string.Format("Integer {0} must be greater than zero", num[1]));
                }
            }
            catch (DivideByZeroException e1)
            {
                Console.WriteLine("Advice: " + e1.Message);
                Console.WriteLine("{0} / {1} = <infinite> ", num[0], num[1]);
            }
            catch (Exception e2)
            {
                Console.WriteLine("Error: " + e2.Message);
            }
            finally
            {
                // Anything here will always be executed, even after exceptions occur
                Console.WriteLine("The End");
            }
        }


        // 2-dimensional Arrays
        static void Do2DimArray()
        {
            AddHeading("Two Dimensional Arrays");

            int[,] numberGrid = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            Console.WriteLine("This is a {0}-Dim Array", numberGrid.Rank);

            for (int i = 0; i < numberGrid.GetLength(0); i++)
            {
                for (int j = 0; j < numberGrid.GetLength(1); j++)
                {
                    Console.WriteLine("Row: {0}; Col: {1}; Value: {2}",
                                      i, j, numberGrid[i, j]);
                }
            }
        }

        // Arrays
        static void DoArray()
        {
            AddHeading("Arrays");
            int[] luckyNumbers = { 5, 14, 27, 8, 17 };
            string[] friends = new string[5];

            friends[0] = "Amy";
            friends[1] = "James";
            friends[2] = "Pamela";
            friends[3] = "Joseph";
            friends[4] = "Barbara";

            for (int idx = 0; idx < luckyNumbers.Length; idx++)
            {
                Console.WriteLine("Friend {0}: {1}", idx + 1, friends[idx]);
                Console.WriteLine("Lucky Number (1): " + luckyNumbers[idx]);
                luckyNumbers[idx] *= 3;
                Console.WriteLine("Lucky Number (2): " + luckyNumbers[idx]);
            }
        }


        // Poem
        static void DoPoem()
        {
            AddHeading("Poem");
            string colour, pluralNoun, celebrity;

            Console.Write("Enter a colour: ");
            colour = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            string line = Console.ReadLine();
            // Make first char uppercase
            pluralNoun = line.Substring(0, 1).ToUpper() + line.Substring(1);

            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are {0}", colour);
            Console.WriteLine("{0} are blue", pluralNoun);
            Console.WriteLine("I LOVE {0}", celebrity);
        }


        // Calculator
        static void DoCalculator()
        {
            AddHeading("Start Calculator");
            bool doCalc = true;
            while (doCalc)
            {
                AddHeading("New Calculation");
                double num1 = 0;
                double num2 = 0;
                var numlist = new List<string> { "first", "next" };

                foreach (string numidx in numlist)
                {
                    bool ok = false;
                    string numstr;
                    while (!ok)
                    {
                        Console.Write("Enter {0} number: ", numidx);
                        numstr = Console.ReadLine();
                        // Alternative: num = Convert.ToInt32(Console.ReadLine());
                        // Alternative: num = Convert.ToDouble(Console.ReadLine());
                        // Following verifies input is a "double" & assigns it to "num"
                        ok = double.TryParse(numstr, out double num);
                        if (!ok) Console.WriteLine("Invalid number - please try again");
                        num1 = (numidx == numlist[0]) ? num : num1;
                        num2 = (numidx == numlist[1]) ? num : num2;
                    }
                }

                Console.WriteLine("{0} + {1} = {2} ", num1, num2, Math.Round(num1 + num2, 4));
                Console.WriteLine("{0} - {1} = {2} ", num1, num2, Math.Round(num1 - num2, 4));
                Console.WriteLine("{0} x {1} = {2} ", num1, num2, Math.Round(num1 * num2, 4));
                Console.WriteLine("{0} / {1} = {2} ", num1, num2, Math.Round(num1 / num2, 4));

                Console.Write("Do you wish to repeat this calculator? (Y/N) ");
                string reply = Console.ReadLine();
                doCalc = (reply.ToLower()[0] == 'y') ? true : false;
            }
        }


        // Strings
        static void DoStrings()
        {
            AddHeading("Strings");
            string phrase = "This is a string\nThis is a new line";
            Console.WriteLine("\n>> Original phrase:\n" + phrase);
            Console.WriteLine("\n>> Lower case phrase: \n" + phrase.ToLower());
            Console.WriteLine("\n>> Does phrase contain 'This' ?: " + phrase.Contains("This"));
            Console.WriteLine(">> Phrase from index 17: " + phrase.Substring(17));
            Console.WriteLine(">> Phrase 4 chars from index 8: " + phrase.Substring(8, 4));
            Console.WriteLine(">> Index of word 'new' in phrase: " + phrase.IndexOf("new"));  // returns "-1" when not found
            Console.WriteLine(">> First char of phrase: " + phrase[0]);
        }


        //Numbers
        static void DoNumbers()
        {
            AddHeading("Numbers");
            Console.WriteLine(35);
            Console.WriteLine(35.7);
            Console.WriteLine("4 + 2 * 7 = {0}", 4 + 2 * 7);
            Console.WriteLine("(4 + 2) * 7 = {0}", (4 + 2) * 7);
            Console.WriteLine("4 + 5.7 = {0}", 4 + 5.7);
            Console.WriteLine("4.34 + 5.7 = {0}", 4.34 + 5.7);
            Console.WriteLine("35 / 5 = {0}", 35 / 5);
            Console.WriteLine("35.6 / 5 = {0}", 35.6 / 5);
            Console.WriteLine("34 % 5 = {0}", 34 % 5);
        }


        // Maths
        static void DoMaths()
        {
            AddHeading("Maths");
            Console.WriteLine("Math.PI = {0}", Math.PI);
            Console.WriteLine("Math.Sqrt(7) = {0}", Math.Sqrt(7));
            Console.WriteLine("Math.Abs(-34.5) = {0}", Math.Abs(-34.5));
            Console.WriteLine("Math.Pow(8,3) = {0}", Math.Pow(8, 3));
            Console.WriteLine("Math.Max(8,3) = {0}", Math.Max(8, 3));
            Console.WriteLine("Math.Min(8,3) = {0}", Math.Min(8, 3));
            Console.WriteLine("Math.Round(5.678) = {0}", Math.Round(5.678, 2));
        }


        // Input
        static void DoInput()
        {
            AddHeading("Input Test");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.Write("Hello {0} - you are {1} years old\n", name, age);
        }


        // Output
        static void DoOutput()
        {
            AddHeading("Output Test");
            string characterName = "John";
            int characterAge = 35;

            Console.WriteLine("There was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge + " years old");
        }


        static void DoSwitch()
        {
            AddHeading("Case Statement");

            int[] num = { 75, 4 };
            int answer = 0;
            string sign = "";
            bool ok;

            do
            {
                ok = true;
                string op = "";
                string[] slist = new string[] { "add", "subtract", "multiply", "divide" };

                Console.WriteLine("Do you wish to: add, subtract, divide or multiply");
                Console.WriteLine("these numbers: {0} and {1}", num[0], num[1]);
                string reply = Console.ReadLine().ToLower();

                foreach (string s in slist) { if (s.StartsWith(reply)) { op = s; } }

                // Console.WriteLine("OP is: " + op);
                switch (op)
                {
                    case "add": answer = num[0] + num[1]; sign = "+"; break;
                    case "subtract": answer = num[0] - num[1]; sign = "-"; break;
                    case "multiply": answer = num[0] * num[1]; sign = "x"; break;
                    case "divide": answer = num[0] / num[1]; sign = "/"; break;
                    default: ok = false; break;
                }
                if (!ok) { DoError("Invalid Choice - please try again"); }
            } while (!ok);

            Console.WriteLine("{0} {1} {2} = {3}", num[0], sign, num[1], answer);

        }


        // Common Variable types
        static void DoVariables()
        {
            AddHeading("Variables");
            // Use backslash to print syntax chars
            string phrase = "This is a string\nThis is a new line";
            Console.WriteLine(phrase.ToUpper());

            char grade = 'A';
            int age = 30;
            int months = 365;
            int monthsInYear = 12;
            double gpa = 3.25831;    // Always include "."
            bool isCorrect = false;

            float ratio = 6.567892f;
            decimal pounds = 4.582m;

            Console.WriteLine("byte range: {0} to: {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("char -    grade: {0}", grade);
            Console.WriteLine("int -     age: {0}", age);
            Console.WriteLine("boolean result: {0} > {1} = {2}", months, age, months > age);
            Console.WriteLine("{0} / {1} = {2}", months, monthsInYear, months / monthsInYear);
            Console.WriteLine("(float){0} / (float){1} = {2}", months, monthsInYear, (float)months / (float)monthsInYear);
            Console.WriteLine("double -  gpa: {0}", gpa);
            Console.WriteLine("bool -    isCorrect: {0}", isCorrect);
            Console.WriteLine("float -   ratio: {0}", ratio);
            Console.WriteLine("decimal - pounds: {0}", pounds);
        }
    }
}