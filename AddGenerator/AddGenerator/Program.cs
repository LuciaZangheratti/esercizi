using System;

namespace AddGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressGenerator risultato;
            Console.WriteLine("Inserisci l'indirizzo ip ");

            string risposta = Console.ReadLine();
            risultato = new AddressGenerator(risposta);

            Console.WriteLine(risultato.generateIPv4());
            Console.WriteLine(risultato.generateSubnet());

            Console.ReadLine();
        }
    }
}
