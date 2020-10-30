using System;
using System.IO;

namespace cw2
{
    class Program
    {
        static void Main(string[] args)
        {
            String file = "dane.csv";
            using (StreamReader stream = new StreamReader(file))
            {
                string line = null;
                while ((line = stream.ReadLine()) != null)
                {
                    string[] student = line.Split(',');
                    var st = new Student
                    {
                        Imie = student[0],
                        Nazwisko = student[1],
                        Kierunek = student[2],
                        Tryb = student[3],
                        NrIndeksu = student[4],
                        DataUrodzenia = student[5],
                        Email = student[6],
                        ImieMatki = student[7],
                        ImieOjca = student[8]

                    };
                }
                Console.WriteLine("Hello World!");
            }
        }
    }
}
