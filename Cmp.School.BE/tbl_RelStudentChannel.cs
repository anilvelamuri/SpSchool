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
    public class tbl_RelStudentChannel : BaseBE
    {
        [DataMember]
        public int? RelStudentId { get; set; }
        [DataMember]
        public int StudentID { get; set; }
        [DataMember]
        public int ChannelID { get; set; }
        [DataMember]
        public string EntryBy { get; set; }
        [DataMember]
        public DateTime? EntryDate { get; set; }
        [DataMember]
        public string LastModifiedBy { get; set; }
        [DataMember]
        public DateTime? LastModifiedDate { get; set; }
        [DataMember]
        public string ListChannelID { get; set; }
    }
}
