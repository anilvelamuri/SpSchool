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
    public class tbl_CityMastercs
    {
         private int _CityID, _StateID;
         private DateTime? _EntryDate, _ModifiedDate;
              private  string  _CityName;

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
public int CityID
{
  get { return _CityID; }
  set { _CityID = value; }
}
        
[DataMember]
public string CityName
{
  get { return _CityName; }
  set { _CityName = value; }
}
         

    }
}
