using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TMS_TestRail_FinalWork.Clients;
using TMS_TestRail_FinalWork.Models;
using TMS_TestRail_FinalWork.Utilities.Configuration;

namespace TMS_TestRail_FinalWork.Services
{
    public class ProjectService : BaseService
    {
        public ProjectService(ApiClient apiClient) : base(apiClient)
        {

        }

        public Project AddAsProject(Project project)
        {
            var request = new RestRequest(Endpoints.ADD_PROJECT, Method.Post)
                .AddHeader("Content-Type", "application/json")
                .AddBody(project);

            return _apiClient.Execute<Project>(request);
        }

        public Project GetAsProject(int projectId)
        {
            var request = new RestRequest(Endpoints.GET_PROJECT)
                .AddUrlSegment("project_id", projectId);

            return _apiClient.Execute<Project>(request);
        }

        public async Task<RestResponse> GetProjectAsync(int projectId)
        {
            var request = new RestRequest(Endpoints.GET_PROJECT)
                .AddUrlSegment("project_id", projectId);

            return await _apiClient.ExecuteAsync(request);
        }
    }
}