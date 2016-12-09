using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {

            //wersja I
            Console.WriteLine("Zawartosc pierwszego pliku"); 
            StreamReader sr = null;
            string path = "plik1.txt";
            try
            {
                sr = File.OpenText(path);
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                    Console.WriteLine("Stream closed.");
                }
            }
            //wersja II
            Console.WriteLine("Zawartosc drugiego pliku"); 
            string path2 = "plik2.txt";
            try
            {
                using (StreamReader sr2 = File.OpenText(path2))
                {
                    string s2 = "";
                    while ((s2 = sr2.ReadLine()) != null)
                    {
                        Console.WriteLine(s2);
                    }
                }
            }
            catch (Exception ex){
                Console.WriteLine(ex.ToString());
            }


            Console.ReadKey();

        }
    }
}
