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
    public class tbl_StateMaster:BaseBE
    {
        private int _StateID, _CountryID;

       
        private DateTime? _EntryDate, _ModifiedDate;
        private string _StateName, _EntryBy, _ModifiedName, _ModifiedBy;

        [DataMember]
        public string ModifiedBy
        {
            get { return _ModifiedBy; }
            set { _ModifiedBy = value; }
        }

        [DataMember]
        public int CountryID
        {
            get { return _CountryID; }
            set { _CountryID = value; }
        }

         [DataMember]
        public DateTime? ModifiedDate
        {
            get { return _ModifiedDate; }
            set { _ModifiedDate = value; }
        }
         [DataMember]
        public DateTime? EntryDate
        {
            get { return _EntryDate; }
            set { _EntryDate = value; }
        }
         [DataMember]
        public int StateID
        {
            get { return _StateID; }
            set { _StateID = value; }
        }


         [DataMember]
        public string ModifiedName
        {
            get { return _ModifiedName; }
            set { _ModifiedName = value; }
        }
         [DataMember]
        public string EntryBy
        {
            get { return _EntryBy; }
            set { _EntryBy = value; }
        }
         [DataMember]
        public string StateName
        {
            get { return _StateName; }
            set { _StateName = value; }
        }
    }
}
