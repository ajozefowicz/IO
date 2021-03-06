﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfEgzemplarzDoBazy
{


        [DataContract]
        public class Ksiazka
        {
            [DataMember]
            public int id { get; set; }
            [DataMember]
            public string tytul { get; set; }
            [DataMember]
            public bool stan { get; set; }
            [DataMember]
            public string rodzaj { get; set; } //mozna posniej zmienic na enuma, ale jak z bazą??
            [DataMember]
            public int licznikWypozyczen { get; set; }
        [DataMember]

            //public DateTime? dataWypozyczenia = null;
        public DateTime?  dataWypozyczenia { get; set; } //Nullable<DateTime>

        [DataMember]

        //public Nullable<DateTime> dataZwrotu = null;
            public Nullable<DateTime> dataZwrotu { get; set; }
            [DataMember]
            public int licznikPrzedluzen { get; set; }
            [DataMember]
            public int iloscStron { get; set; }
            [DataMember]
            public string imieAutora { get; set; }
            [DataMember]
            public string nazwiskoAutora { get; set; }
            [DataMember]
            public string nrISBN { get; set; }

            [DataMember]
            public Queue<int> rezerwacje { get; set; } //int zmienic na id czyeltnika jak już bedzie czytelnik


            public string ToString1()
            {
                return id + " " + tytul + " " + stan + " " + imieAutora + " " + nazwiskoAutora + " " + nrISBN;
            }


            public override string ToString()
            {
                return id + " " + tytul + " " + stan + " " + rodzaj + " " + licznikWypozyczen + " " + licznikPrzedluzen + " " + iloscStron
                    + " " + imieAutora + " " + nazwiskoAutora + " " + nrISBN;
            }

        }


}
