using System;
/*I prodotti trattati da un'erboristeria sono memorizzati in 5 vettori paralleli.
codici -> codice di ciascun prodotto (ogni codice è una stringa)
nomi->nome del prodotto
classi -> tipologia di prodotto (cosmetici, integratori, infusi...)
prezzi->prezzo del prodotto



Caricati i vettori (almeno due prodotti per classe),
sviluppare le seguenti richieste:
a.stampare i dati relativi al prodotto di prezzo massimo*/

namespace Erboristeria
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] indice = new int[]{ 0, 1, 2, 3 };
            string[] codice = new string[] { "A1", "A2", "B1", "B2", "C1", "C2" };
            string[] nome = new string[] { "rossetto", "mascara","sonno","concentrazione", "camomilla", "the" };
            string[] categoria = new string[] { "cosmetico", "cosmetica", "integratore", "integratore","tisana","tisana" };
            double[] prezzo = new double[] {1.0, 3.8, 5, 4.2, 10.0, 1.3 };
            int c = codice.Length;
            int n = nome.Length;
            int cat = categoria.Length;
            int p = prezzo.Length;

            double max;
            int indice;

            for (int i=0; i<5; i++)
            {
                if (prezzo[i+1] < prezzo[i])
                {
                    max = prezzo[i];
                    indice = i;

                    Console.WriteLine($"l'elemento massimo {max} è il numero {indice} del vettore prezzo");
                    Console.WriteLine("I dati del prodotto più costoso sono:");
                    Console.WriteLine($"codice : {codice[indice]} nome: {nome[indice]}");
                    Console.WriteLine($"categoria: {categoria[indice]}");

                }
                else
                {
                    continue;
                    //Console.WriteLine($"il massimmo è {max}");
                    //Console.WriteLine($"l'elemento massimo è il numero {indice} del vettore prezzo");
                }
            }
            //Console.WriteLine($"il massimmo è {max}");
            

        }
    }
}
