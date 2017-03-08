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
    public class tbl_StudentAttendanceDashBoard : BaseBE
    {

        [DataMember]
        public int StudentID { get; set; }
        [DataMember]
        public int? TillNow { get; set; }
        [DataMember]
        public int? Attended { get; set; }
        [DataMember]
        public string  StudentName { get; set; }

     
     
    }

}
