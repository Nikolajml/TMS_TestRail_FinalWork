using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using TMS_TestRail_FinalWork.Models.Enum;

namespace TMS_TestRail_FinalWork.Models
{
    public class Project
    {
        public ProjectType Type { get; set; }
        [JsonPropertyName("id")] public int Id { get; set; }
        [JsonPropertyName("name")] public string Name { get; set; }
        [JsonPropertyName("announcement")] public string Announcement { get; set; }
    }
}
