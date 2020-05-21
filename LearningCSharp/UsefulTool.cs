using System;

namespace LearningCSharp
{
    // As "static" cannot create instance objects of this class
    static class UsefulTool
    {
        public static void DoError(string msg)
        {
            Console.WriteLine("Error: " + msg);
        }

        public static void SayHi(string name)
        {
            Console.WriteLine("Hi {0} - how are you today?", name);
        }


        public static void WrittenBy(string name)
        {
            Console.WriteLine("This song is written by: " + name);
        }


        // Applies and returns input string with title case
        public static void AddHeading(string title)
        {
            string[] words = title.Split(' ');
            title = "";

            foreach (var word in words)
            {
                title += " " + word.Substring(0, 1).ToUpper() + word.Substring(1);
            }
            Console.WriteLine("\n>>{0}:", title);
        }


        // Enable inputting, checking and return of a "double" value
        // Parameters: (1) Console text; (2) Nullable minimum value; (3) Nullable maximum value
        public static double InputNumber(string text, double? min, double? max)
        {
            bool ok = false;
            double num = 0.0;
            string range;

            // Number range display
            if (min.HasValue && max.HasValue) { range = " (" + min + "-" + max + ")"; }
            else if (max.HasValue) { range = " (<=" + max + ")"; }
            else if (min.HasValue) { range = " (>=" + min + ")"; }
            else range = "";

            if (!min.HasValue) { min = double.MinValue; }
            if (!max.HasValue) { max = double.MaxValue; }

            if (string.IsNullOrEmpty(text)) { text = "Input a number"; }

            while (!ok)
            {
                Console.Write("{0}{1}: ", text, range);
                string numstr = Console.ReadLine();
                ok = double.TryParse(numstr, out num);
                ok = (ok && num >= min && num <= max);
                if (!ok) Console.WriteLine("Invalid input - please try again");
            }
            return num;
        }


        // Enable inputting, checking and return of an integer
        // Parameters: (1) Console text; (2) Nullable minimum value; (3) Nullable maximum value
        public static int InputInteger(string text, int? min, int? max)
        {
            bool ok = false;
            int num = 0;
            string range;

            // Number range display
            if (min.HasValue && max.HasValue) { range = " (" + min + "-" + max + ")"; }
            else if (max.HasValue) { range = " (<=" + max + ")"; }
            else if (min.HasValue) { range = " (>=" + min + ")"; }
            else range = "";

            if (!min.HasValue) { min = int.MinValue; }
            if (!max.HasValue) { max = int.MaxValue; }

            if (string.IsNullOrEmpty(text)) { text = "Input an integer"; }
            while (!ok)
            {
                Console.Write("{0}{1}: ", text, range);
                string numstr = Console.ReadLine();
                ok = int.TryParse(numstr, out num);
                ok = (ok && num >= min && num <= max);
                if (!ok) Console.WriteLine("Invalid input - please try again");
            }
            return num;
        }

    }
}
