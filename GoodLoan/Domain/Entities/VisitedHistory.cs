using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class VisitedHistory : MainEntities
    {
        public int Id { get; set; }
        public string IP { get; set; }
        public string Date_shansi { get; set; }
        public string Browser { get; set; }
    }
    
}
