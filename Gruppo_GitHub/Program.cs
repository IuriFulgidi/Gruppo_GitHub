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
            int ValBase;

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

            //si chiede all' utente la base
            do
            {
                Console.WriteLine("inserire la base tra 2,8 e 16");
                ValBase = Convert.ToInt32(Console.ReadLine());
                if (ValBase!=2 && ValBase != 8 && ValBase != 16)
                {
                    Console.WriteLine("inserire un numero tra 2,8,16");
                }
            }
            while (ValBase != 2 && ValBase != 8 && ValBase != 16);

            //si converte il numero
            while (num>1)
            {
                int resto = num % ValBase;
                risultato = Convert.ToString(resto) + risultato;
                num = num / ValBase;
            }

            //si stampa il risultato
            if (num != 0)
            {
                risultato = Convert.ToString(num) + risultato;
            }
            Console.WriteLine($"il numero binario è {risultato}");

            Console.ReadLine();
        }
    }
}
