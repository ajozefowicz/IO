using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfRezerwacjaDoBazy
{

    [DataContract]
    public class Rezerwacja
    {

        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string idUsera { get; set; }
        [DataMember]
        public int idEgzemplarza { get; set; }
        [DataMember]
        public string tytul { get; set; }
        [DataMember]
        public string nazwiskoAutora { get; set; }
        [DataMember]
        public DateTime dataZwrotu { get; set; }


    }
}
