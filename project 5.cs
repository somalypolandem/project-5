using System;
using System.IO;

namespace Journal
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Captain Houston's diary");
            while (true)
            {
                Console.WriteLine("Write 'start' to begin writting & 'stop' to sign out.");
                string read = Console.ReadLine();
                if (read == "start")
                {
                    Diary();
                }
                else
                if (read == "stop")
                {
                    Environment.Exit(0);
                }

            }


            static void Diary()
            {
                Console.Clear();
                Console.Write("Dear diary... \t");
                string file = "Captainsdiary.txt";

                using (StreamWriter Diary = File.Exists(file) ? File.AppendText(file) : new StreamWriter("captainsdiary.txt"))
                {
                    Diary.Flush();
                    Diary.WriteLine($"Captain Houston's Log\n Date: {DateTime.Now} ");


                    while (true)
                    {
                        string input = Console.ReadLine();

                        if (input == "stop")
                        {
                            Diary.Flush();

                            Environment.Exit(0);
                        }

                        Diary.WriteLine(input);
                        Diary.WriteLine("Cptn H.~");


                    }

                }

            }
        }
    }
}
