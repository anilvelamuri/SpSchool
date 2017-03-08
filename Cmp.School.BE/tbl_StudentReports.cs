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
    public class tbl_StudentReports : BaseBE
    {
        [DataMember]
        public int SreportID { get; set; }
        [DataMember]
        public int? StudentID { get; set; }
        [DataMember]
        public int? ReportCategoryID { get; set; }
        [DataMember]
        public byte[] ReportImage { get; set; }
        [DataMember]
        public string Uploadedby { get; set; }
        [DataMember]
        public DateTime? Uploadeddate { get; set; }
        [DataMember]
        public string EntryBy { get; set; }
        [DataMember]
        public DateTime? EntryDate { get; set; }
        [DataMember]
        public string LastModifiedBy { get; set; }
        [DataMember]
        public DateTime? LastModifiedDate { get; set; }

    }

}
