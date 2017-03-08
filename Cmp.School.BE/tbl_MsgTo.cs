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
    public class tbl_MsgTo : BaseBE
    {
         //variable and default values
        private int _MsgToID, _MsgID;
        private string _SentToUserName, _Status="Unread";
        private string _FromUserName, _MsgFromUsr, _MsgToUsr, _MsgSubject,_Email;
        private bool _Notification = false;

        
       
        [DataMember]
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        [DataMember]
        public bool Notification
        {
            get { return _Notification; }
            set { _Notification = value; }
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
        public string FromUserName
        {
            get { return _FromUserName; }
            set { _FromUserName = value; }
        }
        
        [DataMember]
        public int MsgToID
        {
            get { return _MsgToID; }
            set { _MsgToID = value; }
        }
        [DataMember]
        public int MsgID
        {
            get { return _MsgID; }
            set { _MsgID = value; }
        }
        [DataMember]

        public string SentToUserName
        {
            get { return _SentToUserName; }
            set { _SentToUserName = value; }
        }
        [DataMember]
        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
    
    }
}
