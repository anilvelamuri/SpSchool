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
    public class tbl_LunchDetails:BaseBE
    {
        [DataMember]
        public int LunchID { get; set; }
        [DataMember]
        public int YearID { get; set; }
        [DataMember]
        public DateTime? DateMonth { get; set; }
        [DataMember]
        public string BreakFast { get; set; }
        [DataMember]
        public string Lunch { get; set; }
        [DataMember]
        public byte[] UploadExcel { get; set; }
        [DataMember]
        public string EntryBy { get; set; }
        [DataMember]
        public DateTime? EntryDate { get; set; }
        [DataMember]
        public string LastModifiedBy { get; set; }
        [DataMember]
        public DateTime? LastModifiedDate { get; set; }
         [DataMember]
        public string Name { get; set; }
        
    }

}
