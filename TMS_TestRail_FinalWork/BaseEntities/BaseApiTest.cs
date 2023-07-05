using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_TestRail_FinalWork.Clients;
using TMS_TestRail_FinalWork.Services;

namespace TMS_TestRail_FinalWork.BaseEntities
{
    public class BaseApiTest
    {
        protected ApiClient _apiClient;
        protected UserService _userService;         

        [OneTimeSetUp]
        public void InitApiClient()
        {
            _apiClient = new ApiClient();
            _userService = new UserService(_apiClient);            
        }
    }
}
