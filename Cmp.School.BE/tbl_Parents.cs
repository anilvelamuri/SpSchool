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
    public class tbl_Parents : BaseBE
    {
        [DataMember]
        public int ParentID { get; set; }
        [DataMember]
        public int? StudentID { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string MiddleName { get; set; }
        [DataMember]
        public string Relation { get; set; }
        [DataMember]
        public string Phonenumber { get; set; }
        [DataMember]
        public string email { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public int State { get; set; }
        [DataMember]
        public int Country { get; set; }
        [DataMember]
        public string EmergencyContact { get; set; }
        [DataMember]
        public string EntryBy { get; set; }
        [DataMember]
        public DateTime? EntryDate { get; set; }
        [DataMember]
        public string LastModifiedBy { get; set; }
        [DataMember]
        public DateTime? LastModifiedDate { get; set; }
        [DataMember]
        public bool? SameAddress { get; set; }


    }

}
