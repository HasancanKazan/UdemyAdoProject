using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBANK.Users
{
    public class User
    {
        public string USER_ID { get; set; }
        public string USER_NAME { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public int USER_TYPE { get; set; }
        public string CRE_USER { get; set; }
        public DateTime CRE_DATE { get; set; }
        public string MOD_USER { get; set; }
        public DateTime MOD_DATE { get; set; }
        public bool ISACTIVE { get; set; }
        public string PHONE_NUMBER { get; set; }
        public string EMAIL { get; set; }
        public string FULL_NAME 
        {
            get { return FIRST_NAME + " " + LAST_NAME; } 
        }
    }
}
