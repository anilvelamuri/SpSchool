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
    public class tbl_SubjectMaster:BaseBE
    {
        [DataMember]
        public int SubjectID { get; set; }
        [DataMember]
        public int? ClassID { get; set; }
        [DataMember]
        public string SubjectName { get; set; }
        [DataMember]
        public string EntryBy { get; set; }
        [DataMember]
        public DateTime? EntryDate { get; set; }
        [DataMember]
        public string LastModifiedBy { get; set; }
        [DataMember]
        public DateTime? LastModifiedDate { get; set; }
        [DataMember]
        public string ClassName { get; set; }
    }

}
