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
    public class tbl_HolidayList : BaseBE
    {
        [DataMember]
        public int HolidayID { get; set; }
        [DataMember]
        public string HeadLine { get; set; }
        [DataMember]
        public string Intro { get; set; }
        [DataMember]
        public string Link { get; set; }
        [DataMember]
        public int? StatusID { get; set; }
        [DataMember]
        public string ApprovedBy { get; set; }
        [DataMember]
        public DateTime? ApprovedDate { get; set; }
        [DataMember]
        public string EntryBy { get; set; }
        [DataMember]
        public DateTime? EntryDate { get; set; }
        [DataMember]
        public string LastModifiedBy { get; set; }
        [DataMember]
        public DateTime? LastModifiedDate { get; set; }
        [DataMember]
        public string ChannelName { get; set; }
        [DataMember]
        public string StatusName { get; set; }
        [DataMember]
        public string ListChannelID { get; set; }
        [DataMember]
        public DateTime? FromDate { get; set; }
        [DataMember]
        public DateTime? ToDate { get; set; }
    }
}
