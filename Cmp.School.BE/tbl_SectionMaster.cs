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
    public class tbl_SectionMaster:BaseBE
    {
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
        public string UploadReport { get; set; }
        [DataMember]
        public int? StaffID { get; set; }
        [DataMember]
        public int? TermID { get; set; }
        [DataMember]
        public string TermName { get; set; }
        [DataMember]
        public int? StudentID { get; set; }
        
        
    }

}
