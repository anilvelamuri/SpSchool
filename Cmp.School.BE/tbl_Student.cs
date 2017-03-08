using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.IO;

namespace Cmp.School.BE
{
    [DataContract]
    public class tbl_Student : BaseBE
    {
        [DataMember]
        public int StudentID { get; set; }
        [DataMember]
        public string StudentFirstName { get; set; }
        [DataMember]
        public string StudentLastName { get; set; }
        [DataMember]
        public string StudentMiddleName { get; set; }
        [DataMember]
        public string MobileNumber { get; set; }
        [DataMember]
        public string LandPhoneNumber { get; set; }
        [DataMember]
        public string EmergencyContact { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string OtherContactNo { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public Int32 State { get; set; }
        [DataMember]
        public Int32 Country { get; set; }
        [DataMember]
        public DateTime? DateofJoin { get; set; }
        [DataMember]
        public int? ClassID { get; set; }
        [DataMember]
        public int? SectionID { get; set; }
        [DataMember]
        public int? StudentgallaryID { get; set; }
        [DataMember]
        public string EntryBy { get; set; }
        [DataMember]
        public DateTime? EntryDate { get; set; }
        [DataMember]
        public string LastModifiedBy { get; set; }
        [DataMember]
        public DateTime? LastModifiedDate { get; set; }

        [DataMember]
        public int ImageID { get; set; }

        [DataMember]
        public string Channel { get; set; }
        [DataMember]
        public DateTime? DOB { get; set; }
        [DataMember]
        public string StudentRecordNumber { get; set; }
        [DataMember]
        public string StudentName { get; set; }
        [DataMember]
        public string RollNumber { get; set; }
        [DataMember]
        public string ClassName { get; set; }
        [DataMember]
        public string SectionName { get; set; }
        [DataMember]
        public string TeacherName { get; set; }
        [DataMember]
        public string ParentName { get; set; }
        [DataMember]
        public string Relation { get; set; }
         [DataMember]
        public string ChannelName { get; set; }
        [DataMember]
         public int? RelStudentId { get; set; }
        
    }

}
