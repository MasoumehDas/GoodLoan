using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Models
{
    public class UserMenuDto : MainEntitiesDto
    {

        public int UserMenuId { get; set; }
        public string ControlID { get; set; }
        public string Title { get; set; }
        public string Lang { get; set; }
        public bool? IsShow { get; set; }

    }

   
}
