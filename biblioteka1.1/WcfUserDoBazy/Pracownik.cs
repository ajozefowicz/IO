using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfUserDoBazy
{

    [DataContract]
    public class Pracownik : Uzytkownik
    {
        [DataMember]
        public string stanowisko { get; set; }
    }
}
