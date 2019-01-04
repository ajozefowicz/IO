using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfWypozyczeniaDoBazy
{
    [DataContract]
    public class Wypozyczenie
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public int idEgzemplarza { get; set; }
        [DataMember]
        public string idUsera { get; set; }
        [DataMember]
        public DateTime dataWypozyczyenia { get; set; }
        [DataMember]
        public DateTime dataZwrotu { get; set; }
        [DataMember]
        public bool czyAktualne { get; set; } // true , gdy false to archiwalne

        //tu będzie gidzieś może trza zainstalować te liczniki do liczenia popiularnosci


    }
}
