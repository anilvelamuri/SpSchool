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
    public class tbl_SLogoName : BaseBE
    {
        [DataMember]
        public string SchoolName { get; set; }
        [DataMember]
        public string SchoolLogoLink { get; set; } 
    }

}
