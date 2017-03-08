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
    public class tbl_StudentAttachment : BaseBE
    {
        [DataMember]
        public int StudentAttachmentID { get; set; }
        [DataMember]
        public int SectionID { get; set; }
        [DataMember]
        public int? ClassID { get; set; }
        [DataMember]
        public string SectionName { get; set; }
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
        public string StudentName { get; set; }
        [DataMember]
        public string FacultyName { get; set; }
        [DataMember]
        public string AttachmentName { get; set; }
        [DataMember]
        public string AttahmenType { get; set; }
        [DataMember]
        public byte[] AttachmentBlog { get; set; }
        [DataMember]
        public int? StaffID { get; set; }
        [DataMember]
        public int TermID { get; set; }
        [DataMember]
        public int? StudentID { get; set; }
    }
}
