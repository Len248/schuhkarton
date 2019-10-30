using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anfangsaufgabe
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] paketListe = new string[5] { "Nike", "421684", "adidas", "-42", "1234567" };
            for (int i = 0; i < 5; i++)
            {
                if (paketListe[i] == "Nike" || paketListe[i] == "adidas")
                {
                    Console.WriteLine("schuhkarton");
                }
                else if (Convert.ToInt32(paketListe[i]) > 0 && Convert.ToInt32(paketListe[i]) < 1000000)
                {
                    Console.WriteLine("essenspaket");
                }
                else
                {
                    Console.WriteLine("Alles andere!");
                }
            }

        }
    }
}
