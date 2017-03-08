using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Cmp.School.BE
{
    
    
    [DataContract]
    public abstract class BaseBE
    {
        //variable and default values
        private ListRowState _rowState= ListRowState.Unchange;

       

        public enum ListRowState
        {
            Unchange = 0,
            Added = 1,
            Updated = 2,
            Deleted = 3,
        };

        [DataMember]
        public ListRowState RowState
        {
            get { return _rowState; }
            set { _rowState = value; }
        }

        
    }
}
