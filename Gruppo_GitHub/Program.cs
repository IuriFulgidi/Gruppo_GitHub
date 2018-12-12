using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppo_GitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            //inizializzano le variabili
            string risultato="";
            int num = 255;

            //si chiede all' utente il numero da convertire
            do
            {
                Console.WriteLine("inserire il numero da convertire");
                num = Convert.ToInt32(Console.ReadLine());
                if(num<0)
                {
                    Console.WriteLine("inserire un numero positivo");
                }
            }
            while (num < 0);

            //si converte il numero
            while(num>1)
            {
                int resto = num % 2;
                risultato = Convert.ToString(resto) + risultato;
                num = num / 2;
            }

            //si stampa il risultato
            risultato = Convert.ToString(num) + risultato;
            Console.WriteLine($"il numero binario è {risultato}");
        }
    }
}
