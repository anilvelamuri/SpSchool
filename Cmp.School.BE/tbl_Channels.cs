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
    public class tbl_Channels : BaseBE
    {
        [DataMember]
        public int ChannelID { get; set; }
        [DataMember]
        public string ChannelName { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string EntryBy { get; set; }
        [DataMember]
        public DateTime? EntryDate { get; set; }
        [DataMember]
        public string LastModifiedBy { get; set; }
        [DataMember]
        public DateTime? LastModifiedDate { get; set; }
        [DataMember]
        public bool IsWholeSchool { get; set; }
        [DataMember]
        public bool IsStaff { get; set; }
    }

}
