using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_TestRail_FinalWork.Utilities.Configuration
{
    public class Endpoints
    {
        public static readonly string ADD_PROJECT = "index.php?/api/v2/add_project";
        public static readonly string GET_PROJECT = "index.php?/api/v2/get_project/{project_id}";
        public static readonly string ADD_USER = "index.php?/api/v2/add_user";
        public static readonly string GET_USER = "index.php?/api/v2/get_user/{user_id}";
        public static readonly string ADD_MILESTONE = "index.php?/api/v2/add_milestone/{project_id}";
        public static readonly string GET_MILESTONE = "index.php?/api/v2/get_milestone/{milestone_id}";
    }
}
