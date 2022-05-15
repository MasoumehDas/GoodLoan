using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public  class Setting : MainEntities
    {
        public int SettingId { get; set; }
        public string SettingName { get; set; }
        public string SettinCaption { get; set; }
        public string SettingValue { get; set; }
        public string Category { get; set; }
        
    }
    
}
