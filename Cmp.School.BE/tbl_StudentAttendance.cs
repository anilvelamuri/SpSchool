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
    public class tbl_StudentAttendance : BaseBE
    {
        [DataMember]
        public int StuAttendanceID { get; set; }
        [DataMember]
        public int? StudentID { get; set; }
        [DataMember]
        public int? ClassID { get; set; }
        [DataMember]
        public int? SectionID { get; set; }
        [DataMember]
        public DateTime? AttDateTime { get; set; }
        [DataMember]
        public bool? IsPresent { get; set; }
        [DataMember]
        public string ApsentReason { get; set; }
        [DataMember]
        public DateTime? ReportedDate { get; set; }
        [DataMember]
        public string EntryBy { get; set; }
        [DataMember]
        public DateTime? EntryDate { get; set; }
        [DataMember]
        public string LastModifiedBy { get; set; }
        [DataMember]
        public DateTime? LastModifiedDate { get; set; }
        [DataMember]
        public string StudentName { get; set; }
        [DataMember]
        public string ClassName { get; set; }
        [DataMember]
        public string SectionName { get; set; }

        [DataMember]
        public int? TotalStudent { get; set; }
        [DataMember]
        public int? TotalPresent { get; set; }
        [DataMember]
        public int? TotalAbsent { get; set; }
    }

}
