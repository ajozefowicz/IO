using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfEgzemplarzDoBazy
{

    [DataContract]
    public class Ksiazka : Egzemplarz
    {



        [DataMember]
        public string imieAutora { get; set; }
        [DataMember]
        public string nazwiskoAutora { get; set; }
        [DataMember]
        public int iloscStron { get; set; }
        [DataMember]
        public string nrISBN { get; set; }





        /*
        public override string ToString()
        {
            return id + " " + tytul + " " + stan + " " + rodzaj + " " + licznikWypozyczen + " " + licznikPrzedluzen + " " + iloscStron
                + " " + imieAutora + " " + nazwiskoAutora + " " + nrISBN;
        }
        */






    }
}
