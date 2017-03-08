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
    public class tbl_Staff : BaseBE
    {
        [DataMember]
        public int StaffID { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string MiddleName { get; set; }
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
        public int State { get; set; }
        [DataMember]
        public int Country { get; set; }
        [DataMember]
        public DateTime? DOJ { get; set; }
        [DataMember]
        public DateTime? DOR { get; set; }
        [DataMember]
        public int? StudentgallaryID { get; set; }
        [DataMember]
        public string PreviousExp { get; set; }
        [DataMember]
        public string PreviousExpYears { get; set; }
        [DataMember]
        public string Comments { get; set; }
        [DataMember]
        public bool? IsActive { get; set; }
        [DataMember]
        public string EntryBy { get; set; }
        [DataMember]
        public DateTime? EntryDate { get; set; }
        [DataMember]
        public string LastModifiedBy { get; set; }
        [DataMember]
        public DateTime? LastModifiedDate { get; set; }
        [DataMember]
        public int ClassID { get; set; }
        [DataMember]
        public int SectionID { get; set; }
        [DataMember]
        public string StaffName { get; set; }
        [DataMember]
        public string ListChannelID { get; set; }
        [DataMember]
        public string ChannelName { get; set; }
        
    }

}
