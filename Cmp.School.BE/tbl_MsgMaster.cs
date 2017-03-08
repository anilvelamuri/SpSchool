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
    public class tbl_MsgMaster:BaseBE
    {
        //variable and default values
        private int _MsgID = -1, _Count;

      
        private string _MsgSubject = "New message", _MsgBody, _MsgFromUsr, _MsgToUsr, _Email, _SentToUserName, _MsgFromUserName;


        [DataMember]
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }



        [DataMember]
        public int MsgID
        {
            get { return _MsgID; }
            set { _MsgID = value; }
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
        public string MsgBody
        {
            get { return _MsgBody; }
            set { _MsgBody = value; }
        }
        [DataMember]
        public string MsgSubject
        {
            get { return _MsgSubject; }
            set { _MsgSubject = value; }
        }
        private DateTime _MsgDate;
        [DataMember]
        public DateTime MsgDate
        {
            get { return _MsgDate; }
            set { _MsgDate = value; }
        }

       [DataMember]
        public string SentToUserName
        {
            get { return _SentToUserName; }
            set { _SentToUserName = value; }
        }

        [DataMember]
        public string MsgFromUserName
        {
            get { return _MsgFromUserName; }
            set { _MsgFromUserName = value; }
        }

        [DataMember]
        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }

    }
}
