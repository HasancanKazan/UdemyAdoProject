using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBANK.Models
{
    class Bank
    {
        public string BANKCODE { get; set; }
        public string DESCRIPTION { get; set; }
        public bool KATILIM_FLG { get; set; }
        public bool ABROAD_FLG { get; set; }
        public bool BLOCKED_FLG { get; set; }
        public string CREUSER { get; set; }
        public DateTime CREDATE { get; set; }
        public string MODUSER { get; set; }
        public DateTime MODDATE { get; set; }

        public override string ToString()
        {
            return DESCRIPTION;
        }
    }
}
