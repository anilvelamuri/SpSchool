using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Cmp.School.BE
{
   [DataContract]
   public class tbl_MsgFrom:BaseBE
    {
        //variable and default values
        private int _MsgFromID = 1, _MsgID = 0;
        private DateTime _MsgDate = DateTime.Now;
        private string _MsgFromUsr, _MsgToUsr;
        private string _MsgFromUserName, _MsgSubject, _Email;


        [DataMember]
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }



        [DataMember]
        public string MsgSubject
        {
            get { return _MsgSubject; }
            set { _MsgSubject = value; }
        }

        [DataMember]
        public DateTime MsgDate
        {
            get { return _MsgDate; }
            set { _MsgDate = value; }
        }


        [DataMember]
        public string MsgToUsr
        {
            get { return _MsgToUsr; }
            set { _MsgToUsr = value; }
        }
        [DataMember]
        public string MsgFromUsr
        {
            get { return _MsgFromUsr; }
            set { _MsgFromUsr = value; }
        }

        [DataMember]
        public int MsgFromID
        {
            get { return _MsgFromID; }
            set { _MsgFromID = value; }
        }
        [DataMember]
        public int MsgID
        {
            get { return _MsgID; }
            set { _MsgID = value; }
        }
        [DataMember]
        public string MsgFromUserName
        {
            get { return _MsgFromUserName; }
            set { _MsgFromUserName = value; }
        }
    }
}
