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
    public class tbl_PhotoGalary : BaseBE
    {
        [DataMember]
        public int ImageID { get; set; }
        [DataMember]
        public byte[] Image { get; set; }
        [DataMember]
        public string ImageText { get; set; }
        [DataMember]
        public int? CategoryID { get; set; }
        [DataMember]
        public string Caption { get; set; }
        [DataMember]
        public DateTime? UploadDate { get; set; }
        [DataMember]
        public string EntryBy { get; set; }
        [DataMember]
        public DateTime? EntryDate { get; set; }
        [DataMember]
        public string LastModifiedBy { get; set; }
        [DataMember]
        public DateTime? LastModifiedDate { get; set; }
        [DataMember]
        public Int32 ID { get; set; }
        [DataMember]
        public bool isstaff { get; set; }

    }

}
