using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TMS_TestRail_FinalWork.Models
{
    public class Case
    {
        public string Title { get; set; }
        public string Preconditions { get; set; }
        public string Steps { get; set; }
        public string ExpectedResult { get; set; }
    }
}
