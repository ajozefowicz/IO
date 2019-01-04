using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfEgzemplarzDoBazy
{

   public class Audiobook : Egzemplarz
    {
        [DataMember]
        public int iliscMinut { get; set; }
        [DataMember]
        public string ktoCzyta { get; set; }



    }
}
