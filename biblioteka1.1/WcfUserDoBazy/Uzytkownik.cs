using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

using System.Web.DynamicData;
using System.ComponentModel.DataAnnotations;

namespace WcfUserDoBazy
{

    [DataContract]
    public abstract class Uzytkownik
    {
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string haslo { get; set; }
        [DataMember]
        public string imie { get; set; }
        [DataMember]
        public string nazwisko { get; set; }
        [DataMember]
        public string pesel { get; set; } //string bo w incie sie nie zmiesci
        [DataMember]
        [DataType(DataType.EmailAddress)]
        public string emaileee { get; set; }


        //
        [DataMember]
        public int limit { get; set; }
        [DataMember]
        public int maxCzasWypozyczenia { get; set; }
        [DataMember]
        public string kategoria { get; set; }



        public override string ToString()
        {
            return id + " " + haslo + " " + imie + " " + nazwisko + " " + pesel + " " + emaileee;
        }


    }
}
