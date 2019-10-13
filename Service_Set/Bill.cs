using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Service_Set
{
    [DataContract]
    public class Bill
    {
        [DataMember]
        public DateTime tglpesan { get; set; }
        [DataMember]
        public int idmenu { get; set; }
        [DataMember]
        public string jmlpesan { get; set; }
        [DataMember]
        public string ttlhrg { get; set; }
    }
}