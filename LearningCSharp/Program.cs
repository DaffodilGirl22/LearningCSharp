
using System;
using System.IO.Enumeration;
using System.Reflection;
using System.Reflection.Metadata;
using static LearningCSharp.UsefulTool;


namespace LearningCSharp
{
    enum MonthsOfYear
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }


    class Program
    {
        enum ProgMethod
        {
            None,
            DoUsefulTools,
            DoStruct,
            DoInheritance,
            DoDate,
            DoBook,
            DoSong,
            DoFilms,
            DoStudent,
            DoException,
            DoArray,
            Do2DimArray,
            DoPoem,
            DoCalculator,
            DoSwitch,
            DoVariables,
            DoStrings,
            DoNumbers,
            DoMaths,
            DoOutput,
            DoInput
        }


        static void Main(string[] args)
        {

            Type classType = MethodBase.GetCurrentMethod().DeclaringType;  // <Program> class
            string NameSpace = classType.Namespace;
            Console.WriteLine(">> Namespace: {0}", NameSpace);
            string option = listOptions();

            // Loop through all the methods
            foreach (string fname in Enum.GetNames(typeof(ProgMethod)))
            {
                string[] classList = new string[] { "Giraffe" };
                if (fname != option) { continue; }
                ProgMethod methVal;
                MethodInfo method;

                try
                {
                    // Is the method listed in "ProgMethod"
                    methVal = (ProgMethod)Enum.Parse(typeof(ProgMethod), fname);
                    bool ok = false;

                    foreach (string myclass in classList)
                    {
                        // Derive the method container type - a method of class "Program"
                        Type type = Type.GetType(NameSpace + '.' + myclass);

                        // Define the method modifiers, ie. non public and static
                        // NB. "flags" is result of a binary "OR"
                        BindingFlags flags = BindingFlags.NonPublic | BindingFlags.Static;

                        // Derive the method
                        method = type.GetMethod((fname), flags);
                        if (method != null)
                        {
                            method.Invoke(null, null);
                            ok = true;
                        }
                    }
                    if (!ok) { throw new Exception(); }
                }
                catch
                {
                    DoError(string.Format("Unknown Method Requested: {0}", fname));
                    methVal = ProgMethod.None;
                }

                if (methVal != ProgMethod.DoCalculator) { Console.ReadLine(); }
            }
        }


        static string listOptions ()
        {
            int min = int.MaxValue;
            int max = 0;
            Console.WriteLine("\n>> Please select method option:");
            foreach (ProgMethod o in Enum.GetValues(typeof(ProgMethod)))
            {
                if ((int)o != 0)
                { 
                    Console.WriteLine("{0,3}. {1}", (int)o, o);
                    max = Math.Max(max, (int)o);
                    min = Math.Min(min, (int)o);
                }
            }

            int opt = InputInteger("Input option number", min, max);
            return ((ProgMethod)opt).ToString();
        }

    }
}
