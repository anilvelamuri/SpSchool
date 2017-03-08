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
    public class tbl_AlertDetails:BaseBE
    {
        [DataMember]
        public int AlertID { get; set; }
        [DataMember]
        public int? ClassID { get; set; }
        [DataMember]
        public int? SectionID { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Link { get; set; }
        [DataMember]
        public int? ChannelID { get; set; }
        [DataMember]
        public int? StatusID { get; set; }
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
        [DataMember]
        public string SectionName { get; set; }
        [DataMember]
        public string ChannelName { get; set; }
         [DataMember]
        public string StatusName { get; set; }

         [DataMember]
         public string ApprovedBy { get; set; }
         [DataMember]
         public DateTime? ApprovedDate { get; set; }
         [DataMember]
         public string ListChannelID { get; set; }
        
    }

}
