using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace Cmp.School.BE
{
    [DataContract]
   public class tbl_Terms:BaseBE
    {
       [DataMember]
       public int TermID { get; set; }

       [DataMember]
       public string TermName { get; set; }
    }
}
