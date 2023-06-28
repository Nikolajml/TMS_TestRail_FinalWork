using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_TestRail_FinalWork.Models.Enum;

namespace TMS_TestRail_FinalWork.Models
{
    public class Project
    {
        public ProjectType Type { get; set; }
        public string Name { get; set; }
        public string Announcement { get; set; }        
    }
}
