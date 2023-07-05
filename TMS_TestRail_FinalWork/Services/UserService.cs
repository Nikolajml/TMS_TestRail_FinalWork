using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TMS_TestRail_FinalWork.Clients;
using TMS_TestRail_FinalWork.Models;
using TMS_TestRail_FinalWork.Models.Api;
using TMS_TestRail_FinalWork.Utilities.Configuration;

namespace TMS_TestRail_FinalWork.Services
{
    public class UserService : BaseService
    {               
        public UserService(ApiClient apiClient) : base(apiClient)
        {

        }

        public RestResponse GetUser(int userId)
        {
            var request = new RestRequest(Endpoints.GET_USER)
                .AddUrlSegment("user_id", userId);

            return _apiClient.Execute(request);
        }

        public RestResponse AddUser(UserModelApi user)
        {
            var request = new RestRequest(Endpoints.ADD_USER, Method.Post)                
                .AddHeader("Content-Type", "application/json")
                .AddBody(user);

            return _apiClient.Execute(request);
        }
    }
}
