using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBANK.Models
{
    class Branch
    {
        public int BRANCHCODE { get; set; }
        public string BANKCODE { get; set; }
        public string CURRENCYCODE { get; set; }
        public string DESCRIPTION { get; set; }
        public string BANKCITY { get; set; }
        public bool PASSIVE_FLG { get; set; }
        public bool ABROAD_FLG { get; set; }
        public bool BLOCKED_FLG { get; set; }
        public string EMAIL { get; set; }
        public string BANKNUMBER { get; set; }
        public string CREUSER { get; set; }
        public DateTime CREDATE { get; set; }
        public string MODUSER { get; set; }
        public DateTime MODDATE { get; set; }
    }
}
