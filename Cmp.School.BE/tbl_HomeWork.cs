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
    public class tbl_HomeWork : BaseBE
    {
        [DataMember]
        public int HomeworkID { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public int? ClassID { get; set; }
        [DataMember]
        public int? SectionID { get; set; }
        [DataMember]
        public int? SubjectID { get; set; }
        [DataMember]
        public string Link { get; set; }
        [DataMember]
        public byte[] HFile { get; set; }
        [DataMember]
        public string TextOnly { get; set; }
        [DataMember]
        public int? ChannelID { get; set; }
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
        public string SubjectName { get; set; }
        [DataMember]
        public string ChannelName { get; set; }
        [DataMember]
        public string StudentName { get; set; }
        [DataMember]
        public string MobileNumber { get; set; }
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string sid { get; set; }
        [DataMember]
        public string Url { get; set; }
          [DataMember]
        public DateTime? HomeDate { get; set; }
          [DataMember]
          public string ListChannelID { get; set; }
        
    }

}
