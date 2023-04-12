using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tour
{
    //interfacce
    public interface CD
    {
        void insert(IComparable key, Object attribute);
        Object find(IComparable key);
        Object remove(IComparable key);
    }
    public interface Container
    {
        bool isEmpty();
        void makeEmpty();
        int size();
    }
    public class TourOperator : CD, Container
    { /*implements Dictionary*/ // classe Tour

        private string nextClientCode;          //dichiaro le variabili per il codice
        Dictionary<IComparable, object> dizionario;           //creo il dizionario
        public TourOperator(string initialClientCode)       //costruttore che prende in input il codice iniziale
        {
            this.nextClientCode = initialClientCode;
            this.dizionario = new Dictionary<IComparable, object>();
        }
        public void add(string nome, string dest)       //metodo per aggiungere elementi al dizionario
        {
            string initialClientCode = this.nextClientCode;
            Client cliente = new Client(nome, dest);
            dizionario.Add(nextClientCode, cliente);
            incrementoCode();

        }

        public string toString()        //metodo per la visualizzazione degli elementi
        {
            string stringa = ""; // mi serve per la concatenazione 

            foreach (KeyValuePair<IComparable, object> cliente in this.dizionario)
            {
                string codice = cliente.Key.ToString();
                Client temp = (Client)cliente.Value;
                //concatena stringa
                stringa += codice + " : " + temp.name + " : " + temp.dest + "\n";
            }
            //ritorna la stringa
            return stringa;
        }

        // Implementazione interfaccia CD
 
        public void insert(IComparable key, object attribute)
        {
            //controlla se esiste già
            if (this.dizionario.ContainsKey(key))
            {
                this.dizionario[key] = attribute;
            }
            //altrimenti crea
            else
            {
                this.dizionario.Add(key, attribute);
            }
        }


        public object find(IComparable key)
        {
 
            if (this.dizionario.ContainsKey(key))
            {
                return this.dizionario[key];
            }
            else
            {
                throw new System.Collections.Generic.KeyNotFoundException();
            }
        }
        public object remove(IComparable key)
        {
            //Se trova da rimuovere
            if (this.dizionario.ContainsKey(key))
            {
                object attribute = this.dizionario[key];
                this.dizionario.Remove(key);
                return attribute;
            }
           
            else
            {
                throw new System.Collections.Generic.KeyNotFoundException();
            }
        }
        private void incrementoCode()           //metodo per il corretto incremento del codice
        {
            char carat = code[0];
            int n = int.Parse(code.Substring(1));
            //controlla se numero supera 999
            if (n < 999)
                n++;
            else
            {
                carat++;
                //controlla se i caratteri superano Z
                if (carat > 'Z')
                {
                    throw new Exception("Contenitore pieno");
                }
                n = 0;
            }
            string newCodice = carat + n.ToString();
            //ritorna nuova codice
            return newCodice;
        }

        // Implementazione interfaccia Container
        //Metodo isEmpty
        public bool isEmpty()
        {
            return this.dizionario.Count == 0;
        }

        //Metodo makeEmpty
        public void makeEmpty()
        {
            this.dizionario.Clear();
        }

        //Metodo size
        public int size()
        {
            return this.dizionario.Count;
        }
        // classi interne
        private class Client
        {
            public String name; // nome del cliente
            public String dest; // destinazione del viaggio
            public Client(String aName, String aDest)
            {
                name = aName;
                dest = aDest;
            }
            public override string ToString()
            {
                return name + ":" + dest;
            }
        }
        private class Coppia : IComparable
        {
            public string code;
            public Client client;
            Coppia(String aCode, Client aClient)
            {
                code = aCode;
                client = aClient;
            }

            //Metodo compare
            public int CompareTo(object obj)
            {
                Coppia tmpC = (Coppia)obj;
                return this.code.CompareTo(tmpC.code);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string destinazione;
            //chiede al utente il codice iniziale
            Console.WriteLine("Inserisci Il codice");
            //inizializza oggeto tour1
            TourOperator t1 = new TourOperator(Console.ReadLine());
            //ciclo
            while (true)
            {
                //chiede al utente il nome
                Console.WriteLine("Cosa vuoi fare?");
                Console.WriteLine("[1]Inserisci");                  
                Console.WriteLine("Insersci il nome: ");
                nome = Console.ReadLine();
                //se l'utente inserisce 1
                if (nome == "1")
                Console.WriteLine("Insersci la destinazione: ");
                destinazione = Console.ReadLine();
                //aggiunge al t1
                t1.add(nome, destinazione);
            }
            //stampa a video il contenuto del t1
            Console.WriteLine(t1.ToString());
            Console.ReadLine();
        }
    }
        
            



        }
        
      