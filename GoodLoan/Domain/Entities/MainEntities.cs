using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
   public class MainEntities
    {
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public  int? ModifyUserId { get; set; }
        public int? CreateUserId { get; set; }
        public string Description { get; set; }
        public bool? Active { get; set; }

    }
}
