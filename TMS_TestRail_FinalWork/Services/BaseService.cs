using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_TestRail_FinalWork.Clients;

namespace TMS_TestRail_FinalWork.Services
{
    public class BaseService
    {
        protected ApiClient _apiClient;

        public BaseService(ApiClient apiClient)
        {
            _apiClient = apiClient;
        }
    }
}
