using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using TMS_TestRail_FinalWork.Models.Enum;

namespace TMS_TestRail_FinalWork.Models
{
    public record User
    {
        public UserType UserType { get; set; }
        [JsonPropertyName("id")] public int Id { get; set; }
        [JsonPropertyName("name")] public string Username { get; set; }
        public string Password { get; set; }
        [JsonPropertyName("email")] public string Email { get; set; }   
    }
}
