﻿using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_TestRail_FinalWork.Utilities.Helpers
{
    public class JsonHelper
    {
        public static JObject FromJson(string json)
        {
            return JsonConvert.DeserializeObject<JObject>(json);
        }
    }
}
